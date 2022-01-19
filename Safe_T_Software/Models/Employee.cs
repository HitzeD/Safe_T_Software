using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_T_Software.Models
{
    class Employee
    {
    // Employee information

        private Guid EmpID { get; set; }
        private string FName { get; set; }
        private string LName { get; set; }
        private string Username { get; set; }
        private byte[] Password { get; set; }
    
    // Work Information
        private DutyTitle Title { get; set; }
        private DateTime DateofHire { get; set; }

    // Incident History
        private List<Incident> incidents { get; set; }
        
    // Constructors
        public Employee(string user, string pass)
        {
            EmpID = Guid.NewGuid();

        }

    // Methods
        public void SetPassword(string pass)
        {
            Password = PasswordHashing.CreateHash(pass);
        }
    }
}
