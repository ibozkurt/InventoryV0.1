using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
