using System;
using System.Windows.Forms;

namespace PersonalProjects.General
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            txtResults.Text = string.Empty;

            var fields = txtFieldList.Text.Split('\n');
            foreach (var fld in fields)
            {
                if (fld.Trim() != string.Empty)
                    CreateCodeForField(fld.Trim());
            }
        }

        private void CreateCodeForField(string fld)
        {
            if (txtResults.Text != string.Empty)
                txtResults.Text += Environment.NewLine;
            txtResults.Text += txtCodeTemplate.Text.Replace("%FLD%", fld);
        }
    }
}
