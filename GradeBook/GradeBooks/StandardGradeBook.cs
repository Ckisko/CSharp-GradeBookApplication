using GradeBook.Enums;
using GradeBook.GradeBooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    internal class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
