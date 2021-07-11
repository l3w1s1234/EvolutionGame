using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities;
using Repositories;
using System.Data;


namespace DAL
{
    public class PlanetTypesDataAccess
    {
        private IDbConnection _connection;

        public PlanetTypesDataAccess(IDbConnection con)
        {
            _connection = con;
        }


        public List<PlanetTypes> GetPlanetTypes()
        {
            var planetTypesRepo = new PlanetTypesRepository(_connection);
            var planetTypes = planetTypesRepo.GetAll();

            return planetTypes;
        }

        public List<Colours> getPlanetColours(PlanetTypes pt, ColourTypes ct)
        {
            var planetColoursRepo = new PlanetColoursRepository(_connection);
            var coloursRepo = new ColourRepository(_connection);
            var planetColours = planetColoursRepo.GetByPlanetTypeColourType(pt, ct);
            var listColours = new List<Colours>();

            foreach (var pc in planetColours)
            {
                var col = coloursRepo.GetById(pc.ColourId);
                listColours.Add(col);
            }

            return listColours;
        }

        //get a string of types
        public List<string> GetPlanetTypeNames()
        {
            var planetTypesRepo = new PlanetTypesRepository(_connection);
            var planetTypes = planetTypesRepo.GetAll();

            var planetTypesNames = new List<string>();

            foreach(var pt in planetTypes)
            {
                planetTypesNames.Add(pt.Type);
            }
            return planetTypesNames;
        }

    }
}

