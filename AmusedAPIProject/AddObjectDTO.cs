using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusedAPIProject
{

    public class AddObjectDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Data Data { get; set; }
        public DateTimeOffset AO_CreatedAt { get; set; }

    }



}
