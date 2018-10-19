using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ideal.Classes
{
    abstract class Conta
    {
        //Atributos
        private string _username;
        private string _password;
        private int _numeroVisitas;
        private DateTime _ultimeLogin;
        private string _tipo;
        private Perfil _perfil;
        private IList<Subscricao> _subscricaoLista;
        private IList<Ideia> _ideiaLista;
        private IList<Grupo> _grupoLista;
        private IList<Comentario> _comentarioLista;

        //Construtor
       public Conta(string username, string password, int numeroVisitas, DateTime ultimeLogin, string tipo, Perfil perfil, IList<Subscricao> subscricaoLista, IList<Ideia> ideiaLista, IList<Grupo> grupoLista, IList<Comentario> comentarioLista)
        {
            _username = username;
            _password = password;
            _numeroVisitas = numeroVisitas;
            _ultimeLogin = ultimeLogin;
            _tipo = tipo;
            _perfil = perfil;
            _subscricaoLista = subscricaoLista;
            _ideiaLista = ideiaLista;
            _grupoLista = grupoLista;
            _comentarioLista = comentarioLista;
        }

        protected Conta()
        {

        }


        //Metodos get/set
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int NumeroVisitas
        {
            get { return _numeroVisitas; }
            set { _numeroVisitas = value; }
        }

        public DateTime UltimeLogin
        {
            get { return _ultimeLogin; }
            set { _ultimeLogin = value; }
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Perfil Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        public IList<Subscricao> SubscricaoLista
        {
            get { return _subscricaoLista; }
            set { _subscricaoLista = value; }
        }

        public IList<Ideia> IdeiaLista
        {
            get { return _ideiaLista; }
            set { _ideiaLista = value; }
        }

        public IList<Grupo> GrupoLista
        {
            get { return _grupoLista; }
            set { _grupoLista = value; }
        }

        public IList<Comentario> ComentarioLista
        {
            get { return _comentarioLista; }
            set { _comentarioLista = value; }
        }
    }
}
