﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Models.UIModels
{
    public class QueryLogDataModel
    {
        public string LogType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
