using GradeBook.Enums;
using GradeBook.GradeBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidCastException("Ranked-grading requires a minimum of 5 students to work");
                
            }

            var threshold = (int)Math.Ceiling (20 / 100 * Students.Count);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (grades[threshold - 1] <= averageGrade)
                return 'A';
            else if (grades[(threshold * 2) - 1] <= averageGrade)
            {
                return 'B';
            
            }
            else if (grades[(threshold * 3) - 1] <= averageGrade)
            {
                return 'C';

            }
            else if (grades[(threshold * 4) - 1] <= averageGrade)
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
