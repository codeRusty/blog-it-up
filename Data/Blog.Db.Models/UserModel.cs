﻿using Blog.Foundation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Db.Models
{
    public class UserModel : MongoEntityBase
    {
        public string Mobile { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Bio { get; set; }

        public string Email { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }
        public string PicPath { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public string Roles { get; set; }
    }
}
