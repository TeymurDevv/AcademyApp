﻿using AcademyApp.Domain.Models;
using AcademyApp.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.DataContext.Interfaces
{
    public interface Irepository< T> where T : BaseEntity
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(Predicate<T> filter);
        List<T> GetAll(Predicate<T> filter= null);
        
    }
}
