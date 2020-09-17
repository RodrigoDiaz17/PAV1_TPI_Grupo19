using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaMET.Clases.MetodosGenerales.Forms
{
    public static class MetodosForms
    {
        public static void MostrarOcultarPanel(Panel panel)
        {
            if (panel.Visible) { panel.Visible = false; }
            else { panel.Visible = true; }
        }
        public static void AbrirFormEnPanel(object formA, System.Windows.Forms.Panel pnl1)
        {
            if (pnl1.Controls.Count > 0) pnl1.Controls.RemoveAt(0);
            System.Windows.Forms.Form fh = formA as System.Windows.Forms.Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnl1.Controls.Add(fh);
            pnl1.Tag = fh;
            pnl1.Controls.Find(fh.Name, false);
            fh.Show();
        }
        public static void OnlyIntergers(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('')) { e.Handled = false; }
            //else if (e.KeyChar.Equals('\r')) { Iniciar(); }
            else
            {
                Console.WriteLine(e.KeyChar);
                e.Handled = true;
            }
        }
        public static void OnlyDoubles(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = ((TextBox)sender);
            if (textbox.TextLength.Equals(0))
            {
                OnlyIntergers(sender, e);
            }
            else
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals(','))
                {
                    bool pass = false;
                    foreach (char digit in textbox.Text)
                    {
                        if (digit.Equals(',')) { pass = true; }

                    }
                    e.Handled = pass;
                }
                else if (e.KeyChar.Equals('')) { e.Handled = false; }
                //else if (e.KeyChar.Equals('\r')) { Iniciar(); }
                else
                {
                    e.Handled = true;
                }
            }


        }
    }
}
