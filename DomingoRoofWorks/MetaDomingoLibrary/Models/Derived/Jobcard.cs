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
        private Customer client;
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
        public Jobcard(Employee createdBy, Customer client)
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.client = client;

            this.materials = new List<JobcardItem>();
            this.employeesAssigned = new List<JobcardEmployee>();
        }

        public Jobcard(Employee createdBy, Customer client, Jobtype jobtype)
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.client = client;
            this.jobtype = jobtype;

            this.materials = new List<JobcardItem>();
            this.employeesAssigned = new List<JobcardEmployee>();
        }

        public Jobcard(Employee createdBy, Customer client, Jobtype jobtype,
                        DateTime jobStart, DateTime jobEnd) 
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.client = client;
            this.jobtype = jobtype;
            this.jobStartDate = jobStart;
            this.jobEndDate = jobEnd;

            this.materials = new List<JobcardItem>();
            this.employeesAssigned = new List<JobcardEmployee>();
        }

        public Jobcard(Employee createdBy, Customer client, Jobtype jobtype,
                        DateTime jobStart, DateTime jobEnd, List<JobcardItem> materials,
                        List<JobcardEmployee> employeesAssigned)
            : base()
        {
            this.jobcardId = "JCD" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.createdBy = createdBy;
            this.client = client;
            this.jobtype = jobtype;
            this.jobStartDate = jobStart;
            this.jobEndDate = jobEnd;

            this.materials = materials;
            this.employeesAssigned = employeesAssigned;
        }

        //-Used when initializing objects with values retrieved from database
        public Jobcard(string jobcardId, Employee createdBy, Customer client, Jobtype jobtype,
                        DateTime jobStart, DateTime jobEnd, List<JobcardItem> materials,
                        List<JobcardEmployee> employeesAssigned, DateTime createdAt, DateTime modifiedAt)
            : base(createdAt, modifiedAt)
        {
            this.jobcardId = jobcardId;

            this.createdBy = createdBy;
            this.client = client;
            this.jobtype = jobtype;
            this.jobStartDate = jobStart;
            this.jobEndDate = jobEnd;

            this.materials = materials;
            this.employeesAssigned = employeesAssigned;
        }

        // *** Properties ***
    }
}
