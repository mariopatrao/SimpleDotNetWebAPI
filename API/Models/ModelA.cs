using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ModelA
    {
        // The Model should contain all the variables used for the commands in this API Model (ModelA)
        // Command will exist in all Models (ModelA, ModelB, etc) and will be the variable that will decide which function to use (Ex: Insert user)
        public string Command { get; set; }
        public string varA { get; set; }
        public string varB { get; set; }
    }
}