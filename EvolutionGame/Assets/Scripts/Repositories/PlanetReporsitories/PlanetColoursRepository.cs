using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities;
using System.Data;
using Dapper;
using System.Linq;

namespace Repositories
{
    public interface IPlanetColoursRepository : IRepository<PlanetColours>
    {

    }


    public class PlanetColoursRepository : IPlanetColoursRepository
    {
        public IDbConnection _connection { get; set; }

        public PlanetColoursRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Delete(PlanetColours entity)
        {
            var sql = $@"Delete from PlanetColours where PlanetColours.Id = {entity.Id}";
            _connection.Execute(sql);
        }

        public List<PlanetColours> GetAll()
        {
            var sql = $@"Select * from PlanetColours";
            return _connection.Query<PlanetColours>(sql).ToList();
        }

        public PlanetColours GetById(int id)
        {
            var sql = $@"Select * from PlanetColours where PlanetColours.Id = {id}";
            return _connection.Query<PlanetColours>(sql).SingleOrDefault();
        }

       public List<PlanetColours> GetByPlanetTypeId(int id)
        {
            var sql = $@"Select * from PlanetColours where PlanetColours.PlanetTypeId = {id}";
            return _connection.Query<PlanetColours>(sql).ToList();
        }

        public List<PlanetColours> GetByPlanetType(PlanetTypes entity)
        {
            var sql = $@"Select * from PlanetColours where PlanetColours.PlanetTypeId = {entity.Id}";
            return _connection.Query<PlanetColours>(sql).ToList();
        }

        public void Insert(PlanetColours entity)
        {
            var sql = $@"Insert Into PlanetColours(@PlanetTypeId,@ColourId,@ColourTypeId)";
            _connection.Execute(sql,
                new
                {
                    entity.PlanetTypeId,
                    entity.ColoursId,
                    entity.ColourTypeId
                });
        }
    }
    }


