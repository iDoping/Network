using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class StudentInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnterDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string OrderNumber { get; set; }
        public string Group { get; set; }
        public string ParentsNumber { get; set; }
        public string Adress { get; set; }
        public string Notes { get; set; }
    }
}