﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress
{
    public class Option_Get
    {
        public string Description { get; set; }
        
        public string Value { get; set; }
        public object ValueObject { get; set; }

        public bool ReadOnly { get; set; }
    }
}
