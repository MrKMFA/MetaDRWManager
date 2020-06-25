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

        //-Used when instantiating default object (and base class) with initializing property values

        //-Used when initializing objects with values retrieved from database


        // *** Properties ***
    }
}
