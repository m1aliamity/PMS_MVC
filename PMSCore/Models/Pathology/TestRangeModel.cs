using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class TestRangeModel:BaseModel
    {
        public long Age { get; set; }
        public string FromRange { get; set; }
        public string ToRange { get; set; }
        public string DefaultRange { get; set; }
    }
}
