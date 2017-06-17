﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTVideos.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribed { get; set; }
       
        public MembershipType MembershipType { get; set; }

        [Display(Name = "MembershipType")]
        public byte MembershipTypeId { get; set; }

    }
}