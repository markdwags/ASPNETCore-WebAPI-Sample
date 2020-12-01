using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleWebApiAspNetCore.Models
{
    [Keyless]
    public class Playground
    {
        public int equip_id { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public string location { get; set; }
        public DateTime install_date { get; set; }
    }
}
