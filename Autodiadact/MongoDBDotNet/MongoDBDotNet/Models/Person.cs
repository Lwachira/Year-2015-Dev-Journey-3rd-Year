﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDBDotNet.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Profession { get; set; }

        public int Age { get; set; }
    }
}