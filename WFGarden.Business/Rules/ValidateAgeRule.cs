using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGarden.Data;

namespace WFGarden.Business.Rules
{
    public static class ValidateAgeRule
    {
        public static bool IsSatisfied(Employee employee)
        {
            return true;
        }
    }
}
