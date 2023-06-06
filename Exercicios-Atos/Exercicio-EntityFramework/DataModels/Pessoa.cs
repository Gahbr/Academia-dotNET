using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_EntityFramework.DataModels
{
    internal class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }    
        public string email { get; set; }
        public virtual ICollection<Email> Emails{  get; set; }

    }
}
