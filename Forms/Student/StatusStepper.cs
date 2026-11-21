using STIERegistrar.Helpers;
using STIERegistrar.Models;

namespace STIERegistrar.Forms
{
    /// <summary>
    /// Draws the 5-step progress line:
    /// Pending - Approved - Processing - Ready for Pick-up - Released.
    /// It is drawn with code (no designer), so it is just one control to drop on a page.
    /// </summary>
    public class StatusStepper : Control
    {
        private string _status = RequestStatus.Pending;

        public StatusStepper()
        {
            DoubleBuffered = true;
            Height = 80;
            Width = 600;
            BackColor = Color.White;
        }

        /// <summary>Set the current status. The control redraws itself.</summary>
        public void SetStatus(string status)
        {
            _status = status;
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            string[] steps = RequestStatus.Flow;
            int count = steps.Length;
            int current = Array.IndexOf(steps, _status);   // -1 for Rejected
            bool rejected = _status == RequestStatus.Rejected;

            int radius = 8;
            int left = 30;
            int right = Width - 60;
            int y = 22;
            float gap = (right - left) / (float)(count - 1);

            using (var lineDone = new Pen(rejected ? Color.Firebrick : UiHelper.Blue, 3))
            using (var lineTodo = new Pen(UiHelper.LightLine, 3))
            using (var fillDone = new SolidBrush(rejected ? Color.Firebrick : UiHelper.Blue))
            using (var fillTodo = new SolidBrush(UiHelper.LightLine))
            using (var textBrush = new SolidBrush(UiHelper.TextMuted))
            using (var textActive = new SolidBrush(rejected ? Color.Firebrick : UiHelper.Blue))
            using (var fontNormal = new Font("Segoe UI", 8.5f))
            using (var fontBold = new Font("Segoe UI", 8.5f, FontStyle.Bold))
            {
                // Lines between circles
                for (int i = 0; i < count - 1; i++)
                {
                    bool done = !rejected && i < current;
                    g.DrawLine(done ? lineDone : lineTodo, left + i * gap, y, left + (i + 1) * gap, y);
                }

                // Circles and labels
                for (int i = 0; i < count; i++)
                {
                    float x = left + i * gap;
                    bool done = !rejected && i <= current;
                    g.FillEllipse(done ? fillDone : fillTodo, x - radius, y - radius, radius * 2, radius * 2);

                    string text = steps[i];
                    bool isCurrent = !rejected && i == current;
                    var font = isCurrent ? fontBold : fontNormal;
                    SizeF size = g.MeasureString(text, font);
                    g.DrawString(text, font, isCurrent ? textActive : textBrush, x - size.Width / 2, y + 18);
                }

                if (rejected)
                {
                    g.DrawString("This request was rejected.", fontBold, textActive, left - 10, y + 42);
                }
            }
        }
    }
}
