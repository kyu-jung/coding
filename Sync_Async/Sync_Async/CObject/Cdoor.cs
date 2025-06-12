using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync_Async.CObject
{
    // Cbase에서 상속 받은 클래스
    class Cdoor : Cbase
    {
        public Rectangle rt_doorside; // 문 테두리
        public Rectangle rt_door; // 문

        // 생성자
        public Cdoor(string strName) 
        {
            sName = strName; // sName을 상속받은 변수, strName은 객체를 생성할 때 필요한 매개변수
            pen = new Pen(Color.White, 3); // 펜의 색상과 굵기를 지정
            brush = new SolidBrush(Color.White); // 문 내부를 채울 색상 지정

            rt_doorside = new Rectangle(8, 70, 24, 70);
            rt_door = new Rectangle(8, 70, 24, 70);
        }
        #region 함수(메서드)
        /// <summary>
        /// 설정된 pen의 정보
        /// </summary>
        /// <returns></returns>
        public Pen PenInfo()
        {
            return pen;
        }

        /// <summary>
        /// 설정된 brush 정보
        /// </summary>
        /// <returns></returns>
        public SolidBrush BrushInfo()
        {
            return brush;
        }

        public void DMove(int move)
        {
            SquareMove(move);
        }

        protected void SquareMove(int move)
        {
            Point point = rt_door.Location; // 현재 문의 위치를 저장
            point.Y = point.Y + move; // 한칸 움직인 위치를 저장
            rt_door.Location = point; // 움직인 위치를 원래 문 위치로 돌려줌
        }
        #endregion
    }
}
