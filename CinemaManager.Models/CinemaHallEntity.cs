using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    public class CinemaHallEntity
    {
        public int Id { get; }
        public string Name { get; set; }
        public int SeatsNumber { get; set; }
        public CinemaHallType Type { get; set; }
        public CinemaHallEntity(int id, string name, int seatsNumber, CinemaHallType type)
        {
            Id = id;
            Name = name;
            SeatsNumber = seatsNumber;
            Type = type;
        }
    }
}
