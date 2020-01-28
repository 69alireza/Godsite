using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Site.Models
{
     public  class Users
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(80)]
        public string UserName { get; set; }
        [StringLength(80)]
        public string Fname { get; set; }
        [StringLength(80)]
        public string Lname { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(200)]
        public string TemporaryEmail { get; set; }

        public DateTime? BirthDate { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        public int Gender { get; set; }
        [StringLength(80)]
        public string Mobile { get; set; }
        public bool? ActiveMobile { get; set; }
        [StringLength(80)]
        public string Grade { get; set; }
        [StringLength(80)]
        public string Study { get; set; }
        [StringLength(200)]
        public string Password { get; set; }
        [StringLength(200)]
        public string ActiveCode { get; set; }
        public bool IsActive { get; set; }
        [StringLength(200)]
        public string UserAvatar { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
