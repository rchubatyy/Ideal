using System.Collections.Generic;

namespace Ideal.Classes
{
    class Grupo
    {
        //Atributos
        private string _nome;
        private string _dono;
        private IList<Conta> _contaLista;
        private IList<Ideia> _ideaLista;

        //Construtor
        public Grupo(string nome, string dono, IList<Conta> contaLista, IList<Ideia> ideaLista)
        {
            _nome = nome;
            _dono = dono;
            _contaLista = contaLista;
            _ideaLista = ideaLista;
        }

        //Metodos get/set
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Dono
        {
            get { return _dono; }
            set { _dono = value; }
        }

        public IList<Conta> ContaLista
        {
            get { return _contaLista; }
            set { _contaLista = value; }
        }

        public IList<Ideia> IdeaLista
        {
            get { return _ideaLista; }
            set { _ideaLista = value; }
        }
    }
}
