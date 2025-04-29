namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_memory = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_eql = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_root = new System.Windows.Forms.Button();
            this.btn_sqr = new System.Windows.Forms.Button();
            this.btn_divx = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_memory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_result, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 796F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_memory
            // 
            this.lbl_memory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_memory.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_memory.Location = new System.Drawing.Point(3, 0);
            this.lbl_memory.Name = "lbl_memory";
            this.lbl_memory.Size = new System.Drawing.Size(544, 58);
            this.lbl_memory.TabIndex = 0;
            this.lbl_memory.Text = "0";
            this.lbl_memory.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txt_result
            // 
            this.txt_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_result.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_result.Location = new System.Drawing.Point(3, 61);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(544, 44);
            this.txt_result.TabIndex = 1;
            this.txt_result.Text = "0";
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_result_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_eql, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_dot, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_0, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_sin, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_plus, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_3, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_sub, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_6, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_x, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_div, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_root, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_sqr, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_divx, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_del, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_c, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_ce, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_percent, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 790);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_eql
            // 
            this.btn_eql.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_eql.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_eql.Location = new System.Drawing.Point(413, 660);
            this.btn_eql.Margin = new System.Windows.Forms.Padding(5);
            this.btn_eql.Name = "btn_eql";
            this.btn_eql.Size = new System.Drawing.Size(126, 125);
            this.btn_eql.TabIndex = 23;
            this.btn_eql.Text = "=";
            this.btn_eql.UseVisualStyleBackColor = false;
            this.btn_eql.Click += new System.EventHandler(this.btn_eql_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dot.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dot.Location = new System.Drawing.Point(277, 660);
            this.btn_dot.Margin = new System.Windows.Forms.Padding(5);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(126, 125);
            this.btn_dot.TabIndex = 22;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_0
            // 
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_0.Location = new System.Drawing.Point(141, 660);
            this.btn_0.Margin = new System.Windows.Forms.Padding(5);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(126, 125);
            this.btn_0.TabIndex = 21;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_sin
            // 
            this.btn_sin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sin.Location = new System.Drawing.Point(5, 660);
            this.btn_sin.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(126, 125);
            this.btn_sin.TabIndex = 20;
            this.btn_sin.Text = "±";
            this.btn_sin.UseVisualStyleBackColor = true;
            // 
            // btn_plus
            // 
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_plus.Location = new System.Drawing.Point(413, 529);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(5);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(126, 121);
            this.btn_plus.TabIndex = 19;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_3
            // 
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_3.Location = new System.Drawing.Point(277, 529);
            this.btn_3.Margin = new System.Windows.Forms.Padding(5);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(126, 121);
            this.btn_3.TabIndex = 18;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_2.Location = new System.Drawing.Point(141, 529);
            this.btn_2.Margin = new System.Windows.Forms.Padding(5);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(126, 121);
            this.btn_2.TabIndex = 17;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_1
            // 
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_1.Location = new System.Drawing.Point(5, 529);
            this.btn_1.Margin = new System.Windows.Forms.Padding(5);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(126, 121);
            this.btn_1.TabIndex = 16;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sub.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sub.Location = new System.Drawing.Point(413, 398);
            this.btn_sub.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(126, 121);
            this.btn_sub.TabIndex = 15;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_6
            // 
            this.btn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_6.Location = new System.Drawing.Point(277, 398);
            this.btn_6.Margin = new System.Windows.Forms.Padding(5);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(126, 121);
            this.btn_6.TabIndex = 14;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_5
            // 
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_5.Location = new System.Drawing.Point(141, 398);
            this.btn_5.Margin = new System.Windows.Forms.Padding(5);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(126, 121);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_4
            // 
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_4.Location = new System.Drawing.Point(5, 398);
            this.btn_4.Margin = new System.Windows.Forms.Padding(5);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(126, 121);
            this.btn_4.TabIndex = 12;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_x
            // 
            this.btn_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_x.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_x.Location = new System.Drawing.Point(413, 267);
            this.btn_x.Margin = new System.Windows.Forms.Padding(5);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(126, 121);
            this.btn_x.TabIndex = 11;
            this.btn_x.Text = "*";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_9
            // 
            this.btn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_9.Location = new System.Drawing.Point(277, 267);
            this.btn_9.Margin = new System.Windows.Forms.Padding(5);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(126, 121);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_8
            // 
            this.btn_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_8.Location = new System.Drawing.Point(141, 267);
            this.btn_8.Margin = new System.Windows.Forms.Padding(5);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(126, 121);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_7
            // 
            this.btn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_7.Location = new System.Drawing.Point(5, 267);
            this.btn_7.Margin = new System.Windows.Forms.Padding(5);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(126, 121);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_div
            // 
            this.btn_div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_div.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_div.Location = new System.Drawing.Point(413, 136);
            this.btn_div.Margin = new System.Windows.Forms.Padding(5);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(126, 121);
            this.btn_div.TabIndex = 7;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_root
            // 
            this.btn_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_root.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_root.Location = new System.Drawing.Point(277, 136);
            this.btn_root.Margin = new System.Windows.Forms.Padding(5);
            this.btn_root.Name = "btn_root";
            this.btn_root.Size = new System.Drawing.Size(126, 121);
            this.btn_root.TabIndex = 6;
            this.btn_root.Text = "√";
            this.btn_root.UseVisualStyleBackColor = true;
            // 
            // btn_sqr
            // 
            this.btn_sqr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sqr.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sqr.Location = new System.Drawing.Point(141, 136);
            this.btn_sqr.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sqr.Name = "btn_sqr";
            this.btn_sqr.Size = new System.Drawing.Size(126, 121);
            this.btn_sqr.TabIndex = 5;
            this.btn_sqr.Text = "x^2";
            this.btn_sqr.UseVisualStyleBackColor = true;
            // 
            // btn_divx
            // 
            this.btn_divx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_divx.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_divx.Location = new System.Drawing.Point(5, 136);
            this.btn_divx.Margin = new System.Windows.Forms.Padding(5);
            this.btn_divx.Name = "btn_divx";
            this.btn_divx.Size = new System.Drawing.Size(126, 121);
            this.btn_divx.TabIndex = 4;
            this.btn_divx.Text = "1/x";
            this.btn_divx.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_del.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_del.Location = new System.Drawing.Point(413, 5);
            this.btn_del.Margin = new System.Windows.Forms.Padding(5);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(126, 121);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "<";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_c
            // 
            this.btn_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_c.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_c.Location = new System.Drawing.Point(277, 5);
            this.btn_c.Margin = new System.Windows.Forms.Padding(5);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(126, 121);
            this.btn_c.TabIndex = 2;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ce.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ce.Location = new System.Drawing.Point(141, 5);
            this.btn_ce.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(126, 121);
            this.btn_ce.TabIndex = 1;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            // 
            // btn_percent
            // 
            this.btn_percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_percent.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_percent.Location = new System.Drawing.Point(5, 5);
            this.btn_percent.Margin = new System.Windows.Forms.Padding(5);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(126, 121);
            this.btn_percent.TabIndex = 0;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 900);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_memory;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.Button btn_eql;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_sin;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_root;
        private System.Windows.Forms.Button btn_sqr;
        private System.Windows.Forms.Button btn_divx;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_ce;
    }
}

