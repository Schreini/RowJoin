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

namespace RowJoin.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
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
    }
}
