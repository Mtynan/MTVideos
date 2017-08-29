using MTVideos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTVideos.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribed { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}