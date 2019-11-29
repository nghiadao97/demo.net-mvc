using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Models
{
    public enum Status
    {
        Undergraduate,Postgraduate,PhD,Suspended
    }

    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        // Bat loi de trong ten
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required.")]
        public string LastName { get; set; }

        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "Date Of Birth is Required.")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DisplayName("Gender")]
        public int GenderId { get; set; }

        [DisplayName("Registration Date")]
        [Required(ErrorMessage = "Registration Date is Required.")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }


        [DisplayFormat(NullDisplayText ="No Status")]
        public Status? Status { get; set; }


        //Liên kết bằng Khóa phụ với Bảng Gender
        public Gender Gender { get; set; }


        //------------ ddeer lay thong tin 1 dòng dữ liệu lien ket voi bang khac
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
