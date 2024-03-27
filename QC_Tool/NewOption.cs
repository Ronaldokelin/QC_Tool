using System;
using System.Windows.Forms;

namespace QC_Tool
{
    public partial class NewOption : Form
    {
        private ListBox include;
        public NewOption()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            include.Items.Add(textBoxNewItem.Text);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addingNew(ListBox includeValue)
        {
            include = includeValue;
        }

    }
}
