using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities;
using System.Data;
using Dapper;
using System.Linq;

namespace Repositories
{
    public interface IPlanetTypesRepository : IRepository<PlanetTypes>
    {

    }


    public class PlanetTypesRepository : IPlanetTypesRepository
    {
        public IDbConnection _connection { get; set; }

        public PlanetTypesRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Delete(PlanetTypes entity)
        {
            var sql = $@"Delete from PlanetTypes where PlanetTypes.Id = {entity.Id}";
            _connection.Execute(sql);
        }

        public List<PlanetTypes> GetAll()
        {
            var sql = $@"Select * from PlanetTypes";
            return _connection.Query<PlanetTypes>(sql).ToList();
        }

        public PlanetTypes GetById(int id)
        {
            var sql = $@"Select * from PlanetTypes where PlanetTypes.Id = {id}";
            return _connection.Query<PlanetTypes>(sql).SingleOrDefault();
        }

        public void Insert(PlanetTypes entity)
        {
            var sql = $@"Insert Into PlanetTypes(@Type,@WaterVolume,@LandMass,@RotationSpeed,@PlanetScale,@PlanetDistance,@MinTemp,@MaxTemp)";
            _connection.Execute(sql,
                new
                {
                    entity.Type,
                    entity.WaterVolume,
                    entity.LandMass,
                    entity.RotationSpeed,
                    entity.PlanetScale,
                    entity.PlanetDistance,
                    entity.MinTemp,
                    entity.MaxTemp
                });
        }
    }
    }


