﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Content.API.Models
{
    public class PostImage
    {
        public string Url { get; set; } = string.Empty;

        public string ThumbnailUrl { get; set; } = string.Empty;

        public long ImageSize { get; set; } = 0L;
    }
}
