using System.Windows.Forms;

namespace QC_Tool
{
    class ButtonsFunctionsEngineerTab
    {
        public static void passValueButton(ListBox listBoxAll, ListBox listBoxInclude)
        {
            try
            {
                listBoxInclude.Items.Add(listBoxAll.SelectedItem.ToString());
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
