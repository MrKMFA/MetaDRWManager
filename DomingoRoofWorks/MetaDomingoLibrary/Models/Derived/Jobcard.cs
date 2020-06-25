//Author: Kenneth Arnesen
//Date Created: 2020/06/25
//Description:
//Last Updated: 2020/06/25

using MetaDomingoLibrary.Models.Base;
using System;
using System.Collections.Generic;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Jobcard : LookUp
    {
        // *** Private Fields ***
        private string jobcardId;
        private Employee createdBy;
        private Customer customer;
        private Jobtype jobtype;
        private DateTime jobStartDate;
        private DateTime jobEndDate;
        private List<JobcardItem> materials;
        private List<JobcardEmployee> employeesAssigned;

        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public Jobcard() : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.materials = new List<JobcardItem>();
            this.employeesAssigned = new List<JobcardEmployee>();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public Jobcard(Employee createdBy, Customer customer)
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.customer = customer;

            this.materials = new List<JobcardItem>();
            this.employeesAssigned = new List<JobcardEmployee>();
        }

        public Jobcard(Employee createdBy, Customer customer, Jobtype jobtype)
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.customer = customer;
            this.jobtype = jobtype;

            this.materials = new List<JobcardItem>();
            this.employeesAssigned = new List<JobcardEmployee>();
        }

        public Jobcard(Employee createdBy, Customer customer, Jobtype jobtype,
                        DateTime jobStart, DateTime jobEnd) 
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.customer = customer;
            this.jobtype = jobtype;
            this.jobStartDate = jobStart;
            this.jobEndDate = jobEnd;

            this.materials = new List<JobcardItem>();
            this.employeesAssigned = new List<JobcardEmployee>();
        }

        public Jobcard(Employee createdBy, Customer customer, Jobtype jobtype,
                        DateTime jobStart, DateTime jobEnd, List<JobcardItem> materials,
                        List<JobcardEmployee> employeesAssigned)
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.customer = customer;
            this.jobtype = jobtype;
            this.jobStartDate = jobStart;
            this.jobEndDate = jobEnd;

            this.materials = materials;
            this.employeesAssigned = employeesAssigned;
        }

        //-Used when initializing objects with values retrieved from database
        public Jobcard(string jobcardId, Employee createdBy, Customer customer, Jobtype jobtype,
                        DateTime jobStart, DateTime jobEnd, List<JobcardItem> materials,
                        List<JobcardEmployee> employeesAssigned, DateTime createdAt, DateTime modifiedAt)
            : base(createdAt, modifiedAt)
        {
            this.jobcardId = jobcardId;

            this.createdBy = createdBy;
            this.customer = customer;
            this.jobtype = jobtype;
            this.jobStartDate = jobStart;
            this.jobEndDate = jobEnd;

            this.materials = materials;
            this.employeesAssigned = employeesAssigned;
        }

        // *** Properties ***
        public string JobcardId
        {
            get
            {
                return this.jobcardId;
            }
        }

        public string CreatedById
        {
            get
            {
                return this.CreatedBy.EmployeeId;
            }
        }
        public Employee CreatedBy
        {
            get
            {
                return this.createdBy;
            }
            set
            {
                this.createdBy = value;
            }
        }

        public string CustomerId
        {
            get
            {
                return this.Customer.CustomerId;
            }
        }
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public string JobtypeId
        {
            get
            {
                return this.Jobtype.JobtypeId;
            }
        }
        public Jobtype Jobtype
        {
            get
            {
                return this.jobtype;
            }
            set
            {
                this.jobtype = value;
            }
        }

        public int JobDuration
        {
            get
            {
                return JobEndDate.Subtract(JobStartDate).Days;
            }
        }
        public DateTime JobStartDate
        {
            get
            {
                return this.jobStartDate;
            }
            set
            {
                this.jobStartDate = value;
            }
        }
        public DateTime JobEndDate
        {
            get
            {
                return this.jobEndDate;
            }
            set
            {
                this.jobEndDate = value;
            }
        }

        public List<JobcardItem> Materials
        {
            get
            {
                return this.materials;
            }
            set
            {
                this.materials = value;
            }
        }
        public List<JobcardEmployee> EmployeesAssigned
        {
            get
            {
                return this.employeesAssigned;
            }
            set
            {
                this.employeesAssigned = value;
            }
        }

        public override string ToString()
        {
            return "JobcardId: " + JobcardId + "\n" +
                    "CreatedById: " + CreatedById + "\n" +
                    "CreatedByName: " + CreatedBy.FirstName + "\n" +
                    "CustomerId: " + CustomerId + "\n" +
                    "CustomerFullName: " + Customer.FirstName + " " + Customer.LastName + "\n" +
                    "JobtypeId: " + JobtypeId + "\n" +
                    "JobtypeName: " + Jobtype.JobtypeName + "\n" +
                    "JobDuration: " + JobDuration + "\n" +
                    "JobStartDate: " + JobStartDate.ToString() + "\n" +
                    "JobEndDate: " + JobEndDate.ToString() + "\n" +
                    "Number of Materials: " + Materials.Count + "\n" +
                    "Number of Assigned Employees: " + EmployeesAssigned.Count + "\n" +
                    base.ToString();
        }
    }
}
