using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync_Async.CObject
{
    class Cbase
    {
        public string sName; // 이름
        protected Pen pen; // 펜 / protected는 자식 class에서만 다룰 수 있음
        protected SolidBrush brush; // 브러쉬

        // 생성자
        public Cbase() 
        {
            pen = new Pen(Color.Aqua);
        }
    }
}
