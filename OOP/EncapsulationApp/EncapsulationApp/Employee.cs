using System;

namespace EncapsulationApp
{
    class Employee
    {
        private int age;
        private string name;

        public void SetAge(int sage)
        {
            if (sage >= 18 && sage <= 60)
            {
                age = sage;
            }
            else if(sage < 18)
            {
                age = 18;
            }
            else
            {
                age = 60;
            }
        }

        public int GetAge()
        {
            return age;
        }

        public void SetName(string sname)
        {
            name = sname;
        }

        public string GetName()
        {
            return name;
        }
    }
}
