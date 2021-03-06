﻿using SiteMap.NET.Enums;
using System;

namespace SiteMap.NET.Models
{
    public struct SitemapNodeDetail
    {
        public string Controller { get; set; }
        public string Method { get; set; }
        public SiteMapFrequency? Frequency { get; set; }
        public DateTime? LastModified { get; set; }
        public double? Priority { get; set; }
        public string Route { get; set; }
    }
}
