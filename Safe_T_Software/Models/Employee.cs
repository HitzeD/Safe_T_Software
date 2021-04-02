using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_T_Software.Models
{
    public class Employee
    {
        private long empID;
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        private int injuryCount;
        private DateTime lastIncident;

        private List<Injury> injuries;

        /// <summary>
        /// Create Employee with First and Last Name
        /// </summary>
        /// <param name="fName">String-type data for employee's first name</param>
        /// <param name="lname">String-type data for employee's last name</param>
        public Employee(long id, string fName, string lname, List<Injury> passedInjuries = null)
        {
            empID = id;
            EmpFirstName = fName;
            EmpLastName = lname;
            injuries = passedInjuries == null ? new List<Injury>() : passedInjuries;
            injuryCount = injuries.Count;
        }

        public List<Injury> GetInjuries()
        {
            return this.injuries;
        }

        /// <summary>
        /// Update Employee injury list as well as increment the count
        /// </summary>
        /// <param name="newIncident">Data Type Injury to be added to the Employee's List</param>
        /// <returns>List containing the new injury</returns>
        public List<Injury> AddInjury(Injury newIncident)
        {
            injuries.Add(newIncident);
            injuryCount = injuries.Count;
            lastIncident = DateTime.Now;

            return injuries;
        }

        public int GetInjuryCount()
        {
            return injuryCount;
        }

        public override string ToString()
        {
            return $"\n{EmpFirstName} {EmpLastName}\nInjury Count: {injuryCount}\nLast Incident: {lastIncident}\n";
        }
    }
}
