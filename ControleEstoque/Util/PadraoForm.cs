using ControleEstoque.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Util
{
    public class PadraoForm
    {
        public static void SettingsForm(Form form)
        {
            form.BackColor = Color.White;
            form.KeyPreview = true;
            form.StartPosition = FormStartPosition.CenterParent;
            form.MaximizeBox = false;
        }
    }
}
