using System;

namespace designPatterns.Prototype
{
    public class WorkExperience : ICloneable
    {
        private DateTime workDate;
        public DateTime WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }

        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        /// <summary>
        /// shallow copy
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
