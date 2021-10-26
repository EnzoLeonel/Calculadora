using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Modelo
    {
        //Guarda temporalmente el ultimo numero que se coloca
        private string ultimoNumero = "";

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

    }
}
