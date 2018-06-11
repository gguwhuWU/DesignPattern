using System;

namespace designPatterns.Prototype
{
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private int age;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex, int age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(DateTime workDate, string company)
        {
            this.work.WorkDate = workDate;
            this.work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"{work.WorkDate} {work.Company}");
        }

        /// <summary>
        /// deep copy
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
