﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        [Required(ErrorMessage = "Student is Required.")]
        [DisplayName("Student Name")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Course is Required.")]
        [DisplayName("Course Name")]
        public int CourseId { get; set; }


        [Required(ErrorMessage = "Start Date is Required.")]
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "End Date is Required.")]
        [DataType(DataType.Date)]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        //Liên kết bằng Khóa phụ với Bảng Student va Course
        public Student Students { get; set; }

        public Course Courses { get; set;  }
    }
}
