using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedule.Business
{
    public static class Validations
    {
        public static string ValidateFile(string inputFile)
        {
            string result = "";
            if (!File.Exists(inputFile))
            {
                result = "File does not exist";
            }
            else
            {
                if (Path.GetExtension(inputFile).ToLower() != ".txt")
                {
                    result = "The file must be a .txt";
                }
            }
            return result;
        }
        

    }
}
