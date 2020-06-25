//Author: Kenneth Arnesen
//Date Created: 2020/06/25
//Description:
//Last Updated: 2020/06/25

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class JobcardEmployee : LookUp
    {
        // *** Private Fields ***
        private string jobcardEmployeeId;
        private string jobcardId;
        private Employee employee;
        private DateTime assignedStartDate;
        private DateTime assignedEndDate;

        // *** Constructors ***
        //-Used when instantiating default object and included base class
        //-Used when instantiating default object (and base class) with initializing property values
        public JobcardEmployee(string jobcardId, Employee employee) : base()
        {
            this.jobcardEmployeeId = "JEM" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.jobcardId = jobcardId;
            this.employee = employee;
        }

        public JobcardEmployee(string jobcardId, Employee employee, DateTime assignedStart,
                               DateTime assignedEnd): base()
        {
            this.jobcardEmployeeId = "JEM" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.jobcardId = jobcardId;
            this.employee = employee;
            this.assignedStartDate = assignedStart;
            this.assignedEndDate = assignedEnd;
        }

        //-Used when initializing objects with values retrieved from database
        public JobcardEmployee(string jobcardEmployeeId, string jobcardId, Employee employee,
                               DateTime assignedStart, DateTime assignedEnd, DateTime createdAt,
                               DateTime modifiedDate) 
            : base(createdAt, modifiedDate)
        {
            this.jobcardEmployeeId = jobcardEmployeeId;
            this.jobcardId = jobcardId;
            this.employee = employee;
            this.assignedStartDate = assignedStart;
            this.assignedEndDate = assignedEnd;
        }

        // *** Properties ***
        public string JobcardEmployeeId
        {
            get
            {
                return this.jobcardEmployeeId;
            }
        }

        public string JobcardId
        {
            get
            {
                return this.jobcardId;
            }
            set
            {
                this.jobcardId = value;
            }
        }

        public string EmployeeId
        {
            get
            {
                return this.Employee.EmployeeId;
            }
        }
        public Employee Employee
        {
            get
            {
                return this.employee;
            }
            set
            {
                this.employee = value;
            }
        }

        public DateTime AssignedStartDate
        {
            get
            {
                return this.assignedStartDate;
            }
            set
            {
                this.assignedStartDate = value;
            }
        }

        public DateTime AssignedEndDate
        {
            get
            {
                return this.assignedEndDate;
            }
            set
            {
                this.assignedEndDate = value;
            }
        }
    }
}
