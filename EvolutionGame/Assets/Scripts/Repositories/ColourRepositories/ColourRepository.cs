using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities;
using System.Data;
using Dapper;
using System.Linq;
using Mono.Data.Sqlite;

namespace Repositories
{
    public interface IColourRepository : IRepository<Colours>
    {

    }


    public class ColourRepository : IColourRepository
    {
        public IDbConnection _connection { get; set; }

        public ColourRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Delete(Colours entity)
        {
            var sql = $@"Delete from Colours where Colours.Id = {entity.Id}";
            _connection.Execute(sql);
        }

        public List<Colours> GetAll()
        {
            var sql = $@"Select * From Colours";
            return _connection.Query<Colours>(sql).ToList();
        }

        public Colours GetById(int id)
        {
            var sql = $@"Select * From Colours where Colours.Id = {id}";
            return _connection.Query<Colours>(sql).SingleOrDefault();
        }


        public void Insert(Colours entity)
        {
            var sql = $@"Insert Into Colours(@Name,@Red,@Green,@Blue,@Alpha)";
            _connection.Execute(sql,
                new
                {
                    entity.Name,
                    entity.Red,
                    entity.Green,
                    entity.Blue,
                    entity.Alpha
                });
        }
    }


}
