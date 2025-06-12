using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sync_Async.CObject
{
    class Crobot : Cbase
    {
        public Rectangle rtCircleRobot; // 원형 로봇
        public Rectangle rtRobotArm; // 로봇팔
        public Rectangle rtObject; // 받아오는 물건

        // 생성자
        public Crobot(string strName) 
        {
            sName = strName;
            pen = new Pen(Color.White, 3);
            brush = new SolidBrush(Color.White);

            rtCircleRobot = new Rectangle(35, 70, 90, 90);
            rtRobotArm = new Rectangle(40, 100, 70, 20);
            rtObject = new Rectangle(71, 143, 15, 23);
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
            // 로봇팔
            Point point = rtRobotArm.Location; // 현재 로봇팔의 위치를 저장
            point.X = point.X + move; // 한칸 움직인 위치를 저장
            rtRobotArm.Location = point; // 움직인 위치를 원래 로봇팔 위치로 돌려줌

            // 물건
            point = rtObject.Location; // 현재 물건의 위치를 저장
            point.X = point.X + move; // 한칸 움직인 위치를 저장
            rtObject.Location = point; // 움직인 위치를 원래 물건 위치로 돌려줌
        }
        #endregion
    }
}
