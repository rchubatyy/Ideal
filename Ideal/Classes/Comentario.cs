using System;
using System.Collections.Generic;

namespace Ideal.Classes
{
    class Comentario
    {
        //Atributos
        private string _mensagem;
        private DateTime _data;
        private Conta _conta;
        

        //Construtor
        public Comentario(string mensagem, DateTime data, Conta conta)
        {
            _mensagem = mensagem;
            _data = data;
            _conta = conta;
        }

        //Metodos get/set
        public string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Conta Conta
        {
            get { return _conta; }
            set { _conta = value; }
        }
    }
}
