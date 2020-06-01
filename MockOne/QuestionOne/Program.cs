using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Linq;

namespace QuestionOne
{
    public class Program
    {
        static void Main(string[] args)
        {

         }


      
            public static string ManyTimes(string s, int i)
        {

            StringBuilder sb = new StringBuilder(s.Length * i);
             for(int j = 1; j<i; j++) 
            
               sb.Append(s); 
          
            return sb.ToString();

        }
    }
}
