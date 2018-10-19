using System;

namespace Ideal.Classes
{
    class Perfil
    {
        //Atributos
        private string _email;
        private string _primeiroNome;
        private string _ultimoNome;
        private DateTime _dataNascimento;
   
        //Construtor
        public Perfil(string primeiroNome, string ultimoNome, string email, DateTime dataNascimento)
        {
            _primeiroNome = primeiroNome;
            _ultimoNome = ultimoNome;
            _email = email;
            _dataNascimento = dataNascimento;
        }

        //Metodos get/set
        public string PrimeiroNome
        {
            get { return _primeiroNome; }
            set { _primeiroNome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string UltimoNome
        {
            get { return _ultimoNome; }
            set { _ultimoNome = value; }
        }

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

    }
}
