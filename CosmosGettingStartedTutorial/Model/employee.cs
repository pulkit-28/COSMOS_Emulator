using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosGettingStartedTutorial.Model
{
   /// <summary>
   /// this model is for creating employee
   /// </summary>
    public class employee
    {
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public Guid id { get; set; }
        public int CompanyNumber { get; set; }
    }
}
