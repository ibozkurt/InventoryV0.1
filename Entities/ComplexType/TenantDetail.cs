using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.ComplexType
{
    public class TenantDetail : IEntity
    {
        public int TenantId { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string LocationName { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string GsmNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string InternalPhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
