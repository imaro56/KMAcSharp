using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    public class CinemaHallEntity // Hall model
    {
        public int Id { get; }
        public string Name { get; set; }
        public int SeatsNumber { get; set; }
        public CinemaHallType Type { get; set; }

        // We dont have total duration becauses we can calculate it in view model
        // List of sessions we also dont have, because we can get it from service when we need it. Prevents duplicating data
        public CinemaHallEntity(int id, string name, int seatsNumber, CinemaHallType type)
        {
            Id = id;
            Name = name;
            SeatsNumber = seatsNumber;
            Type = type;
        }
    }
}
