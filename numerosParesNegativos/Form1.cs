using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerosParesNegativos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            int i = 0;

            
            for (i = 0; i > -42; i--){

                if (i < 0) {

                    if (i % 2 == 0)
                    {


                        lsbnegativos.Items.Add(i.ToString());
                    }

                }
                


            }

            i--;

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
