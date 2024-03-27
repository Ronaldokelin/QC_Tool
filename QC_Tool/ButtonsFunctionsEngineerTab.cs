using System.Windows.Forms;

namespace QC_Tool
{
    class ButtonsFunctionsEngineerTab
    {
        public static void passValueButton(ListBox listBoxAll, ListBox listBoxInclude)
        {
            listBoxInclude.Items.Add(listBoxAll.SelectedItem.ToString());
        }

        public static void removeValueButton(ListBox listBoxAll, ListBox listBoxInclude)
        {
            listBoxInclude.Items.Remove(listBoxAll.SelectedItem.ToString());
        }
    }
}
