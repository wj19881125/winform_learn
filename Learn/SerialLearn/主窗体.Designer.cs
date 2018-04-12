namespace SerialLearn
{
    partial class 主窗体
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
            System.Windows.Forms.Button bt_b2b;
            this.bt_705 = new System.Windows.Forms.Button();
            this.bt_trc = new System.Windows.Forms.Button();
            this.bt_thr = new System.Windows.Forms.Button();
            bt_b2b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_b2b
            // 
            bt_b2b.Location = new System.Drawing.Point(998, 428);
            bt_b2b.Name = "bt_b2b";
            bt_b2b.Size = new System.Drawing.Size(75, 49);
            bt_b2b.TabIndex = 7;
            bt_b2b.Text = "B2B";
            bt_b2b.UseVisualStyleBackColor = true;
            // 
            // bt_705
            // 
            this.bt_705.Location = new System.Drawing.Point(218, 428);
            this.bt_705.Name = "bt_705";
            this.bt_705.Size = new System.Drawing.Size(75, 49);
            this.bt_705.TabIndex = 4;
            this.bt_705.Text = "705";
            this.bt_705.UseVisualStyleBackColor = true;
            // 
            // bt_trc
            // 
            this.bt_trc.Location = new System.Drawing.Point(492, 428);
            this.bt_trc.Name = "bt_trc";
            this.bt_trc.Size = new System.Drawing.Size(75, 49);
            this.bt_trc.TabIndex = 5;
            this.bt_trc.Text = "TRC";
            this.bt_trc.UseVisualStyleBackColor = true;
            // 
            // bt_thr
            // 
            this.bt_thr.Location = new System.Drawing.Point(756, 428);
            this.bt_thr.Name = "bt_thr";
            this.bt_thr.Size = new System.Drawing.Size(75, 49);
            this.bt_thr.TabIndex = 6;
            this.bt_thr.Text = "THR";
            this.bt_thr.UseVisualStyleBackColor = true;
            this.bt_thr.Click += new System.EventHandler(this.bt_thr_Click);
            // 
            // 主窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1491, 806);
            this.Controls.Add(bt_b2b);
            this.Controls.Add(this.bt_thr);
            this.Controls.Add(this.bt_trc);
            this.Controls.Add(this.bt_705);
            this.MaximizeBox = false;
            this.Name = "主窗体";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.主窗体_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.主窗体_FormClosed);
            this.Load += new System.EventHandler(this.主窗体_Load);
            this.Click += new System.EventHandler(this.主窗体_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_705;
        private System.Windows.Forms.Button bt_trc;
        private System.Windows.Forms.Button bt_thr;
    }
}

