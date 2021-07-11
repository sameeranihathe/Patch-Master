using System;
using System.Collections.Generic;
using System.Text;

namespace Patch_Master.Dto
{
    public class SelectJoinDetails
    {
        public int RowId { get; set; }
        public string TableOne { get; set; }
        public string TableOneColumn { get; set; }
        public string JoinName { get; set; }
        public string TableTwo { get; set; }
        public string TableTwoColumn { get; set; }
    }
}
