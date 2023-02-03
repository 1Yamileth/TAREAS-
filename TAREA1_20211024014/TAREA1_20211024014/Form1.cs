using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA1_20211024014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CALCULO_button_Click(object sender, EventArgs e)
        {
            if (NUmero_textBox.Text == "")
            {
                Numero_errorProvider.SetError(NUmero_textBox, "INGRESE UN VALOR ");
                return;

            }
            int numero1 = Convert.ToInt32(NUmero_textBox.Text);//GUARDANDO EL VALOR EN UNA VARIABLE

            Par(numero1);
            PosNeg(numero1);


        }

        //FUNCION DE PAR E IMPAR
        private int Par(int num)
        {
            //int resultado=0;
            if (num%2==0 )
            {
                RESULTADO_PoI_textBox.Text= Convert.ToString( num + " ES PAR");
            }
            else if (num % 2 != 0)
            {
                RESULTADO_PoI_textBox.Text = Convert.ToString(num + " ES IMPAR");
            }
            return num;
        }

        //FUNCION PARA NEGATIVO O POSITIVO
        private int PosNeg(int num2)
        {
            if (num2 > 1)
            {
                ResultadoPoN_textBox.Text=  ( num2 + " ES POSITIVO");

            }else if (num2 < 0)
            {
                ResultadoPoN_textBox.Text = ( num2 + " ES NEGATIVO");

            }
            else if (num2 == 0)
            {
                ResultadoPoN_textBox.Text = ("EL NUMERO " + num2 + " ES NEUTRO");

            }
            return num2;

        }

        private void Limpiar_button_Click(object sender, EventArgs e)
        {
            ResultadoPoN_textBox.Clear();
            RESULTADO_PoI_textBox.Clear();
            NUmero_textBox.Clear();
        }
    }
}
