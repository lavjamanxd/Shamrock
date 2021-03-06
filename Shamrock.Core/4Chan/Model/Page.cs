﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Shamrock.Core._4Chan.Model
{
    public class Page
    {
        [JsonProperty("threads")]
        public IEnumerable<Thread> Threads { get; set; }

        [JsonProperty("page")]
        public int PageIndex { get; set; }
    }
}