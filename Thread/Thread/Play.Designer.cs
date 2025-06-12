namespace ThreadApp
{
    partial class Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_process = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.pgb_player = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(12, 31);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(130, 24);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "PlayerName";
            // 
            // lbl_process
            // 
            this.lbl_process.AutoSize = true;
            this.lbl_process.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_process.Location = new System.Drawing.Point(611, 31);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(228, 24);
            this.lbl_process.TabIndex = 1;
            this.lbl_process.Text = "진행 상황 표시 : 0%";
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_stop.Location = new System.Drawing.Point(433, 25);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(103, 37);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "포기";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // pgb_player
            // 
            this.pgb_player.Location = new System.Drawing.Point(16, 81);
            this.pgb_player.Name = "pgb_player";
            this.pgb_player.Size = new System.Drawing.Size(823, 44);
            this.pgb_player.TabIndex = 3;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 155);
            this.Controls.Add(this.pgb_player);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lbl_process);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_process;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ProgressBar pgb_player;
    }
}