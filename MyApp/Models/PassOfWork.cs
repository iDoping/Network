using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class PassOfWork
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string TypeOfWork { get; set; }
        public int NumberOfWork { get; set; }
        public string CallOfDiscipline { get; set; }
    }
}
