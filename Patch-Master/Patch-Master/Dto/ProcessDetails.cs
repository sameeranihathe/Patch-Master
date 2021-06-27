using System;
using System.Collections.Generic;
using System.Text;

namespace Patch_Master.Dto
{
    public class ProcessDetails
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string ProcessDescription { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedUsername { get; set; }
        public string CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
