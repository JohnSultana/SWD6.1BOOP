using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class RandomNumbers
    {
        Random rnd = new Random();
        int num1;
        int num2;
        int userNum;

        public int UserNum { get => userNum; set => userNum = value; }

        public void GenerateNumbers()
        {
            num1 = rnd.Next(1, 10);
            num2 = rnd.Next(1, 10);
        }

        public int GetNumber1()
        {
            return num1;
        }

        public int GetNumber2()
        {
            return num2;
        }

        public int FindSum()
        {
            return num1 + num2;
        }

        public bool IsEqual()
        {
            if(UserNum == FindSum())
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
