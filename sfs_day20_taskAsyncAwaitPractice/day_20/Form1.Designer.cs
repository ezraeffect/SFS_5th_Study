namespace day_20
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
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.button_OpenDialog = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(12, 12);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(776, 397);
            this.textBox_Result.TabIndex = 0;
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Location = new System.Drawing.Point(12, 417);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.ReadOnly = true;
            this.textBox_filePath.Size = new System.Drawing.Size(658, 21);
            this.textBox_filePath.TabIndex = 1;
            // 
            // button_OpenDialog
            // 
            this.button_OpenDialog.Location = new System.Drawing.Point(676, 415);
            this.button_OpenDialog.Name = "button_OpenDialog";
            this.button_OpenDialog.Size = new System.Drawing.Size(31, 23);
            this.button_OpenDialog.TabIndex = 2;
            this.button_OpenDialog.Text = "...";
            this.button_OpenDialog.UseVisualStyleBackColor = true;
            this.button_OpenDialog.Click += new System.EventHandler(this.button_OpenDialog_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(713, 415);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "시작";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_OpenDialog);
            this.Controls.Add(this.textBox_filePath);
            this.Controls.Add(this.textBox_Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Button button_OpenDialog;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

