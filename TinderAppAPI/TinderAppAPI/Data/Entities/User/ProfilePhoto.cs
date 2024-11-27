﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.User
{
    public class ProfilePhoto
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}