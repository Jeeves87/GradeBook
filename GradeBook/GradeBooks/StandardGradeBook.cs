﻿using System;
using System.Collections.Generic;
using System.Text;
using static GradeBook.Enums.BookType;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        
        public StandardGradeBook(string name) : base(name)
        {
             Type = GradeBookType.Standard;
    } 

    }
    
    
    

}
    