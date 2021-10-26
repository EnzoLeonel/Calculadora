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
        private List<float> sumas = new List<float>();

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

    }
}
