namespace DouYuDemo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnGame = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnLive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(28, 35);
            this.btnGame.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(141, 38);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "所有游戏分类";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(175, 35);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(141, 38);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "房间列表";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnLive
            // 
            this.btnLive.Location = new System.Drawing.Point(322, 35);
            this.btnLive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(141, 38);
            this.btnLive.TabIndex = 2;
            this.btnLive.Text = "直播房间";
            this.btnLive.UseVisualStyleBackColor = true;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 96);
            this.Controls.Add(this.btnLive);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnGame);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "斗鱼第三方开放平台2.2示例";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnLive;
    }
}

