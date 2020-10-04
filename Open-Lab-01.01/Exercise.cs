using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        { 
           int trap = int.Parse(input);
           if(trap < 10)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
