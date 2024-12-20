﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IService.IStudentService.Dto
{
    public class StudentSearchResultDto
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string HomeTown { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string ClassName { get; set; }
    }
}
