using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.DataContext
{
    static class DbContext //crud
    {
        public static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        static DbContext()
        {
            Students = new List<Student>();
            Students.Add(new Student() { Id = 1, Name = "Teymur", SurName = "Suleymanov", Age = 15, Group = null,CreatedDate = DateTime.Now }) ;
            Groups = new List<Group>();
            Groups.Add(new Group() { Id = 1, Name = "P518", MaxSize = 14, CreatedDate = DateTime.Now });
            
        }
    }
}
