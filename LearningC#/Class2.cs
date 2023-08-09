using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
    public class MySteps
    {
        public void Steps(int n)
    {
        for (int i = 0; i < n; i++)
        {
            string step = "";
            for (int j = 0; j < n; j++)
            {
                if (j <= i)
                {
                    step += "#";
                }
                else
                {
                    step += " ";
                }
            }
            Console.WriteLine(step);
        }
    }
}
}
