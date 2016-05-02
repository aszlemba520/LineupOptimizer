//using LineupOptimizer.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;

//namespace LineupOptimizer.Domain.Repository
//{
//    public interface IGeneralRepository<T> where T : IBaseEntity
//    {
//        T Get(Guid id);
//        IEnumerable<T> GetAll();
//        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
//        void Delete(T obj);
//        void Save(T obj);
//    }

//    public class GeneralRepository<T> : IGeneralRepository<T>
//    {
//        public void Delete(T obj)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public T Get(Guid id)
//        {
//            throw new NotImplementedException();
//        }

//        public T Get<T>(Guid id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<T> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<T> GetAll<T>()
//        {
//            throw new NotImplementedException();
//        }

//        public void Save(T obj)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
