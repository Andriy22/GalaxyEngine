﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FrontPage
    {
        public FrontPage()
        {
            Components = new List<FrontComponent>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Route { get; set; }
        public bool IsDeleted { get; set; }
        public List<FrontComponent> Components { get; set; }
    }
}
