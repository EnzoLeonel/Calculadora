using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Modelo
    {
        //Guarda temporalmente el ultimo numero que se coloca
        private string ultimoNumero = "";
        //Guarda temporalmente una operacion pendiente entre binomios
        private int operacion = 0;
        private float binomio = 0;
        private bool parentesisAB = false;
        private List<float> sumas = new List<float>();

        //Lista para guardar parentesis como si fueran cuentas(modelos) individuales separados
        //del resto de la cuenta
        private List<Modelo> subModelos = new List<Modelo>();

        public void setParentesisAB()
        {
            this.parentesisAB = true;
        }
        public bool esParentesis()
        {
            return parentesisAB;
        }
        public void setUltimoNumero(string ultimoNum)
        {
            this.ultimoNumero = ultimoNum;
        }
        public void addUltimoNumero(string ultimoNum)
        {
            this.ultimoNumero = this.ultimoNumero + ultimoNum;
        }
        public string getUltimoNumero()
        {
            return this.ultimoNumero;
        }
        public void addTermino(float termino)
        {
            sumas.Add(termino);
        }
        public List<float> getSumas()
        {
            return sumas;
        }
        public void setSumas(List<float> sumas)
        {
            this.sumas = sumas;
        }
        public void setSubModelos(List<Modelo> subModelos)
        {
            this.subModelos = subModelos;
        }
        public List<Modelo> getSubModelos()
        {
            return subModelos;
        }
        public void setOperacion(int operacion)
        {
            this.operacion = operacion;
        }
        public int getOperacion()
        {
            return this.operacion;
        }
        public void setBinomio(float numero)
        {
            this.binomio = numero;
        }
        public float getBinomio()
        {
            return this.binomio;
        }
        public void addSubModelo(Modelo modelo)
        {
            subModelos.Add(modelo);
        }

    }
}
