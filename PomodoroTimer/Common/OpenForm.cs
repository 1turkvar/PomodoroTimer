using System;
using System.Drawing;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class OpenForm
    {
        /// <summary>
        /// Panel içi form
        /// </summary>
        public static Form activeForm = null;
        public static void FormInPanel(Form ChildForm, Panel PanelZemin)
        {
            try
            {
                // activeForm nesnesi varsa, kapatılır.
                activeForm?.Close();

                // activeForm nesnesi ChildForm ile güncellenir.
                activeForm = ChildForm;

                // ChildForm'un TopLevel özelliği "false" olarak ayarlanır.
                ChildForm.TopLevel = false;
                // ChildForm'un FormBorderStyle özelliği "None" olarak ayarlanır.
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                // ChildForm'un Dock özelliği "Fill" olarak ayarlanır.
                ChildForm.Dock = DockStyle.Fill;

                // ChildForm PanelZemin içinde gösterilir.
                PanelZemin.Controls.Add(ChildForm);

                // ChildForm'a ait Tag özelliğine PanelZemin atanır.
                PanelZemin.Tag = ChildForm;

                // ChildForm boyutunu ayarla
                ChildForm.Size = new Size(PanelZemin.Width / 2, PanelZemin.Height / 2);

                // ChildForm konumunu ayarla
                ChildForm.Location = new Point((PanelZemin.Width - ChildForm.Width) / 2, (PanelZemin.Height - ChildForm.Height) / 2);

                // ChildForm öne getirilir.

                ChildForm.BringToFront();
                // ChildForm gösterilir.
                ChildForm.Show();
            }
            catch (Exception ex)
            {
                // Hata kaydedilir.
                Logger.WriteError(ex.Message, "OpenForminPanel");
            }
        }
        public static void Form(Form ChildForm)
        {
            try
            {
                // activeForm nesnesi varsa, kapatılır.
                activeForm?.Close();

                // activeForm nesnesi ChildForm ile güncellenir.
                activeForm = ChildForm;

                // ChildForm gösterilir.
                ChildForm.Show();
            }
            catch (Exception ex)
            {
                // Hata kaydedilir.
                Logger.WriteError(ex.Message, "OpenForm");
            }
        }
    }
}
