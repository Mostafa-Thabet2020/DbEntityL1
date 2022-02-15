using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbEntityL1.Interfaces;
using DbEntityL1.Models;

namespace DbEntityL1.Service
{
    public class TeacherService : ITeacherRepostory
    {
        EntityDbContext context = new EntityDbContext();
        public void Add(Teachers obj)
        {
            obj.CreatedDate = DateTime.Now;
            context.teachers.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            //Teachers teachers = context.teachers.Find(Id);
            context.teachers.Remove(Get(Id));
        }

        public List<Teachers> Get()
        {
            return context.teachers.ToList();
        }
        /// <summary>
        /// Get object of teacher by id
        /// </summary>
        public Teachers Get(int Id)
        {
            return context.teachers.Find(Id);
        }

        public void Update(Teachers obj)
        {
            Teachers OldTeacher = Get(obj.Id);
            OldTeacher.FirstName = obj.FirstName;
            OldTeacher.LastName = obj.LastName;
            OldTeacher.Birthday = obj.Birthday;
            OldTeacher.LastModified = DateTime.Now;
            context.teachers.Update(OldTeacher);
            context.SaveChanges();
        }
        public bool IsExist(int Id)
        {
            return context.teachers.Any(x => x.Id == Id);
        }
        public bool IsExist(string FirstName)
        {
            return context.teachers.Any(x => x.FirstName == FirstName);
        }
    }
}
