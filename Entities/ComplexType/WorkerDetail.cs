﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.ComplexType
{
    public class WorkerDetail : IEntity
    {
        public int WorkerId { get; set; }
        public int LocationId { get; set; }
        public int DepartmentId { get; set; }
        public string LocationName { get; set; }
        public string DepartmentName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string GsmNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string InternalPhoneNumber { get; set; }
    }
}
