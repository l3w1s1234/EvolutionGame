using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities;
using System.Data;
using Dapper;
using System.Linq;

namespace Repositories
{
    public interface IColourTypeRepository : IRepository<ColourTypes>
    {

    }


    public class ColourTypesRepository : IColourTypeRepository
    {
        public IDbConnection _connection { get; set; }

        public ColourTypesRepository(IDbConnection connection)
        {
            _connection = connection;
        }


        public void Delete(ColourTypes entity)
        {
            var sql = $@"Delete From ColourTypes where ColourTypes.Id = {entity.Id}";
            _connection.Execute(sql);
        }

        public List<ColourTypes> GetAll()
        {
            var sql = $@"Select * From ColourTypes";
            return _connection.Query<ColourTypes>(sql).ToList();
        }

        public ColourTypes GetById(int id)
        {
            var sql = $@"Select * From ColourTypes Where ColourTypes.Id = {id}";

            return _connection.Query<ColourTypes>(sql).SingleOrDefault();
 
        }

        public void Insert(ColourTypes entity)
        {
            var sql = $@"Insert Into ColourTypes(@Name)";
            _connection.Execute(sql,
                new
                {
                    entity.Name
                });
        }
    }

}
