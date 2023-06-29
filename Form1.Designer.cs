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
            this.labelhighscore = new System.Windows.Forms.Label();
            this.labelscore = new System.Windows.Forms.Label();
            this.labelplayer = new System.Windows.Forms.Label();
            this.labeltimer = new System.Windows.Forms.Label();
            this.labelcopylight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.labeltitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labeltitle.Location = new System.Drawing.Point(345, 136);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(111, 24);
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
            this.labelgameover.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelgameover.Location = new System.Drawing.Point(305, 183);
            this.labelgameover.Name = "labelgameover";
            this.labelgameover.Size = new System.Drawing.Size(190, 33);
            this.labelgameover.TabIndex = 2;
            this.labelgameover.Text = "GAME OVER";
            // 
            // buttontitle
            // 
            this.buttontitle.Location = new System.Drawing.Point(361, 239);
            this.buttontitle.Name = "buttontitle";
            this.buttontitle.Size = new System.Drawing.Size(75, 23);
            this.buttontitle.TabIndex = 3;
            this.buttontitle.Text = "タイトルへ";
            this.buttontitle.UseVisualStyleBackColor = true;
            this.buttontitle.Click += new System.EventHandler(this.buttontitle_Click);
            // 
            // labelclear
            // 
            this.labelclear.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelclear.Location = new System.Drawing.Point(355, 182);
            this.labelclear.Name = "labelclear";
            this.labelclear.Size = new System.Drawing.Size(90, 34);
            this.labelclear.TabIndex = 4;
            this.labelclear.Text = "Clear";
            this.labelclear.Click += new System.EventHandler(this.labelclear_Click);
            // 
            // labelhighscore
            // 
            this.labelhighscore.AutoSize = true;
            this.labelhighscore.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelhighscore.Location = new System.Drawing.Point(294, 54);
            this.labelhighscore.Name = "labelhighscore";
            this.labelhighscore.Size = new System.Drawing.Size(219, 27);
            this.labelhighscore.TabIndex = 5;
            this.labelhighscore.Text = "High Score: 00000";
            // 
            // labelscore
            // 
            this.labelscore.AutoSize = true;
            this.labelscore.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelscore.Location = new System.Drawing.Point(357, 17);
            this.labelscore.Name = "labelscore";
            this.labelscore.Size = new System.Drawing.Size(93, 37);
            this.labelscore.TabIndex = 6;
            this.labelscore.Text = "0000";
            // 
            // labelplayer
            // 
            this.labelplayer.AutoSize = true;
            this.labelplayer.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelplayer.Location = new System.Drawing.Point(96, 313);
            this.labelplayer.Name = "labelplayer";
            this.labelplayer.Size = new System.Drawing.Size(81, 29);
            this.labelplayer.TabIndex = 7;
            this.labelplayer.Text = "( ;∀;)";
            // 
            // labeltimer
            // 
            this.labeltimer.AutoSize = true;
            this.labeltimer.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labeltimer.Location = new System.Drawing.Point(721, 412);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(58, 29);
            this.labeltimer.TabIndex = 8;
            this.labeltimer.Text = "000";
            // 
            // labelcopylight
            // 
            this.labelcopylight.AutoSize = true;
            this.labelcopylight.Location = new System.Drawing.Point(341, 427);
            this.labelcopylight.Name = "labelcopylight";
            this.labelcopylight.Size = new System.Drawing.Size(119, 12);
            this.labelcopylight.TabIndex = 9;
            this.labelcopylight.Text = "(C) 2023 すぎもとなおき";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(406, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "◇";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(341, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "★";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcopylight);
            this.Controls.Add(this.labeltimer);
            this.Controls.Add(this.labelplayer);
            this.Controls.Add(this.labelscore);
            this.Controls.Add(this.labelhighscore);
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
        private System.Windows.Forms.Label labelhighscore;
        private System.Windows.Forms.Label labelscore;
        private System.Windows.Forms.Label labelplayer;
        private System.Windows.Forms.Label labeltimer;
        private System.Windows.Forms.Label labelcopylight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

