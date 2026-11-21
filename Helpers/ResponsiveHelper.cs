namespace STIERegistrar.Helpers
{
    /// <summary>
    /// Makes a page (UserControl) resize with the window.
    /// Call ResponsiveHelper.Apply(this) right after InitializeComponent().
    ///
    /// How it works:
    ///  1. Big boxes (cards, grids, panels) grow and shrink with the window width.
    ///  2. Buttons on the right side stay stuck to the right edge.
    ///  3. The last panel that holds a grid or chart also grows with the window height.
    ///  4. Controls inside a panel get Anchors, so they follow their panel.
    /// </summary>
    public static class ResponsiveHelper
    {
        private enum Mode { Left, Right, Stretch }

        private class Item
        {
            public Control Control;
            public Mode Mode;
            public float LeftFraction;    // for Stretch: Left / design width
            public float WidthFraction;   // for Stretch: Width / design width
            public int RightMargin;       // for Right: gap to the right edge (design pixels)
            public bool StretchHeight;
            public int DesignHeight;
            public int BottomMargin;      // design pixels
        }

        public static void Apply(UserControl page)
        {
            // At this moment the page still has its design size (set in the designer).
            int designWidth = page.Width;
            int designHeight = page.Height;

            var items = new List<Item>();
            var top = page.Controls.Cast<Control>().Where(c => c.Dock == DockStyle.None).ToList();
            if (top.Count == 0) return;

            int maxBottom = top.Max(c => c.Bottom);

            // Find the big data panels at the bottom (they will grow with the height).
            var tall = top.Where(c => IsBigDataBox(c) && c.Bottom >= maxBottom - 15).ToList();
            foreach (Control c in top)
            {
                bool sameRow = tall.Any(t => Math.Abs(t.Top - c.Top) <= 5)
                               && c is Panel && c.Bottom >= maxBottom - 15;

                var item = new Item { Control = c };
                item.StretchHeight = tall.Contains(c) || sameRow;
                item.DesignHeight = c.Height;
                item.BottomMargin = Math.Max(0, designHeight - c.Bottom);

                if (IsStretchType(c) && c.Width >= 150)
                {
                    item.Mode = Mode.Stretch;
                    item.LeftFraction = c.Left / (float)designWidth;
                    item.WidthFraction = c.Width / (float)designWidth;
                }
                else if (c.Left + c.Width / 2 > designWidth * 0.55)
                {
                    item.Mode = Mode.Right;
                    item.RightMargin = designWidth - c.Right;
                }
                else
                {
                    item.Mode = Mode.Left;
                }
                items.Add(item);
            }

            // Inner controls follow their panel with Anchors.
            foreach (Control c in top) AnchorChildren(c);

            // Top-level controls are placed by this helper, so stop WinForms from moving them.
            foreach (Item item in items) item.Control.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            page.Resize += (s, e) => Relayout(page, items, designWidth);
            page.Load += (s, e) => Relayout(page, items, designWidth);
        }

        private static void Relayout(UserControl page, List<Item> items, int designWidth)
        {
            float dpi = page.DeviceDpi / 96f;
            int minWidth = (int)(designWidth * dpi);
            int w = Math.Max(page.ClientSize.Width, minWidth);
            int h = page.ClientSize.Height;
            int scrollX = page.AutoScrollPosition.X;
            int scrollY = page.AutoScrollPosition.Y;

            page.SuspendLayout();
            foreach (Item item in items)
            {
                Control c = item.Control;

                if (item.Mode == Mode.Stretch)
                {
                    c.Left = (int)(item.LeftFraction * w) + scrollX;
                    c.Width = Math.Max(1, (int)(item.WidthFraction * w));
                }
                else if (item.Mode == Mode.Right)
                {
                    c.Left = w - (int)(item.RightMargin * dpi) - c.Width + scrollX;
                }

                if (item.StretchHeight)
                {
                    int minHeight = (int)(item.DesignHeight * dpi);
                    int wanted = h - (c.Top - scrollY) - (int)(item.BottomMargin * dpi);
                    c.Height = Math.Max(minHeight, wanted);
                }
            }
            page.ResumeLayout(true);
        }

        // ---------- Helpers ----------

        private static bool IsStretchType(Control c)
        {
            return c is Panel || c is DataGridView || c is TextBox
                || c is ComboBox || c is ProgressBar || c is Button;
        }

        private static bool IsData(Control c)
        {
            return c is DataGridView;
        }

        /// <summary>A grid, or a panel where a grid uses most of the height.</summary>
        private static bool IsBigDataBox(Control c)
        {
            if (c.Height < 150) return false;
            if (IsData(c)) return true;
            if (!(c is Panel)) return false;
            return c.Controls.Cast<Control>().Any(x => IsData(x) && x.Height >= c.Height * 0.5);
        }

        /// <summary>Sets Anchor on the controls inside a panel, based on where they sit.</summary>
        private static void AnchorChildren(Control parent)
        {
            if (!(parent is Panel)) return;
            int pw = parent.Width;
            int ph = parent.Height;

            foreach (Control c in parent.Controls)
            {
                if (c.Dock != DockStyle.None) continue;

                AnchorStyles anchor;

                // Horizontal: wide controls stretch, right-side controls stick to the right.
                if (IsStretchType(c) && c.Width >= pw * 0.55)
                    anchor = AnchorStyles.Left | AnchorStyles.Right;
                else if (c.Left + c.Width / 2 > pw * 0.6)
                    anchor = AnchorStyles.Right;
                else
                    anchor = AnchorStyles.Left;

                // Vertical: big grids and charts grow, bottom items stick to the bottom.
                if (IsData(c) && c.Height >= ph * 0.5)
                    anchor |= AnchorStyles.Top | AnchorStyles.Bottom;
                else if (c.Top > ph * 0.82)
                    anchor |= AnchorStyles.Bottom;
                else
                    anchor |= AnchorStyles.Top;

                c.Anchor = anchor;
                AnchorChildren(c);
            }
        }
    }
}
