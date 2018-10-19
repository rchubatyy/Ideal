using System;

namespace Ideal.Classes
{
    class Rating
    {
        //Atributos
        private int _valor;
        private DateTime _data;

        //Construtor
        public Rating(int valor, DateTime data)
        {
            _valor = valor;
            _data = data;
        }

        //Metodos set/get
        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
