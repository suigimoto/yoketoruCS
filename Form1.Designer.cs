namespace yoketoruCS
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelgameover = new System.Windows.Forms.Label();
            this.buttontitle = new System.Windows.Forms.Button();
            this.labelclear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Location = new System.Drawing.Point(90, 90);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(56, 12);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "よけとるCS";
            this.labeltitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(350, 220);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 60);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelgameover
            // 
            this.labelgameover.AutoSize = true;
            this.labelgameover.Location = new System.Drawing.Point(364, 183);
            this.labelgameover.Name = "labelgameover";
            this.labelgameover.Size = new System.Drawing.Size(72, 12);
            this.labelgameover.TabIndex = 2;
            this.labelgameover.Text = "GAME OVER";
            // 
            // buttontitle
            // 
            this.buttontitle.Location = new System.Drawing.Point(363, 328);
            this.buttontitle.Name = "buttontitle";
            this.buttontitle.Size = new System.Drawing.Size(75, 23);
            this.buttontitle.TabIndex = 3;
            this.buttontitle.Text = "タイトルへ";
            this.buttontitle.UseVisualStyleBackColor = true;
            this.buttontitle.Click += new System.EventHandler(this.buttontitle_Click);
            // 
            // labelclear
            // 
            this.labelclear.AutoSize = true;
            this.labelclear.Location = new System.Drawing.Point(364, 183);
            this.labelclear.Name = "labelclear";
            this.labelclear.Size = new System.Drawing.Size(68, 12);
            this.labelclear.TabIndex = 4;
            this.labelclear.Text = "GAME Clear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelclear);
            this.Controls.Add(this.buttontitle);
            this.Controls.Add(this.labelgameover);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labeltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelgameover;
        private System.Windows.Forms.Button buttontitle;
        private System.Windows.Forms.Label labelclear;
    }
}

