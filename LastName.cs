
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseRegProblem
{
    internal class LastName
    {
        /// <summary>
        /// The regex last name
        /// UC2-sri
        /// </summary>
        public static String Regex_LastName = "^[A-Z]{1}[a-z]{3,}$";


        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
    }
}

    

