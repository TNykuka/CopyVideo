using System;

namespace _2_Properties
{
    public class Person
    {
        public String Name { get; set; }
        public String Username { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get

            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }

        }
    }
}
