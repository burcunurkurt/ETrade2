using Abc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class Employee:IEntity
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


    }
}
