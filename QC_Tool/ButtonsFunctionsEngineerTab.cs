using System.Windows.Forms;

namespace QC_Tool
{
    class ButtonsFunctionsEngineerTab
    {
        public static void passValueButton(ListBox listBoxAll, ListBox listBoxInclude)
        {
            try
            {
                if (listBoxAll.SelectedItem.ToString() == "NEW...")
                {
                    NewOption no = new NewOption();
                    no.Show();
                    no.addingNew(listBoxInclude);
                }
                else
                    listBoxInclude.Items.Add(listBoxAll.SelectedItem.ToString());
            }
            catch { }
        }
        public static void passValueButton(ListBox listBoxInclude, string newValue)
        {
            try
            {
                listBoxInclude.Items.Add(newValue);
            }
            catch { }
        }


        public static void removeValueButton(ListBox listBoxAll, ListBox listBoxInclude)
        {
            try
            {
                listBoxInclude.Items.Remove(listBoxAll.SelectedItem.ToString());
            }
            catch { }
        }
    }
}
