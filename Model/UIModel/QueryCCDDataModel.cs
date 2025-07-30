using System;

/****************************************************************

*****************************************************************/
namespace Model.UIModel
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
