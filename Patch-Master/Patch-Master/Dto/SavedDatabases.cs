using System;
using System.Collections.Generic;
using System.Text;

namespace Patch_Master.Dto
{
    public class SavedDatabases
    {
        public int DatabaseId { get; set; }
        public string DatabaseName { get; set; }
        public bool Status { get; set; }
    }
}
