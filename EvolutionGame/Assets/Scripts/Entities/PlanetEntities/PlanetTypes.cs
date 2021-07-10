using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
    public class PlanetTypes
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public float WaterVolume { get; set; }
        public float LandMass { get; set; }
        public float RotationSpeed { get; set; }
        public float PlanetScale { get; set; }
        public float PlanetDistance { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }
    }
}

