using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public partial class Form1: Form
    {
        private PrintDocument printDocument;
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* using()  /외부 클래스를 가져와서 사용, 단 using안에서만
               {
               }
            */
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                // Filter -> 열기의 팝업창에서 다룰 수 있는 확장자 설정
                openfile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                // ShowDialog -> 열기 팝업창을 띄우면서 DialogResult 값을 반환 (함수이자 값)
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    // ReadAllText에는 경로를 적어야 함. 해당하는 파일의 모든 텍스트를 가져온다. / 파일이름 -> 바탕화면/
                    textBox1.Text = File.ReadAllText(openfile.FileName);
                }
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savefile = new SaveFileDialog())
            {
                // 저장의 팝업창에서 다룰 수 있는 확장자 설정
                savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                // ShowDialog -> 저장 팝업창을 띄우면서 DialogResult 값을 반환 (함수이자 값)
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    // ReadAllText에는 경로를 지정해야함. 컨텐츠 = textbox에 있는 text / 파일이름 -> 원하는 파일명
                    File.WriteAllText(savefile.FileName, textBox1.Text);
                }
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 새창ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show(); // Modaless 우선권 없음, 일반창
            form.ShowDialog(); // Modal 팝업 우선, 결과를 받아야만 돌아감.
        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintDialog printdialog = new PrintDialog())
            {

                // ShowDialog -> 인쇄 팝업창을 띄우면서 DialogResult 값을 반환 (함수이자 값)
                if (printdialog.ShowDialog() == DialogResult.OK)
                {
                    
                    printDocument.Print();
                }
            }
        }
    }
}
