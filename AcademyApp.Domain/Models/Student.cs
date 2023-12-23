﻿using AcademyApp.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Domain.Models
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set;}
        public Group Group { get; set;}

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} SurName: {SurName} Age: {Age} Group: {Group} CreatedAt: {CreatedDate}";
        }

    }
}
