namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPos = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAimPos = new System.Windows.Forms.TextBox();
            this.btnPSNTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPos
            // 
            this.tbPos.Location = new System.Drawing.Point(85, 5);
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(89, 25);
            this.tbPos.TabIndex = 1;
            this.tbPos.Text = "0,0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "鼠标位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "移动到";
            // 
            // tbAimPos
            // 
            this.tbAimPos.Location = new System.Drawing.Point(85, 33);
            this.tbAimPos.Name = "tbAimPos";
            this.tbAimPos.Size = new System.Drawing.Size(89, 25);
            this.tbAimPos.TabIndex = 4;
            this.tbAimPos.Text = "0,0";
            // 
            // btnPSNTest
            // 
            this.btnPSNTest.Location = new System.Drawing.Point(402, 12);
            this.btnPSNTest.Name = "btnPSNTest";
            this.btnPSNTest.Size = new System.Drawing.Size(104, 81);
            this.btnPSNTest.TabIndex = 5;
            this.btnPSNTest.Text = "psn";
            this.btnPSNTest.UseVisualStyleBackColor = true;
            this.btnPSNTest.Click += new System.EventHandler(this.btnPSNTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 225);
            this.Controls.Add(this.btnPSNTest);
            this.Controls.Add(this.tbAimPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPos);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAimPos;
        private System.Windows.Forms.Button btnPSNTest;
    }
}

