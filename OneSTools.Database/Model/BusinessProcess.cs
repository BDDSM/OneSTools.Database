﻿using System.Collections.Generic;

namespace OneSTools.Config
{
    public class BusinessProcess : MetadataObject
    {
        public List<Requisite> Requisities { get; set; } = new List<Requisite>();
        public List<TabularSection> TabularSections { get; set; } = new List<TabularSection>();
    }
}
