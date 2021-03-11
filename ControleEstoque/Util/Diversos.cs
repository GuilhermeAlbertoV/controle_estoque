using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Util
{
    public class Diversos
    {

        public static void ControlBackColorGor(object sender, Color? c= null)
        {
            try
            {
                switch (sender.GetType().Name.ToUpper())
                {
                    case "TEXTBOX":
                        TextBox x =((TextBox) sender);
                        x.BackColor = c ?? Color.LightCyan;
                        break;
                    case "MASKEDTEXTBOX":
                        MaskedTextBox m = ((MaskedTextBox)sender);
                        m.BackColor = c ?? Color.LightCyan;
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  static void ControlBackColorLost(object sender, Color? c = null)
        {
            try
            {
                switch (sender.GetType().Name.ToUpper())
                {
                    case "TEXTBOX":
                        TextBox x = ((TextBox)sender);
                        x.BackColor = c ?? Color.White;
                        break;
                    case "MASKEDTEXTBOX":
                        MaskedTextBox m = ((MaskedTextBox)sender);
                        m.BackColor = c ?? Color.White;
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static string PrimeiraLetraMaiuscula(string campo)
        {
            //Todo campo paraMaiusculo
            campo = campo.ToLower();

            // E retorna a primaira letra maiuscula de cada maiusculo
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            return cultureInfo.TextInfo.ToTitleCase(campo);

        } 

        

    }
}
