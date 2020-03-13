using Cw2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    class Student
    {
     public String fName { get; set; }
     public String lName { get; set; }
     public  String studies;
     public   String modeofStudies;
     public  String index { get; set; }
     public DateTime birthdate;
     public String email;
     public  String mothersName;
     public String fathersName;
        
        public Student(String fname, String lName, String studies, String modeOfStudies, String index, String birthdate, String email, String motherName, String fathersName)
        {
            this.fName = fname;
            this.lName = lName;
            this.studies = studies;
            this.modeofStudies = modeOfStudies;
            this.index = index;
            this.email = email;
            this.birthdate = DateTime.Parse(birthdate);
            
        }
        public override string ToString() {
            return fName+";"+lName+";"+studies+";"+modeofStudies+";"+index+";"+email+";"+birthdate.ToShortDateString();

        }
        public bool IfStudent()
        {
            if(fName == "" || lName == "" || studies == ""||modeofStudies == ""|| index == "" || email ==""||mothersName == ""||fathersName =="")
            {
                return true;
            }

            return false;
        }


    } 
}
 class OwnComparer : IEqualityComparer<Student> {
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
