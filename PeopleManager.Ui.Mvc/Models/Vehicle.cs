﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManager.Ui.Mvc.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public required string LicensePlate { get; set; }
        public string? Brand { get; set; }
        public string? Type { get; set; }
        
        public int? ResponsiblePersonId { get; set; }
        public Person? ResponsiblePerson { get; set; }
    }
}
