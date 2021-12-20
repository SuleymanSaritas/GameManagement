using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
