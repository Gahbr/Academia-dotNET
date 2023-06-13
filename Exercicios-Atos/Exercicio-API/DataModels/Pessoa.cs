using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exercicio_API.DataModels
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }    
        public string email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Email>? Emails{  get; set; }

    }
}
