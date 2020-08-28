using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Tenant : IEntity
    {
        public int TenantId { get; set; }
        public int LocationId { get; set; }
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string GsmNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string InternalPhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
