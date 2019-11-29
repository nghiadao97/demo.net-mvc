﻿using ASP_Core_EF.Models;
using ASP_Core_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//-----------
using Microsoft.EntityFrameworkCore;

namespace ASP_Core_EF.Repository
{
    public class CourseRepository : ICourse
    {
        private DB_Context db;

        public CourseRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Course> GetCourses => db.Courses;

        public void Add(Course _Course)
        {
            if (_Course.CourseId == 0)
            {
                db.Courses.Add(_Course);
                db.SaveChanges();
            }
            else
            {
                int id = _Course.CourseId;
                var dbEntity = db.Courses.Find(id);
                dbEntity.CourseName = _Course.CourseName;
                dbEntity.Credits = _Course.Credits;
                db.SaveChanges();
            }
        }

        public Course GetCourse(int? Id)
        {
            Course dbEntity = db.Courses.Include(e => e.Enrollments)
                                        .ThenInclude(s => s.Students)
                                        .SingleOrDefault(a => a.CourseId == Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Course dbEntity = db.Courses.Find(Id);
            db.Courses.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
