using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Classes.Validacao
{
    interface IValidation
    {
        bool Validar(IList<string> obj);
    }
}
