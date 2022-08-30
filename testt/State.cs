using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using testt.Models;

namespace testt
{
    public class State
    {
        public State()
        {

        }
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string region { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }

}

