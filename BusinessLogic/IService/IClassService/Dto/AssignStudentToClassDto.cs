﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IService.IClassService.Dto
{
    public class AssignStudentToClassDto
    {
        public int ClassId { get; set; }
        public int StudentId { get; set; }
    }
}