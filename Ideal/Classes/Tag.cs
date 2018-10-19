using System;
using System.Collections.Generic;

namespace Ideal.Classes
{
    class Tag
    {
        //Atributos
        private string _nome;
        private DateTime _data;
        //private IList<Ideia> _ideiaLista;

        //Construtor
        public Tag(string nome, DateTime data)
        {
            _nome = nome;
            _data = data;
        }

        //Metedos set/get
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
