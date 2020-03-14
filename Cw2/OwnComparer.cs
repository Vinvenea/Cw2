using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
     class OwnComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer.InvariantCultureIgnoreCase.Equals($"{x.fName}{x.lName}{x.index}", $"{y.fName}{y.lName}{y.index}");
        }
        public int GetHashCode(Student obj)
        {
            return StringComparer
                .InvariantCultureIgnoreCase
                .GetHashCode($"{obj.fName}{obj.lName}{obj.index}");
        }
    }
}
