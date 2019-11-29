using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP_Core_EF.Repository
{
    public class StudentRepository : IStudent
    {
        private DB_Context db;

        public StudentRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Student> GetStudents => db.Students.Include(g => g.Gender);

        public void Add(Student _Student)
        {
            db.Students.Add(_Student);
            db.SaveChanges();
        }

        public Student GetStudent(int? Id)
        {
            Student dbEntity = db.Students.Include(e => e.Enrollments)
                                          .ThenInclude(c => c.Courses)      //Sử dụng thenInclude vì Bảng Student liên kết với Course thông qua bảng Enrollment
                                          .Include(g => g.Gender)
                                          .SingleOrDefault(m => m.StudentId == Id);
            return dbEntity;
        }

        

        public void Remove(int? Id)
        {
            Student dbEntity = db.Students.Find(Id);
            db.Students.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
