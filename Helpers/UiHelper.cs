using System.Drawing;

namespace STIERegistrar.Helpers
{
    /// <summary>Shared colors from the design and small UI helpers.</summary>
    public static class UiHelper
    {
        public static readonly Color Navy = ColorTranslator.FromHtml("#0F3478");
        public static readonly Color Blue = ColorTranslator.FromHtml("#1A5CDB");
        public static readonly Color Yellow = ColorTranslator.FromHtml("#FFD54A");
        public static readonly Color PageBack = ColorTranslator.FromHtml("#F2F5FA");
        public static readonly Color FieldBack = ColorTranslator.FromHtml("#F2F5FA");
        public static readonly Color TextDark = ColorTranslator.FromHtml("#14284B");
        public static readonly Color TextMuted = ColorTranslator.FromHtml("#6B7A99");
        public static readonly Color YellowSoft = ColorTranslator.FromHtml("#FFF4C7");
        public static readonly Color BlueSoft = ColorTranslator.FromHtml("#E8EFFC");
        public static readonly Color LightLine = ColorTranslator.FromHtml("#DDE3EE");

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "STI E-Registrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "STI E-Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Confirm(string message)
        {
            return MessageBox.Show(message, "STI E-Registrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Makes a flat blue or yellow button like the design.</summary>
        public static void StyleButton(Button b, bool primary = true)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;
            b.BackColor = primary ? Blue : BlueSoft;
            b.ForeColor = primary ? Color.White : Blue;
            b.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        /// <summary>Basic look for every DataGridView.</summary>
        public static void StyleGrid(DataGridView g)
        {
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.RowHeadersVisible = false;
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Color.White;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = BlueSoft;
            g.ColumnHeadersDefaultCellStyle.ForeColor = TextMuted;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeight = 34;
            g.DefaultCellStyle.SelectionBackColor = BlueSoft;
            g.DefaultCellStyle.SelectionForeColor = TextDark;
            g.DefaultCellStyle.ForeColor = TextDark;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            g.RowTemplate.Height = 38;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = LightLine;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
