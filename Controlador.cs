using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Controlador
    {
        Vista vista;
        Modelo modelo;
        public Controlador() { }
        public Controlador(Vista vista,Modelo modelo)
        {
            this.vista = vista;
            this.modelo = modelo;
        }
        public int ultimoCaracter()
        {
            int ultimo = 0;
            ultimo = vista.pantalla.Text[vista.pantalla.TextLength - 1];
            return ultimo;
        }
        public bool pantallaVacia()
        {
            bool vacia = false;
            if(vista.pantalla.TextLength == 0)
            {
                vacia = true;
            }
            return vacia;
        }
        public bool pantallaResVacia()
        {
            bool vacia = false;
            if (vista.pantallaRes.TextLength == 0)
            {
                vacia = true;
            }
            return vacia;
        }
        
        //Funcion ultilizada para comprobar si un string contiene decimal, para evitar poner doble coma
        public bool contieneDecimal(String numero)
        {
            bool resultado = false;
            foreach (char s in numero)
            {
                if (s == ',')
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        public bool ultimoEsNumero()
        {
            bool numero = false;
            int ultimo = ultimoCaracter();
            if(ultimo >= 48 && ultimo <= 57)
            {
                numero = true;
            }
            return numero;
        }

        //Metodo para colocar "0" con algunas excepciones al resto de numeros
        public void colocarPunto()
        {
            if (!pantallaVacia())
            {
                int ultimo = ultimoCaracter();
                //Si el ultimo numero NO contiene decimal y no es un ")", coloca un punto
                if (!contieneDecimal(modelo.getUltimoNumero()) && ultimo != 41)
                {
                    vista.pantalla.Text = vista.pantalla.Text + ",";
                    modelo.addUltimoNumero(",");
                }
                //Sino si el ultimo es un "=", borra todo y coloca un punto
                else if (ultimo == 61)
                {
                    borrarTodo();
                    vista.pantalla.Text = ",";
                    modelo.addUltimoNumero(",");
                }
            }
            else
            {
                vista.pantalla.Text = ",";
                modelo.addUltimoNumero(",");
            }
        }
        public void borrarTodo()
        {
            vista.pantalla.Text = "";
            vista.pantallaRes.Text = "";
            modelo.setUltimoNumero("");
            modelo.setSumas(new List<float>());
        }
        public void colocarNumero(string numero)
        {
            //Si la pantalla NO esta vacia
            if (!pantallaVacia())
            {
                int ultimo = ultimoCaracter();
                //Verifica si el ultimo caracter es un "=" o un "0"
                switch (ultimo)
                {
                    case 61:
                        borrarTodo();
                        vista.pantalla.Text = numero;
                        modelo.addUltimoNumero("0");
                        break;

                    //En caso de ser 0, COLOCAR EN UNA FUNCION ESPECIAL, SIRVE PARA COLOCAR 0 SOLAMENTE SI EL NUMERO ES UN 0,00
                    case 48:
                        if (float.Parse(modelo.getUltimoNumero()) == 0 && !contieneDecimal(modelo.getUltimoNumero()))
                        {
                            vista.pantalla.Text = vista.pantalla.Text.Substring(0, vista.pantalla.Text.Length - 1)+numero;
                        }
                        else
                        {
                            vista.pantalla.Text = vista.pantalla.Text + numero;
                            modelo.addUltimoNumero(numero);
                        }
                        break;

                        //En el caso de una division, si se coloca un 0, muestra pantalla de error
                    case 47:
                        if(numero != "0")
                        {
                            vista.pantalla.Text = vista.pantalla.Text + numero;
                            modelo.addUltimoNumero(numero);
                        }
                        else
                        {
                            vista.pantalla.Text = "No se puede dividir entre cero=";
                            vista.pantallaRes.Text = "";
                            modelo.setUltimoNumero("");
                        }
                        break;
                    case 41:
                        break;

                    default:
                        vista.pantalla.Text = vista.pantalla.Text + numero;
                        modelo.addUltimoNumero(numero);
                        break;
                }
            }
            else
            {
                vista.pantalla.Text = numero;
                modelo.addUltimoNumero(numero);
            }
        }
    }
}
