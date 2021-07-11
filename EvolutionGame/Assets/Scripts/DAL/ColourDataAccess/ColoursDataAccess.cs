using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Repositories;
using Entities;
using System.Data;

namespace DAL
{
    public class ColoursDataAccess
    {

        private IDbConnection _connection;

        public ColoursDataAccess(IDbConnection con)
        {
            _connection = con;
        }


        //gets a dictrionary of all the colours that can be used for planets
        public Dictionary<string,Color32> GetAllColours()
        {
            var colourDictionary = new Dictionary<string,Color32>();
            var colourRepo = new ColourRepository(_connection);
            var colours = colourRepo.GetAll();

            foreach(var col in colours)
            {
                var colour = new Color32((byte)col.Red, (byte)col.Green, (byte)col.Blue, (byte)col.Alpha);
                colourDictionary.Add(col.Name, colour);
            }

            return colourDictionary;
        }



      

    }
}

