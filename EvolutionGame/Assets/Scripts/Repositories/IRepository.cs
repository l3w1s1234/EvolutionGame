using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

namespace Repositories
{
    public interface IRepository<T>
    {
      IDbConnection _connection { get; set; }
        void Insert(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}

