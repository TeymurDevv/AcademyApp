using AcademyApp.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Domain.Models
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }
        public int MaxSize { get; set; }

        public static Group StaticGroup()
        {
            Group group = new Group() {Id=1,Name="P518",MaxSize=15,CreatedDate = DateTime.Now };
            return group;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
