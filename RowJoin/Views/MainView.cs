using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RowJoin.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            CbxTemplate.SelectedIndex = 1;
        }

        private string Join()
        {
            StringBuilder result = new StringBuilder();
            result.Append(TxtHeader.Text);
            string[] lines = TxtInput.Text.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i<lines.Length; i++)
            {
                lines[i] = $"{TxtBefore.Text}{lines[i]}{TxtAfter.Text}";
            }
            result.Append(string.Join(TxtBetween.Text, lines));
            result.Append(TxtFooter.Text);
            return result.ToString();
        }

        private void TxtHeader_TextChanged(object sender, EventArgs e)
        {
            TxtOutput.Text = Join();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var templates = new List<JoinTemplate>();
            templates.Add(new JoinTemplate(0, "select * from $TABLE where ", "$COLUMN like '%", " or ", "%'", ""));
            templates.Add(new JoinTemplate(1, "(", "'", "', '", "'", ")"));
            var cbx = (ComboBoxEdit) sender;
            var template = templates.ElementAt(cbx.SelectedIndex);
            TxtHeader.Text = template.Header;
            TxtBefore.Text = template.BeforeEach;
            TxtBetween.Text = template.BetweenEach;
            TxtAfter.Text = template.AfterEach;
            TxtFooter.Text = template.Footer;
            Join();
        }
    }

    public class JoinTemplate
    {
        public JoinTemplate(int index, string header, string beforeEach, string betweenEach, string afterEach, string footer)
        {
            Index = index;
            Header = header;
            BeforeEach = beforeEach;
            BetweenEach = betweenEach;
            AfterEach = afterEach;
            Footer = footer;
        }

        public int Index { get; private set; }
        public string Header { get; private set; }
        public string BeforeEach { get; private set; }
        public string BetweenEach { get; private set; }
        public string AfterEach { get; private set; }
        public string Footer { get; private set; }
    }
}
