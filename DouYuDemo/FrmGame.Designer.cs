namespace DouYuDemo
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.lstGames = new System.Windows.Forms.ListBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblcate_id = new System.Windows.Forms.Label();
            this.lblgame_name = new System.Windows.Forms.Label();
            this.txtcate_id = new System.Windows.Forms.TextBox();
            this.txtgame_name = new System.Windows.Forms.TextBox();
            this.txtshort_name = new System.Windows.Forms.TextBox();
            this.lblshort_name = new System.Windows.Forms.Label();
            this.txtgame_url = new System.Windows.Forms.TextBox();
            this.lblgame_url = new System.Windows.Forms.Label();
            this.picgame_src = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picgame_src)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstGames.FormattingEnabled = true;
            this.lstGames.ItemHeight = 20;
            this.lstGames.Location = new System.Drawing.Point(10, 52);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(176, 604);
            this.lstGames.TabIndex = 0;
            this.lstGames.SelectedIndexChanged += new System.EventHandler(this.lstGames_SelectedIndexChanged);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(10, 15);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(176, 21);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // lblcate_id
            // 
            this.lblcate_id.AutoSize = true;
            this.lblcate_id.Location = new System.Drawing.Point(197, 19);
            this.lblcate_id.Name = "lblcate_id";
            this.lblcate_id.Size = new System.Drawing.Size(71, 12);
            this.lblcate_id.TabIndex = 2;
            this.lblcate_id.Text = "游戏分类ID:";
            // 
            // lblgame_name
            // 
            this.lblgame_name.AutoSize = true;
            this.lblgame_name.Location = new System.Drawing.Point(197, 82);
            this.lblgame_name.Name = "lblgame_name";
            this.lblgame_name.Size = new System.Drawing.Size(95, 12);
            this.lblgame_name.TabIndex = 3;
            this.lblgame_name.Text = "游戏分类的名称:";
            // 
            // txtcate_id
            // 
            this.txtcate_id.Location = new System.Drawing.Point(197, 46);
            this.txtcate_id.Name = "txtcate_id";
            this.txtcate_id.ReadOnly = true;
            this.txtcate_id.Size = new System.Drawing.Size(320, 21);
            this.txtcate_id.TabIndex = 4;
            // 
            // txtgame_name
            // 
            this.txtgame_name.Location = new System.Drawing.Point(197, 109);
            this.txtgame_name.Name = "txtgame_name";
            this.txtgame_name.ReadOnly = true;
            this.txtgame_name.Size = new System.Drawing.Size(320, 21);
            this.txtgame_name.TabIndex = 5;
            // 
            // txtshort_name
            // 
            this.txtshort_name.Location = new System.Drawing.Point(197, 172);
            this.txtshort_name.Name = "txtshort_name";
            this.txtshort_name.ReadOnly = true;
            this.txtshort_name.Size = new System.Drawing.Size(320, 21);
            this.txtshort_name.TabIndex = 7;
            // 
            // lblshort_name
            // 
            this.lblshort_name.AutoSize = true;
            this.lblshort_name.Location = new System.Drawing.Point(197, 145);
            this.lblshort_name.Name = "lblshort_name";
            this.lblshort_name.Size = new System.Drawing.Size(95, 12);
            this.lblshort_name.TabIndex = 6;
            this.lblshort_name.Text = "游戏分类的别名:";
            // 
            // txtgame_url
            // 
            this.txtgame_url.Location = new System.Drawing.Point(197, 235);
            this.txtgame_url.Name = "txtgame_url";
            this.txtgame_url.ReadOnly = true;
            this.txtgame_url.Size = new System.Drawing.Size(320, 21);
            this.txtgame_url.TabIndex = 9;
            // 
            // lblgame_url
            // 
            this.lblgame_url.AutoSize = true;
            this.lblgame_url.Location = new System.Drawing.Point(197, 208);
            this.lblgame_url.Name = "lblgame_url";
            this.lblgame_url.Size = new System.Drawing.Size(95, 12);
            this.lblgame_url.TabIndex = 8;
            this.lblgame_url.Text = "游戏分类的网址:";
            // 
            // picgame_src
            // 
            this.picgame_src.Location = new System.Drawing.Point(530, 46);
            this.picgame_src.Name = "picgame_src";
            this.picgame_src.Size = new System.Drawing.Size(440, 610);
            this.picgame_src.TabIndex = 10;
            this.picgame_src.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "游戏分类的封面:";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picgame_src);
            this.Controls.Add(this.txtgame_url);
            this.Controls.Add(this.lblgame_url);
            this.Controls.Add(this.txtshort_name);
            this.Controls.Add(this.lblshort_name);
            this.Controls.Add(this.txtgame_name);
            this.Controls.Add(this.txtcate_id);
            this.Controls.Add(this.lblgame_name);
            this.Controls.Add(this.lblcate_id);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lstGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "所有游戏分类";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picgame_src)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblcate_id;
        private System.Windows.Forms.Label lblgame_name;
        private System.Windows.Forms.TextBox txtcate_id;
        private System.Windows.Forms.TextBox txtgame_name;
        private System.Windows.Forms.TextBox txtshort_name;
        private System.Windows.Forms.Label lblshort_name;
        private System.Windows.Forms.TextBox txtgame_url;
        private System.Windows.Forms.Label lblgame_url;
        private System.Windows.Forms.PictureBox picgame_src;
        private System.Windows.Forms.Label label1;
    }
}