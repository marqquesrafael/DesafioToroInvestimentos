using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Exceptions
{
    public class InsertEntityWithIdException : Exception
    {
        public InsertEntityWithIdException() : base("Erro ao inserir registro, Não é possível inserir um registro com Id pré definido"){ }
    }
}
