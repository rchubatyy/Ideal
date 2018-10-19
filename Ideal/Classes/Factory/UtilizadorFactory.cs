using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Classes.Factory
{
    class UtilizadorFactory : ICreateConta
    {
        public Conta CreateConta(string username, string password, int numeroVisitas, DateTime ultimeLogin, Perfil perfil,
            IList<Subscricao> subscricaoLista, IList<Ideia> ideiaLista, IList<Grupo> grupoLista, IList<Comentario> comentarioLista)
        {
            return new Utilizador()
            {
                Username = username,
                Password = password,
                NumeroVisitas = numeroVisitas,
                UltimeLogin = ultimeLogin,
                Perfil = perfil,
                SubscricaoLista = subscricaoLista,
                IdeiaLista = ideiaLista,
                GrupoLista = grupoLista,
                ComentarioLista = comentarioLista,
            };
        }

        public Conta CreateConta(string username, string password, int numeroVisitas, DateTime ultimeLogin, Perfil perfil)
        {
            return new Utilizador()
            {
                Username = username,
                Password = password,
                NumeroVisitas = numeroVisitas,
                UltimeLogin = ultimeLogin,
                Perfil = perfil,
                SubscricaoLista = new List<Subscricao>(),
                IdeiaLista = new List<Ideia>(),
                GrupoLista = new List<Grupo>(),
                ComentarioLista = new List<Comentario>(),
            };
        }
    }
}
