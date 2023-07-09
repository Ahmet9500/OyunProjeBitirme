using OyunProjee.Core.Entity;
using OyunProjee.Core.Service;
using OyunProjee.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjee.Service.Temel
{
    public class BaseService<T> : IOyunService<T> where T : OyunProjeEntity
    {
        private readonly OyunContext _o;
        public BaseService(OyunContext o)
        {
            _o = o;
        }
        public bool Add(T item)
        {
            try
            {
                _o.Set<T>().Add(item);
                return Save() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _o.Set<T>().Remove(GetByID(id));
                return Save() > 0;  
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<T> GetAll()
        {
          return  _o.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _o.Set<T>().Find(id);
        }

       

        public int Save()
        {
            return _o.SaveChanges();
        }

        public bool Update(T item)
        {
            try
            {
                _o.Set<T>().Update(item);
                return Save() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
