//Author: Kenneth Arnesen
//Date Created: 2020/06/25
//Description:
//Last Updated: 2020/06/25

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class JobcardItem : LookUp
    {
        // *** Private Fields ***
        private string jobcardItemId;
        private string jobcardId;
        private Item item;
        private int quantity;

        // *** Constructors ***
        //-Used when instantiating default object and included base class
        //-Used when instantiating default object (and base class) with initializing property values
        public JobcardItem(string jobcardId, Item item, int quantity) : base()
        {
            this.jobcardItemId = "JTM" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.jobcardId = jobcardId;
            this.item = item;
            this.quantity = quantity;
        }

        //-Used when initializing objects with values retrieved from database
        public JobcardItem(string jobcardItemId, string jobcardId, Item item,
                            int quantity, DateTime createdAt, DateTime modifiedDate)
            : base(createdAt, modifiedDate)
        {
            this.jobcardItemId = jobcardItemId;
            this.jobcardId = jobcardId;
            this.item = item;
            this.quantity = quantity;
        }

        // *** Properties ***
        public string JobcardItemId
        {
            get
            {
                return this.jobcardItemId;
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

        public string ItemId
        {
            get
            {
                return this.Item.ItemId;
            }
        }
        public Item Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
    }
}
