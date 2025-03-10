using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Models.UIModels
{
    public class QueryCCDDataModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Code { get; set; }
        public string Result { get; set; }
        public string CameraNum { get; set; }
    }
}
