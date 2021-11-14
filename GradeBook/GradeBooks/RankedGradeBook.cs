using System;
using System.Collections.Generic;
using System.Text;
using static GradeBook.Enums.BookType;
using System.Linq;
using System.Text.RegularExpressions;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        
        public RankedGradeBook(string name, bool IsWeighted) : base(name, IsWeighted)
        {
            Type = GradeBookType.Ranked;            
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {

            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else if (Students.Count > 5)
            {
                base.CalculateStudentStatistics(name);
            }


        }



        public override char GetLetterGrade(double averageGrade)
        {
            var SortedByGrade = Students.OrderByDescending(o => o.AverageGrade).ToList();
            int curveForClass = (int)Math.Round(Students.Count * .2);
            if (averageGrade >= SortedByGrade[curveForClass - 1].AverageGrade)
            {
                return 'A';
            }
            else if (averageGrade >= SortedByGrade[curveForClass * 2 - 1].AverageGrade)
            {
                return 'B';
            }
            else if (averageGrade >= SortedByGrade[curveForClass * 3 - 1].AverageGrade)
            {
                return 'C';
            }
            else if (averageGrade >= SortedByGrade[curveForClass * 4 - 1].AverageGrade)
            {
                return 'D';
            }
            else 
            {
                return 'F';
            }


        }

        
            

    }

}

    
 

