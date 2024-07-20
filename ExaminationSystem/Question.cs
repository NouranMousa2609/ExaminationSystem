using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{

   abstract class Question
   {

       public string? QuestionHeader { get; set; }

       public string? QuestionBody { get; set; }

       public Double Mark { get; set; }


       protected Question()
       {

       }
       protected Question(string questionHeader, string questionBody, double mark)
       {
           QuestionHeader = questionHeader;
           QuestionBody = questionBody;
           Mark = mark;

       }
   }
 
}
