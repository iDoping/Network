using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class DisciplineInformation
    {
        public int ID { get; set; }        
        public string Speciality { get; set; }
        public string Discipline { get; set; }
        public int AmountOfLections { get; set; }
        public int AmountOfLabs { get; set; }
        public int AmountOfPractics { get; set; }
    }
}
