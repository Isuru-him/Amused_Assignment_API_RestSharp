﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusedAPIProject
{
    public class GetSingleObjectDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public Data data { get; set; }

    }


}
