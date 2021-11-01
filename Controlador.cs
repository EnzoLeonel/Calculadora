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
        public Controlador(Vista vista, Modelo modelo)
        {
            this.vista = vista;
            this.modelo = modelo;
        }
        public int ultimoCaracter()
        {
            int ultimo = 0;
            try
            {
                ultimo = vista.pantalla.Text[vista.pantalla.TextLength - 1];
            }
            catch (IndexOutOfRangeException) { }
            return ultimo;
        }
        public bool pantallaVacia()
        {
            bool vacia = false;
            if (vista.pantalla.TextLength == 0)
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
            if (ultimo >= 48 && ultimo <= 57)
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
        public void colocarParentesisAB()
        {
            int ultimo = ultimoCaracter();
            if(!ultimoEsNumero() && ultimo != 44 && ultimo != 41)
            {
                switch (ultimo)
                {
                    case 45:
                        modelo.setBinomio(-1f);
                        modelo.setUltimoNumero("");
                        modelo.setOperacion(1);
                        nuevoModelo();
                        vista.pantalla.Text = vista.pantalla.Text + "(";
                        break;
                    default:
                        nuevoModelo();
                        vista.pantalla.Text = vista.pantalla.Text + "(";
                        break;
                }
            }
        }
        public void colocarParentesisCE()
        {
            if ((ultimoEsNumero() || ultimoCaracter() == 41) && modelo.esParentesis())
            {
                float resultado = 0;
                switch (modelo.getOperacion())
                {
                    case 0:
                        modelo.addTermino(float.Parse(modelo.getUltimoNumero()));
                        resultado = resultadoParcial();
                        modelo = modelo.getSubModelos().Last();
                        modelo.setUltimoNumero(resultado.ToString());
                        vista.pantalla.Text = vista.pantalla.Text + ")";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;
                }
            }
        }
        public void borrarTodo()
        {
            vista.pantalla.Text = "";
            vista.pantallaRes.Text = "";
            modelo.setUltimoNumero("");
            modelo.setSumas(new List<float>());
            modelo.setSubModelos(new List<Modelo>());
            modelo.setBinomio(0);
            modelo.setOperacion(0);
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
                        modelo.addUltimoNumero(numero);
                        break;

                    //En caso de ser 0, COLOCAR EN UNA FUNCION ESPECIAL, SIRVE PARA COLOCAR 0 SOLAMENTE SI EL NUMERO ES UN 0,00
                    case 48:
                        if (float.Parse(modelo.getUltimoNumero()) == 0 && !contieneDecimal(modelo.getUltimoNumero()))
                        {
                            vista.pantalla.Text = vista.pantalla.Text.Substring(0, vista.pantalla.Text.Length - 1) + numero;
                        }
                        else
                        {
                            vista.pantalla.Text = vista.pantalla.Text + numero;
                            modelo.addUltimoNumero(numero);
                        }
                        break;

                    //En el caso de una division, si se coloca un 0, muestra pantalla de error
                    case 47:
                        if (numero != "0")
                        {
                            vista.pantalla.Text = vista.pantalla.Text + numero;
                            modelo.addUltimoNumero(numero);
                        }
                        else
                        {
                            borrarTodo();
                            vista.pantalla.Text = "No se puede dividir entre cero=";
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
        public void suma()
        {
            int ultimo = ultimoCaracter();
            //Si el ultimo es un numero o es un ")"
            if (ultimoEsNumero() || ultimo == 41)
            {
                float resultado;
                switch (modelo.getOperacion())
                {
                    case 0:
                        //Guarda el ultimo numero escrito en un nuevo termino
                        modelo.addTermino(float.Parse(modelo.getUltimoNumero()));
                        modelo.setUltimoNumero("");
                        vista.pantalla.Text = vista.pantalla.Text + "+";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 1:
                        //Existe una operacion de multiplicar pendiente
                        resultado = modelo.getBinomio() * float.Parse(modelo.getUltimoNumero());
                        modelo.addTermino(resultado);
                        modelo.setUltimoNumero("");
                        modelo.setOperacion(0);
                        vista.pantalla.Text = vista.pantalla.Text + "+";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 2:
                        //Existe una operacion de division pendiente
                        resultado = modelo.getBinomio() / float.Parse(modelo.getUltimoNumero());
                        modelo.addTermino(resultado);
                        modelo.setUltimoNumero("");
                        modelo.setOperacion(0);
                        vista.pantalla.Text = vista.pantalla.Text + "+";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;
                }
            }
        }
        public void resta()
        {
            int ultimo = ultimoCaracter();
            //Si el ultimo es un numero o es una coma o la pantalla NO esta vacia, y NO sea un "-"
            if (ultimo != 44 && ultimo != 0 && ultimo != 45 && ultimo != 61)
            {
                float resultado;
                switch (modelo.getOperacion())
                {
                    case 0:
                        //Guarda el ultimo numero escrito en un nuevo termino
                        modelo.addTermino(float.Parse(modelo.getUltimoNumero()));
                        modelo.setUltimoNumero("-");
                        vista.pantalla.Text = vista.pantalla.Text + "-";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 1:
                        //Existe una operacion de multiplicar pendiente
                        resultado = modelo.getBinomio() * float.Parse(modelo.getUltimoNumero());
                        modelo.addTermino(resultado);
                        modelo.setUltimoNumero("-");
                        modelo.setOperacion(0);
                        vista.pantalla.Text = vista.pantalla.Text + "-";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 2:
                        //Existe una operacion de division pendiente
                        resultado = modelo.getBinomio() / float.Parse(modelo.getUltimoNumero());
                        modelo.addTermino(resultado);
                        modelo.setUltimoNumero("-");
                        modelo.setOperacion(0);
                        vista.pantalla.Text = vista.pantalla.Text + "-";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;
                }
            }else if(ultimo == 0 || ultimo == 61)
            {
                borrarTodo();
                vista.pantalla.Text = "-";
                modelo.addUltimoNumero("-");
            }
        }
        public void multiplicacion()
        {
            int ultimo = ultimoCaracter();
            if (ultimoEsNumero() || ultimo == 41)
            {
                float resultado;
                switch (modelo.getOperacion())
                {
                    case 0:
                        //Guarda el ultimo numero escrito en el binomio para poder multiplicarlo
                        //con el siguiente que se escriba
                        modelo.setBinomio(float.Parse(modelo.getUltimoNumero()));
                        modelo.setUltimoNumero("");
                        // Operacion 1 = Multiplicar
                        modelo.setOperacion(1);
                        vista.pantalla.Text = vista.pantalla.Text + "x";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 1:
                        //Existe una operacion de multiplicar pendiente y se requiere realizar otra
                        resultado = modelo.getBinomio() * float.Parse(modelo.getUltimoNumero());
                        modelo.setBinomio(resultado);
                        modelo.setUltimoNumero("");
                        vista.pantalla.Text = vista.pantalla.Text + "x";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 2:
                        //Existe una operacion de dividir pendiente y se requiere realizar una multiplicacion
                        resultado = modelo.getBinomio() / float.Parse(modelo.getUltimoNumero());
                        modelo.setBinomio(resultado);
                        modelo.setUltimoNumero("");
                        modelo.setOperacion(1);
                        vista.pantalla.Text = vista.pantalla.Text + "x";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;
                }
            }
        }
        public void division()
        {
            int ultimo = ultimoCaracter();
            if (ultimoEsNumero() || ultimo == 41)
            {
                float resultado;
                switch (modelo.getOperacion())
                {
                    case 0:
                        //Guarda el ultimo numero escrito en el binomio para poder dividirlo
                        //con el siguiente que se escriba
                        modelo.setBinomio(float.Parse(modelo.getUltimoNumero()));
                        modelo.setUltimoNumero("");
                        // Operacion 2 = Dividir
                        modelo.setOperacion(2);
                        vista.pantalla.Text = vista.pantalla.Text + "/";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 1:
                        //Existe una operacion de multiplicar pendiente y se requiere realizar una division
                        resultado = modelo.getBinomio() * float.Parse(modelo.getUltimoNumero());
                        modelo.setBinomio(resultado);
                        modelo.setUltimoNumero("");
                        modelo.setOperacion(2);
                        vista.pantalla.Text = vista.pantalla.Text + "/";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;

                    case 2:
                        //Existe una operacion de dividir pendiente y se requiere realizar otra
                        resultado = modelo.getBinomio() / float.Parse(modelo.getUltimoNumero());
                        modelo.setBinomio(resultado);
                        modelo.setUltimoNumero("");
                        vista.pantalla.Text = vista.pantalla.Text + "/";
                        vista.pantallaRes.Text = resultadoParcial().ToString();
                        break;
                }
            }
        }
        public float resultadoParcial()
        {
            float resultado = 0;
            if (modelo.getSumas().Count() > 0)
            {
                
                foreach(float t in modelo.getSumas())
                {
                    resultado += t;
                }
            }
            return resultado;
        }
        public void nuevoModelo()
        {
            Modelo modeloTemp = new Modelo();
            modeloTemp.setParentesisAB();
            modeloTemp.addSubModelo(modelo);
            modelo = modeloTemp;
        }
    }
}
