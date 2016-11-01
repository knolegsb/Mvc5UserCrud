﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5UserCrud.Models
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IList<UserCountry> UserCountries { get; set; }
    }
}