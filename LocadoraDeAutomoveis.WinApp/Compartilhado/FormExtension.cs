using LocadoraDeAutomoveis.WinApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.Compartilhado
{
    public static class FormExtension
    {
        public static void ConfigurarDialog(this Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.Icon = Resources.promoting;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
