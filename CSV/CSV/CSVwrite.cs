using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV
{
    public partial class CSVwrite: Form
    {
        public CSVwrite()
        {
            InitializeComponent();
        }
        #region 함수

        private void CreateCsv()
        {
            StringBuilder sb = new StringBuilder(); // DataGridView에 있는 모든 데이터를 CSV파일로 만들기 위해 문자열로 담아줄 그릇

            // 헤더
            for (int i = 0; i < dgv_getdata.Columns.Count; i++)
            {
                sb.Append(dgv_getdata.Columns[i].HeaderText); // 각 열에 있는 제목을 sb에 담음
                if(i < dgv_getdata.Columns.Count - 1) // 마지막 열은 안넣고 줄바꿈
                {
                    sb.Append(",");
                }
            }
            sb.AppendLine();

            // 데이터 추가
            foreach (DataGridViewRow row in dgv_getdata.Rows)
            {
                if (!row.IsNewRow) // 마지막 줄이 아니라면
                {
                    for (int i = 0; i < dgv_getdata.Columns.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value); // 각 칸에 있는 값을 sb에 담음
                        if(i < dgv_getdata.Columns.Count - 1)
                        {
                            sb.Append(",");
                        }
                    }
                    sb.AppendLine();
                }
            }

            // CSV 파일 생성 
            string filePath = "data.csv"; // 파일 경로이자 이름을 넣음 (고정적인 이름을 부여할때 하드코딩)
            if (File.Exists(filePath) == false) // csv 파일 존재 유무 확인해서 없으면 생성
            {
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            }

            if (IsFileLocked(filePath)) // 파일이 열려있는지 닫혀있는지 확인 (오류방지)
            {
                timer1.Stop();
                // MessageBox.Show("내용", "제목", MessageBoxButtons, MessageBoxIcon); 기본 형식
                DialogResult = MessageBox.Show("파일이 실행중입니다. 창을 닫아주세요", "창 닫기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(DialogResult == DialogResult.OK) // 창을 닫고 확인했을때
                {
                    CreateCsv(); // 다시 CSV파일을 가져와서 저장한다.
                }
            }
            else
            {
                timer1.Start();
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            }
            
        }

        private bool IsFileLocked(string filePath) // 오류 방지 상황을 위해 만든 함수의 내용
        {
            try
            {
                // 파일을 읽고 쓰기 모드로 열고, 공유 안됨
                using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false; // 파일을 열 수 있음
                }
            }
            catch(IOException)
            {
                return true; // 파일이 열려 있어서 잠김
            }
        }

        private void CreateData()
        {
            int rowIndex = dgv_getdata.Rows.Add(); // datagridview에서 새롭게 한줄 추가
            DataGridViewRow newRow = dgv_getdata.Rows[rowIndex]; // datagridview에서 한 행이 몇번째 행인지 대입을 통해 지정해줌. 몇번째 행인지 대입하여 알려줘야함.

            for (int i = 0; i < dgv_getdata.Columns.Count; i++) // 만들어진 열을 돌면서 데이터를 채움
            {
                newRow.Cells[i].Value = (rowIndex + 1) * (i + 1); // 한 줄안의 한 칸을 값으로 채움
            }
        }

        private void ShowData()
        {
            string filePath = "data.csv"; // 읽어올 파일
            DataTable csvData = ReadCsvFile(filePath); // 파일을 읽어서 데이터 테이블에 입력

            // CSVRead 화면 띄우기
            CSVread csvform = new CSVread();
            csvform.dataGridView1.DataSource = csvData; // 다른 폼에 있는 DataGridView에 접근하여 데이터 테이블을 할당, 다른 폼에서 가져오려면 public으로 바꿔주어야 함
            csvform.Show(); // 화면 띄우기

        }

        private DataTable ReadCsvFile(string filePath)
        {
            DataTable dt = new DataTable(); // 데이터 테이블 객체 생성
            try
            {
                using (StreamReader sr = new StreamReader(filePath)) // 파일을 읽어옴
                {
                    string[] headers = sr.ReadLine().Split(','); // 1번 데이터, 2번 데이터, 3번 데이터 => ["1번 데이터", "2번 데이터", "3번 데이터"]
                    foreach (string line in headers)
                    {
                        dt.Columns.Add(line);
                    }
                    while (!sr.EndOfStream) // 한 줄 만들고 값 넣어주고, 한 줄 만들고 값 넣어주기 반복
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV파일 오류 : {ex.Message}");
            }
            return dt;
        }
        #endregion

        #region 이벤트

        private void timer1_Tick(object sender, EventArgs e) // 프로그램을 작동시키면 타이머가 작동하면서 화면에 데이터가 쌓인다.
        {
            CreateData();
            CreateCsv();
        }

        private void btn_CSVread_Click(object sender, EventArgs e) // 버튼을 누르면 write에 쌓여있던 데이터를 read에 가져와서 입력된다.
        {
            ShowData();
        }

        

        #endregion

    }
}
