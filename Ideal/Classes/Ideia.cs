using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ideal.Classes.Factory;

namespace Ideal.Classes
{
    class Ideia
    {
        //Atributos
        private string _titulo;
        private string _mensagem;
        private string _estado;
        private DateTime _data;
        private Conta _conta;
        private Tag _tag;
        private Categoria _categoria;
        private IList<Rating> _ratingLista;
        private IList<Comentario> _comentarioLista;
            

        //Construtor
        public Ideia(string titulo, string mensagem, string estado, DateTime data, Conta conta, Tag tag, Categoria categoria, IList<Rating> ratingLista, IList<Comentario> comentarioLista)
        {
            _titulo = titulo;
            _mensagem = mensagem;
            _estado = estado;
            _data = data;
            _conta = conta;
            _tag = tag;
            _categoria = categoria;
            _ratingLista = ratingLista;
            _comentarioLista = comentarioLista;
        }

        //Metodos get/set
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Conta Conta1
        {
            get { return _conta; }
            set { _conta = value; }
        }

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public Tag Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        public IList<Comentario> ComentarioLista
        {
            get { return _comentarioLista; }
            set { _comentarioLista = value; }
        }

        public IList<Rating> RatingLista
        {
            get { return _ratingLista; }
            set { _ratingLista = value; }
        }

        public override string ToString()
        {
            return "Título: " + Titulo;
        }
    }
}
