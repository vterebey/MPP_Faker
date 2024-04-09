using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MPP_2.Exceptions
{
    public class CyclicDependenceException : Exception
    {
        public CyclicDependenceException(HashSet<Type> usedtypes, Type errorType) : base(ConstructErrorMessage(usedtypes, errorType)) { }

        private static string ConstructErrorMessage(HashSet<Type> usedtypes, Type errorType)
        {
            string exc = "Cycle detected: ";
            if (usedtypes != null)
            {
                foreach (Type type in usedtypes)
                {
                    if (type != null) exc += $"{type.FullName} -> ";
                }
            }
            if (errorType != null)  exc += errorType.FullName;
            return exc;
        }
    }
}
