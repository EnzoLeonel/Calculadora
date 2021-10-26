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
        /*
        private void operacion(string operacion, int id)
        {
            try
            {
                int ultimo = pantalla.Text[pantalla.Text.Length - 1];
                //Si lo ultimo ingresado es un numero y se intenta realizar suma
                if ((ultimo >= 48 && ultimo <= 57) && (id == 1))
                {
                    controlador1.nuevoTermino(float.Parse(controlador1.getUltimo()));
                    controlador1.setUltimo(operacion);
                    if(pantallaRes.TextLength == 0)
                    {
                        pantallaRes.Text = pantalla.Text;
                    }
                    else
                    {
                        pantallaRes.Text = controlador1.resultadoTemp().ToString();
                    }
                    pantalla.Text = pantalla.Text + operacion;
                }
                else if((ultimo >= 48 && ultimo <= 57) && (id >= 3))
                {

                }
            }
            //Control de excepciones en caso de que el usuario coloque un "operador" estando el campo vacio
            catch (IndexOutOfRangeException)
            {
                //Si la pantalla esta en blanco y se presiona un operador, si es distinto a 2, no coloca nada
                if (id != 2)
                {
                    pantalla.Text = "";
                }
                //Si el operador es 2 (operacion de restar), coloca un "-"
                else
                {
                    pantalla.Text = "-";
                }

            }
        }

        /*private void operacion(string operacion, int id)
        {
            //string operacion es el caracter que va a figurar por pantalla
            //int id es el identificador de la operacion que se quiere realizar, 1(sumar),2(restar),3(multip),4(dividir)
            try
            {
                //Guarda en una variable, el valor ASCII del ultimo caracter en pantalla
                int ultimo = pantalla.Text[pantalla.Text.Length - 1];
                if (ultimo >= 48 && ultimo <= 57)
                {
                    //Si la pantalla de resultado está vacia, coloca el ultimo numero digitado en la misma, y asigna la operacion
                    if (pantallaRes.TextLength == 0)
                    {
                        pantallaRes.Text = pantalla.Text;
                        controlador1.setUltimo("");
                        controlador1.setOperacion(id);
                    }
                    //Si la pantalla de resultado ya contiene un resultado, realiza la operacion con el ultimo numero digitado y el numero de abajo
                    else
                    {
                        pantallaRes.Text = (controlador1.Resultado(float.Parse(pantallaRes.Text), float.Parse(controlador1.getUltimo()))).ToString();
                        controlador1.setUltimo("");
                    }
                    pantalla.Text = pantalla.Text + operacion;
                    controlador1.setOperacion(id);
                }
                //Si el ultimo caracter es un "=" y la pantalla de resultado NO está vacia, coloca el resultado arriba para seguir operando
                else if (ultimo == 61 && pantallaRes.TextLength != 0)
                {
                    pantalla.Text = pantallaRes.Text + operacion;
                    controlador1.setOperacion(id);
                    controlador1.setUltimo("");
                }
            }
            //Control de excepciones en caso de que el usuario coloque un "operador" estando el campo vacio
            catch (IndexOutOfRangeException)
            {
                //Si la pantalla esta en blanco y se presiona un operador, si es distinto a 2, no coloca nada
                if(id != 2)
                {
                    pantalla.Text = "";
                }
                //Si el operador es 2 (operacion de restar), coloca un "-"
                else
                {
                    pantalla.Text = "-";
                }
                
            }

        }*/

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
            pantalla.Text = pantalla.Text + "(";

        }
        private void btnParent2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ")";
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            /*
            if (pantalla.TextLength != 0)
            {
                int ultimo = pantalla.Text[pantalla.Text.Length - 1];
                if(!contieneDecimal(controlador1.getUltimo()) && ultimo != 41)
                {
                    pantalla.Text = pantalla.Text+",";
                    controlador1.addUltimo(",");
                }else if(ultimo == 61)
                {
                    pantalla.Text = ",";
                    pantallaRes.Text = "";
                    controlador1.setUltimo("");
                }
            }
            else
            {
                pantalla.Text = ",";
                controlador1.addUltimo(",");
            }
            */
                
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
           // operacion("/", 4);
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            //operacion("x", 3);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //operacion("-", 2);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //operacion("+", 1);
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
