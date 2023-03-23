using System.Windows.Forms;

namespace CarPartsOnlineStore.Classes
{
    public class FormSwitch
    {
        public static void Switch(Form currentForm, Form nextForm)
        {
            currentForm.Hide();
            nextForm.ShowDialog();
            currentForm.Close();
        }

        public static void LoadFormAsControl(Control container, Form form)  
        {
            container.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            container.Controls.Add(form);
            form.Show();
        }
    }
}
