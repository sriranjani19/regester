﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseRegProblem
{
    internal class PassWordRule2
    {
        /// <summary>
        /// The regex pattern
        /// UC6-sri.
        /// </summary>
        public static string Regex_Pattern = "^[A-Z a-z]{8,}$";
        public bool validatePasswordRule2(string passwordrule2)
        {
            return Regex.IsMatch(passwordrule2, Regex_Pattern);
        }
    }
}

    

