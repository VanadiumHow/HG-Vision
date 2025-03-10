using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Models.DModels
{
    public class CCDDataModel
    {
        private int Num { get; set; }

        /// <summary>
        /// X偏移量
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Y偏移量
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// T偏移量
        /// </summary>
        public double T { get; set; }

        public string CameraNum { get; set; }

        public string Code { get; set; }

        public double Length { get; set; }

        public double Area { get; set; }

        public double Width { get; set; }

        public string Result { get; set; }

        public DateTime CreateDatetime { get; set; }

        public CCDDataModel()
        {

        }
    }
}
