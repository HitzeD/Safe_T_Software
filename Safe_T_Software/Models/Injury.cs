using System;
using Safe_T_Software.Enums;

namespace Safe_T_Software.Models
{
    public class Injury
    {
        private long InjuryID;
        private InjuryEnums injury;
        public string Description { get; set; }
        private DateTime dateOfInjury;
        private Employee employee;

        public Injury(long id, InjuryEnums typeOfInjury, string descript, DateTime date, Employee emp)
        {
            InjuryID = id;
            injury = typeOfInjury;
            Description = descript;
            dateOfInjury = date;
            employee = emp;
        }

        public InjuryEnums GetInjury()
        {
            return this.injury;
        }

        public override string ToString()
        {
            return $"{employee.EmpLastName}, {employee.EmpLastName} had an injury located on his/her {injury} on {dateOfInjury}. {employee.GetInjuryCount()} total injuries.";
        }


    }
}