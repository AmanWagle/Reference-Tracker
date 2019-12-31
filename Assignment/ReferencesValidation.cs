using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ReferencesValidation
    {
        public bool checkEmpty(string[] para)
        {
            for(int index = 0; index < para.Length; index++)
            {
                para[index] = para[index].Trim();
                if (string.IsNullOrEmpty(para[index]))
                    return false;
            }
            return true;
        }
        public bool yearValid(string year)
        {
            if (year.Length == 4)
            {
                foreach (char c in year)
                {
                    if (!char.IsNumber(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool numberValid(string str)
        {
            foreach (char c in str)
            {
                if (char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
