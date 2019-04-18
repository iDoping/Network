using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public string Lesson { get; set; }
        public int Presense { get; set; }
        [DataType(DataType.Time)]
        public DateTime TimeOfDelay { get; set; }
    }
}
