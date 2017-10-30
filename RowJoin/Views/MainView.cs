using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RowJoin.Views
{
    public partial class MainView : Form
    {
        private List<JoinTemplate> _templates;

        public MainView()
        {
            InitializeComponent();
            InitializeTemplates();
        }

        private void InitializeTemplates()
        {
            _templates = new List<JoinTemplate>();
            _templates.Add(new JoinTemplate("('...', ...)", "(", "'", ", ", "'", ")"));
            _templates.Add(new JoinTemplate("Select ... like ... or ...", "select * from $TABLE where ", "$COLUMN like '%", " or ", "%'", ""));
            _templates.Add(new JoinTemplate("<empty>", "", "", "", "", ""));

            int i = 0;
            foreach (var template in _templates)
            {
                CbxTemplate.Properties.Items.Add(template.Name);
                template.Index = i++;
            }
        }

        private void Join()
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
            result.Replace("\\r", "\r");
            result.Replace("\\n", "\n");
            result.Replace("\\t", "\t");
            TxtOutput.Text = result.ToString();
        }

        private void TxtHeader_TextChanged(object sender, EventArgs e)
        {
            if(AutoJoin)
                Join();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = (ComboBoxEdit) sender;
            var template = _templates.ElementAt(cbx.SelectedIndex);
            AutoJoin = false;
            TxtHeader.Text = template.Header;
            TxtBefore.Text = template.BeforeEach;
            TxtBetween.Text = template.BetweenEach;
            TxtAfter.Text = template.AfterEach;
            TxtFooter.Text = template.Footer;
            AutoJoin = true;
            Join();
        }

        public bool AutoJoin { get; private set; }
    }

    public class JoinTemplate
    {
        public JoinTemplate(string name,  string header, string beforeEach, string betweenEach, string afterEach, string footer)
        {
            Name = name;
            Header = header;
            BeforeEach = beforeEach;
            BetweenEach = betweenEach;
            AfterEach = afterEach;
            Footer = footer;
        }

        public int Index { get; set; }
        public string Name { get; private set; }
        public string Header { get; private set; }
        public string BeforeEach { get; private set; }
        public string BetweenEach { get; private set; }
        public string AfterEach { get; private set; }
        public string Footer { get; private set; }
    }
}
