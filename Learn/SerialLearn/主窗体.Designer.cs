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
            this.SuspendLayout();
            // 
            // 主窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1491, 806);
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
    }
}

