using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Controlador
    {
        Vista vista;
        Modelo modelo;
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

        public void colocarNumero(string numero)
        {
            //Si la pantalla NO esta vacia
            if (!pantallaVacia())
            {
                //Verifica si el ultimo caracter es un "=" o un "0"
                switch (ultimoCaracter())
                {
                    case 61:
                        vista.pantalla.Text = "";
                        vista.pantallaRes.Text = "";
                        modelo.setUltimoNumero("");
                        break;

                    //En caso de ser 0, COLOCAR EN UNA FUNCION ESPECIAL, SIRVE PARA COLOCAR 0 SOLAMENTE SI EL NUMERO ES UN 0,00
                    /*
                    case 48:
                        if (float.Parse(modelo.getUltimoNumero()) == 0 && !contieneDecimal(modelo.getUltimoNumero()))
                        {
                            vista.pantalla.Text = vista.pantalla.Text.Substring(0, vista.pantalla.Text.Length - 1);
                        }
                        break;
                    */
                }
            }
        }
    }
}
