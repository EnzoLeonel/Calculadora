using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Vista : Form
    {
        Controlador controlador;
        public Vista()
        {
            InitializeComponent();
        }
        public void setControlador(Controlador controlador)
        {
            this.controlador = controlador;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            controlador.colocarNumero("9");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            controlador.borrarTodo();
        }

        private void btnParent1_Click(object sender, EventArgs e)
        {
            controlador.colocarParentesisAB();

        }
        private void btnParent2_Click(object sender, EventArgs e)
        {
            controlador.colocarParentesisCE();
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            controlador.colocarPunto();   
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            controlador.division();
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            controlador.multiplicacion();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            controlador.resta();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            controlador.suma();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                //Guarda en una variable, el valor ASCII del ultimo caracter en pantalla
                int ultimo = pantalla.Text[pantalla.Text.Length - 1];
                if (ultimo >= 48 && ultimo <= 57 && pantallaRes.TextLength != 0)
                {
                    pantallaRes.Text = (controlador1.Resultado(float.Parse(pantallaRes.Text), float.Parse(controlador1.getUltimo()))).ToString();
                    if(ultimo != 61)
                    {
                        pantalla.Text = pantalla.Text + "=";
                    }
                }
            }
            //Control de excepciones en caso de que el usuario coloque un "-" estando el campo vacio
            catch (IndexOutOfRangeException)
            {
                pantalla.Text = "";
            }
            */

        }
    }
            
}
//Grupo 3: Enzo Sanchez, Enzo Santilli, Gonzalo Campos, Lucas Sanchez
