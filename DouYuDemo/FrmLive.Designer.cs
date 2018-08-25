namespace DouYuDemo
{
    partial class FrmLive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLive));
            this.lstLives = new System.Windows.Forms.ListBox();
            this.lblroom_id = new System.Windows.Forms.Label();
            this.txtroom_id = new System.Windows.Forms.TextBox();
            this.txtroom_name = new System.Windows.Forms.TextBox();
            this.lblroom_name = new System.Windows.Forms.Label();
            this.txtowner_uid = new System.Windows.Forms.TextBox();
            this.lblowner_uid = new System.Windows.Forms.Label();
            this.txthn = new System.Windows.Forms.TextBox();
            this.lblhn = new System.Windows.Forms.Label();
            this.txtnickname = new System.Windows.Forms.TextBox();
            this.lblnickname = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.picroom_src = new System.Windows.Forms.PictureBox();
            this.lblOffset = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblroom_src = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picroom_src)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLives
            // 
            this.lstLives.FormattingEnabled = true;
            this.lstLives.ItemHeight = 12;
            this.lstLives.Location = new System.Drawing.Point(14, 50);
            this.lstLives.Name = "lstLives";
            this.lstLives.Size = new System.Drawing.Size(222, 364);
            this.lstLives.TabIndex = 0;
            this.lstLives.SelectedIndexChanged += new System.EventHandler(this.lstLives_SelectedIndexChanged);
            // 
            // lblroom_id
            // 
            this.lblroom_id.AutoSize = true;
            this.lblroom_id.Location = new System.Drawing.Point(272, 247);
            this.lblroom_id.Name = "lblroom_id";
            this.lblroom_id.Size = new System.Drawing.Size(41, 12);
            this.lblroom_id.TabIndex = 1;
            this.lblroom_id.Text = "房间ID";
            // 
            // txtroom_id
            // 
            this.txtroom_id.Location = new System.Drawing.Point(398, 243);
            this.txtroom_id.Name = "txtroom_id";
            this.txtroom_id.ReadOnly = true;
            this.txtroom_id.Size = new System.Drawing.Size(196, 21);
            this.txtroom_id.TabIndex = 2;
            // 
            // txtroom_name
            // 
            this.txtroom_name.Location = new System.Drawing.Point(398, 271);
            this.txtroom_name.Name = "txtroom_name";
            this.txtroom_name.ReadOnly = true;
            this.txtroom_name.Size = new System.Drawing.Size(196, 21);
            this.txtroom_name.TabIndex = 4;
            // 
            // lblroom_name
            // 
            this.lblroom_name.AutoSize = true;
            this.lblroom_name.Location = new System.Drawing.Point(272, 275);
            this.lblroom_name.Name = "lblroom_name";
            this.lblroom_name.Size = new System.Drawing.Size(53, 12);
            this.lblroom_name.TabIndex = 3;
            this.lblroom_name.Text = "房间名称";
            // 
            // txtowner_uid
            // 
            this.txtowner_uid.Location = new System.Drawing.Point(398, 299);
            this.txtowner_uid.Name = "txtowner_uid";
            this.txtowner_uid.ReadOnly = true;
            this.txtowner_uid.Size = new System.Drawing.Size(196, 21);
            this.txtowner_uid.TabIndex = 6;
            // 
            // lblowner_uid
            // 
            this.lblowner_uid.AutoSize = true;
            this.lblowner_uid.Location = new System.Drawing.Point(272, 303);
            this.lblowner_uid.Name = "lblowner_uid";
            this.lblowner_uid.Size = new System.Drawing.Size(107, 12);
            this.lblowner_uid.TabIndex = 5;
            this.lblowner_uid.Text = "房间所属用户的UID";
            // 
            // txthn
            // 
            this.txthn.Location = new System.Drawing.Point(398, 327);
            this.txthn.Name = "txthn";
            this.txthn.ReadOnly = true;
            this.txthn.Size = new System.Drawing.Size(196, 21);
            this.txthn.TabIndex = 8;
            // 
            // lblhn
            // 
            this.lblhn.AutoSize = true;
            this.lblhn.Location = new System.Drawing.Point(272, 331);
            this.lblhn.Name = "lblhn";
            this.lblhn.Size = new System.Drawing.Size(65, 12);
            this.lblhn.TabIndex = 7;
            this.lblhn.Text = "在线热度值";
            // 
            // txtnickname
            // 
            this.txtnickname.Location = new System.Drawing.Point(398, 355);
            this.txtnickname.Name = "txtnickname";
            this.txtnickname.ReadOnly = true;
            this.txtnickname.Size = new System.Drawing.Size(196, 21);
            this.txtnickname.TabIndex = 10;
            // 
            // lblnickname
            // 
            this.lblnickname.AutoSize = true;
            this.lblnickname.Location = new System.Drawing.Point(272, 359);
            this.lblnickname.Name = "lblnickname";
            this.lblnickname.Size = new System.Drawing.Size(113, 12);
            this.lblnickname.TabIndex = 9;
            this.lblnickname.Text = "房间所属用户的账号";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(398, 383);
            this.txturl.Name = "txturl";
            this.txturl.ReadOnly = true;
            this.txturl.Size = new System.Drawing.Size(196, 21);
            this.txturl.TabIndex = 12;
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Location = new System.Drawing.Point(272, 387);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(65, 12);
            this.lblurl.TabIndex = 11;
            this.lblurl.Text = "房间的网址";
            // 
            // picroom_src
            // 
            this.picroom_src.Location = new System.Drawing.Point(274, 50);
            this.picroom_src.Name = "picroom_src";
            this.picroom_src.Size = new System.Drawing.Size(320, 180);
            this.picroom_src.TabIndex = 13;
            this.picroom_src.TabStop = false;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(18, 26);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(41, 12);
            this.lblOffset.TabIndex = 14;
            this.lblOffset.Text = "第一页";
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(81, 21);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 15;
            this.btnPre.Text = "上一页";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(160, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblroom_src
            // 
            this.lblroom_src.AutoSize = true;
            this.lblroom_src.Location = new System.Drawing.Point(274, 26);
            this.lblroom_src.Name = "lblroom_src";
            this.lblroom_src.Size = new System.Drawing.Size(53, 12);
            this.lblroom_src.TabIndex = 17;
            this.lblroom_src.Text = "房间图片";
            // 
            // FrmLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 421);
            this.Controls.Add(this.lblroom_src);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.picroom_src);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.txtnickname);
            this.Controls.Add(this.lblnickname);
            this.Controls.Add(this.txthn);
            this.Controls.Add(this.lblhn);
            this.Controls.Add(this.txtowner_uid);
            this.Controls.Add(this.lblowner_uid);
            this.Controls.Add(this.txtroom_name);
            this.Controls.Add(this.lblroom_name);
            this.Controls.Add(this.txtroom_id);
            this.Controls.Add(this.lblroom_id);
            this.Controls.Add(this.lstLives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "获取房间列表";
            this.Load += new System.EventHandler(this.FrmLive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picroom_src)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLives;
        private System.Windows.Forms.Label lblroom_id;
        private System.Windows.Forms.TextBox txtroom_id;
        private System.Windows.Forms.TextBox txtroom_name;
        private System.Windows.Forms.Label lblroom_name;
        private System.Windows.Forms.TextBox txtowner_uid;
        private System.Windows.Forms.Label lblowner_uid;
        private System.Windows.Forms.TextBox txthn;
        private System.Windows.Forms.Label lblhn;
        private System.Windows.Forms.TextBox txtnickname;
        private System.Windows.Forms.Label lblnickname;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.PictureBox picroom_src;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblroom_src;
    }
}