using Cw2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cw2
{
    public class Student
    {
        [XmlAttribute(AttributeName = "student")]
        public String index { get; set; }
        [XmlElement(ElementName = "student")]
        public String fName { get; set; }
       
        public String lName { get; set; }

        public String birthdate { get; set; }

        public String email{get;set;}
        
        public String mothersName { get; set; }
       
        public String fathersName { get; set; }
       
        public Studies studies { get; set; }
        
     public Student()
        {

        }
        
        public Student(String fname, String lName, String studies, String modeOfStudies, String index, String birthdate, String email, String motherName, String fathersName)
        {
            this.fName = fname;
            this.lName = lName;
            this.studies = new Studies(studies, modeOfStudies);
            this.index = "s"+index;
            this.email = email;
            this.birthdate = birthdate;
            this.mothersName = motherName;
            this.fathersName = fathersName;
            
        }
        public override string ToString() {
            return fName+";"+lName+";"+studies.name+";"+studies.mode+";"+index+";"+email+";"+birthdate;

        }
        public bool IfStudent()
        {
            if(fName == "" || lName == "" || studies.name == ""||studies.mode == ""|| index == "" || email ==""||mothersName == ""||fathersName =="")
            {
                return true;
            }

            return false;
        }


    } 
}
 
