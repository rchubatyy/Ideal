using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Classes.Factory
{
    class AdministratorFactory : ICreateConta
    {
        public Conta CreateConta(string username, string password, int numeroVisitas, DateTime ultimeLogin, Perfil perfil,
            IList<Subscricao> subscricaoLista, IList<Ideia> ideiaLista, IList<Grupo> grupoLista, IList<Comentario> comentarioLista)
        {
            return new Administrator()
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
    }
}
