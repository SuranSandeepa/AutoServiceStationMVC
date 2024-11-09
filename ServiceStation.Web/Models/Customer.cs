﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [StringLength(200)]
        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; } = false;
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    }
}
