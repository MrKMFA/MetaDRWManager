//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using System;

namespace MetaDomingoLibrary.Models.Base
{
    public abstract class LookUp
    {
        // *** Private Fields ***
        private DateTime createdAt;
        private DateTime modifiedDate;


        //-----------------------------
        // !!! NB: Abstract Class !!!
        //-----------------------------
        // *** Constructors ***
        //-Used when creating default object
        public LookUp()
        {
            this.createdAt = DateTime.UtcNow;
            this.modifiedDate = DateTime.UtcNow;
        }

        //-Used when creating object with values retrieved from database
        public LookUp(DateTime created, DateTime modified)
        {
            this.createdAt = created;
            this.modifiedDate = modified;
        }



        // *** Properties ***
        public DateTime CreatedAt
        {
            get
            {
                return this.createdAt;
            }
        }

        public DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDate;
            }
            set
            {
                this.modifiedDate = value;
            }
        }

        // *** Methods ***
        public override string ToString()
        {
            return "CreatedAt: " + CreatedAt + "\n" +
                    "ModifiedDate: " + ModifiedDate;
        }
    }
}
