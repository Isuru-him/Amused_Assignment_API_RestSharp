using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusedAPIProject
{
    public class UpdateObjectDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Data Data { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

    }


}
