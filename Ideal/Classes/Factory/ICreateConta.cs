using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Classes.Factory
{
    interface ICreateConta
    {
        Conta CreateConta(string username, string password, int numeroVisitas, DateTime ultimeLogin, Perfil perfil, IList<Subscricao> subscricaoLista, IList<Ideia> ideiaLista, IList<Grupo> grupoLista, IList<Comentario> comentarioLista);
    }
}
