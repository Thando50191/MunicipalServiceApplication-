using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalServiceApplication
{
    public class Issue
    {
        public string Location { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public string AttachedFile { get; set; } = "";
    }
}
