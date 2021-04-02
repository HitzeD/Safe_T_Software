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
        private string empFirstName;
        private string empLastName;
        private int injuryCount;

        private List<Injury> injuries;

        /// <summary>
        /// Create Employee with First and Last Name
        /// </summary>
        /// <param name="fName">String-type data for employee's first name</param>
        /// <param name="lname">String-type data for employee's last name</param>
        public Employee(string fName, string lname)
        {
            empFirstName = fName;
            empLastName = lname;
        }

        /// <summary>
        ///     Empty Constructor
        /// </summary>
        public Employee()
        {

        }


    }
}
