using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_2.Exceptions
{
    public class NoPublicConstructorException : Exception
    {
        public NoPublicConstructorException(Type classType) : base($"{classType.FullName} do not have any public constructor"){ }
    }
}
