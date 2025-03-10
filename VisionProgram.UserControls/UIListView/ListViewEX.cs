﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace VisionProgram.UserControls.UIListView
{
    public class ListViewEX : ListView
    {
        public ListViewEX()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint,true);
            this.SetStyle(ControlStyles.EnableNotifyMessage,true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }          
        }
    }
}
