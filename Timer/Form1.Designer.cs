namespace Timer
{
    partial class Timer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.SecondsBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AboutButton = new System.Windows.Forms.Button();
            this.MinutesBox = new System.Windows.Forms.TextBox();
            this.Colon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("STXihei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(0, 234);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(578, 40);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SecondsBox
            // 
            this.SecondsBox.BackColor = System.Drawing.Color.ForestGreen;
            this.SecondsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondsBox.Font = new System.Drawing.Font("STXihei", 140.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SecondsBox.ForeColor = System.Drawing.Color.Transparent;
            this.SecondsBox.Location = new System.Drawing.Point(313, 46);
            this.SecondsBox.MaxLength = 2;
            this.SecondsBox.Name = "SecondsBox";
            this.SecondsBox.Size = new System.Drawing.Size(231, 258);
            this.SecondsBox.TabIndex = 1;
            this.SecondsBox.Text = "00";
            this.SecondsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondsBox.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AboutButton
            // 
            this.AboutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("STXihei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(0, 0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(578, 40);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "北京信息科技大学";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MinutesBox
            // 
            this.MinutesBox.BackColor = System.Drawing.Color.ForestGreen;
            this.MinutesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinutesBox.Font = new System.Drawing.Font("STXihei", 140.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinutesBox.ForeColor = System.Drawing.Color.Transparent;
            this.MinutesBox.Location = new System.Drawing.Point(0, 46);
            this.MinutesBox.MaxLength = 2;
            this.MinutesBox.Name = "MinutesBox";
            this.MinutesBox.Size = new System.Drawing.Size(258, 258);
            this.MinutesBox.TabIndex = 3;
            this.MinutesBox.Text = "00";
            this.MinutesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinutesBox.WordWrap = false;
            // 
            // Colon
            // 
            this.Colon.AutoSize = true;
            this.Colon.Font = new System.Drawing.Font("STXihei", 140.25F, System.Drawing.FontStyle.Bold);
            this.Colon.ForeColor = System.Drawing.Color.White;
            this.Colon.Location = new System.Drawing.Point(231, 29);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(138, 202);
            this.Colon.TabIndex = 4;
            this.Colon.Text = ":";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(578, 274);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MinutesBox);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.SecondsBox);
            this.Controls.Add(this.Colon);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox SecondsBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.TextBox MinutesBox;
        private System.Windows.Forms.Label Colon;
    }
}

