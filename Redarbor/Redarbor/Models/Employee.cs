﻿using Redarbor.Models;
namespace Redarbor.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Lastlogin { get; set; }
        public string Password { get; set; }
        public int PortalId { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }
        public string Telephone { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Username { get; set; }
    }

}