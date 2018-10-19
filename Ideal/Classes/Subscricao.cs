using System;
using System.Windows.Forms;

namespace Ideal.Classes
{
    class Subscricao
    {
        //Atributos
        private DateTime _data;
        private Conta _conta;
        private Ideia _ideia;

        //Construtor
        public Subscricao(DateTime data, Conta conta, Ideia ideia)
        {
            _data = data;
            _conta = conta;
            _ideia = ideia;
        }

        //Metodos get/set
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

        public Ideia Ideia
        {
            get { return _ideia; }
            set { _ideia = value; }
        }

        public override string ToString()
        {
            return "Ideia Criada por: " + Ideia.Conta1.Username + "\n\n"
                   + "Mensagem: " + Ideia.Mensagem;
        }
    }
}
