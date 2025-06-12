using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadApp
{
    public partial class Form1: Form
    {
        #region 전역변수
        private enum Player
        {
            루피,
            조로,
            상디,
            나미,
            우솝
        }

        int locationX = 0;
        int locationY = 0;

        List<Play> lPlay = new List<Play>(); 
        // List<int> lInt = new List<int>(); 
        #endregion

        public Form1()
        {
            InitializeComponent();

            locationX = this.Location.X;
            locationY = this.Location.Y;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Play py in lPlay)
            {
                py.ThreadAbort(); // 리스트 안에 있는 객체가 가지고 있는 Thread를 강제 종료
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (lPlay.Count > 0)
            {
                foreach (Play py in lPlay)
                {
                    py.ThreadAbort();
                    py.Close();
                }
            }
            // Form1의 값과 사이즈를 locationX에 넣어줌 -> 용도는 Form1 바로 옆에 Play 창을 띄우기 위함
            locationX = this.Location.X + this.Size.Width;
            // Form1의 y값을 locationY에 넣어줌 -> 용도는 Play창을 연속적으로 보이기 위함
            locationY = this.Location.Y;

                for (int i = 0; i < nud_player.Value; i++) // 지정된 숫자만큼 play창을 띄움
                {
                    Play py = new Play(((Player)i).ToString()); // 플레이어의 값을 string값으로 전환하여 넣어줌
                    py.Location = new Point(locationX, locationY + py.Height * i); // play창을 연속적으로 아래로 붙여 띄우기 위해 설정
                    py.eventDelMsg += Py_eventDelMsg; // Play.cs에 있는 event를 Form1에서 제어하기 위함

                    py.Show(); // 창을 띄움

                    py.ThreadStart(); // 객체의 Thread를 시작함 / play창을 진행시킴

                    lPlay.Add(py); // Play 객체 리스트에 새로 만든 객체를 추가
                }

        }

        private int Py_eventDelMsg(object sender, string strResult)
        {
            if(this.InvokeRequired)
            { // 요청한 Thread가 현재 Main Thread에 있는 Control을 액세서 할 수 있는지 확인
                this.Invoke(new Action(delegate ()
                {
                    Play py = sender as Play;
                    lb_result.Items.Add($"Player : {py.SPlayerName}, Text : {strResult}");
                }
                ));
            }

            return 0;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        { // 기존의 창 전부 종료
            foreach (Play py in lPlay)
            {
                py.ThreadAbort();
                py.Close();
            }
        }
    }
}
