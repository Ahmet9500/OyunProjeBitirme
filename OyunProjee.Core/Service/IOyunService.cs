﻿using OyunProjee.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjee.Core.Service
{
    public interface IOyunService<T> where T: OyunProjeEntity
    {
        bool Add(T item); 
        bool Delete(int id); 
        bool Update(T item); 
        T GetByID(int id);
        T GetRecord(Expression<Func<T, bool>> expression);
        List<T> GetAll(); 
        int Save(); 
    }
}
