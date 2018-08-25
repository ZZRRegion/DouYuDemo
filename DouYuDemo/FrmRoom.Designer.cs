namespace DouYuDemo
{
    partial class FrmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoom));
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picroom_thumb = new System.Windows.Forms.PictureBox();
            this.lblRoomPic = new System.Windows.Forms.Label();
            this.lblcate_name = new System.Windows.Forms.Label();
            this.txtcate_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtroom_name = new System.Windows.Forms.TextBox();
            this.lblroom_status = new System.Windows.Forms.Label();
            this.txtroom_status = new System.Windows.Forms.TextBox();
            this.lblstart_time = new System.Windows.Forms.Label();
            this.txtstart_time = new System.Windows.Forms.TextBox();
            this.lblowner_name = new System.Windows.Forms.Label();
            this.txtowner_name = new System.Windows.Forms.TextBox();
            this.lblavatar = new System.Windows.Forms.Label();
            this.picavatar = new System.Windows.Forms.PictureBox();
            this.txthn = new System.Windows.Forms.TextBox();
            this.lblhn = new System.Windows.Forms.Label();
            this.txtowner_weight = new System.Windows.Forms.TextBox();
            this.lblowner_weight = new System.Windows.Forms.Label();
            this.txtfans_num = new System.Windows.Forms.TextBox();
            this.lblfans_num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picroom_thumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picavatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(125, 16);
            this.txtRoomId.MaxLength = 20;
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(220, 21);
            this.txtRoomId.TabIndex = 0;
            this.txtRoomId.Text = "99999";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(351, 14);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "获取";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "房间号:";
            // 
            // picroom_thumb
            // 
            this.picroom_thumb.Location = new System.Drawing.Point(466, 38);
            this.picroom_thumb.Name = "picroom_thumb";
            this.picroom_thumb.Size = new System.Drawing.Size(320, 180);
            this.picroom_thumb.TabIndex = 4;
            this.picroom_thumb.TabStop = false;
            // 
            // lblRoomPic
            // 
            this.lblRoomPic.AutoSize = true;
            this.lblRoomPic.Location = new System.Drawing.Point(466, 14);
            this.lblRoomPic.Name = "lblRoomPic";
            this.lblRoomPic.Size = new System.Drawing.Size(59, 12);
            this.lblRoomPic.TabIndex = 5;
            this.lblRoomPic.Text = "房间图片:";
            // 
            // lblcate_name
            // 
            this.lblcate_name.AutoSize = true;
            this.lblcate_name.Location = new System.Drawing.Point(12, 63);
            this.lblcate_name.Name = "lblcate_name";
            this.lblcate_name.Size = new System.Drawing.Size(107, 12);
            this.lblcate_name.TabIndex = 6;
            this.lblcate_name.Text = "房间所属分类名称:";
            // 
            // txtcate_name
            // 
            this.txtcate_name.Location = new System.Drawing.Point(125, 59);
            this.txtcate_name.Name = "txtcate_name";
            this.txtcate_name.ReadOnly = true;
            this.txtcate_name.Size = new System.Drawing.Size(220, 21);
            this.txtcate_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "房间名称:";
            // 
            // txtroom_name
            // 
            this.txtroom_name.Location = new System.Drawing.Point(125, 102);
            this.txtroom_name.Name = "txtroom_name";
            this.txtroom_name.ReadOnly = true;
            this.txtroom_name.Size = new System.Drawing.Size(220, 21);
            this.txtroom_name.TabIndex = 9;
            // 
            // lblroom_status
            // 
            this.lblroom_status.AutoSize = true;
            this.lblroom_status.Location = new System.Drawing.Point(12, 149);
            this.lblroom_status.Name = "lblroom_status";
            this.lblroom_status.Size = new System.Drawing.Size(83, 12);
            this.lblroom_status.TabIndex = 10;
            this.lblroom_status.Text = "房间开播状态:";
            // 
            // txtroom_status
            // 
            this.txtroom_status.Location = new System.Drawing.Point(127, 145);
            this.txtroom_status.Name = "txtroom_status";
            this.txtroom_status.ReadOnly = true;
            this.txtroom_status.Size = new System.Drawing.Size(220, 21);
            this.txtroom_status.TabIndex = 11;
            // 
            // lblstart_time
            // 
            this.lblstart_time.AutoSize = true;
            this.lblstart_time.Location = new System.Drawing.Point(12, 192);
            this.lblstart_time.Name = "lblstart_time";
            this.lblstart_time.Size = new System.Drawing.Size(83, 12);
            this.lblstart_time.TabIndex = 12;
            this.lblstart_time.Text = "最近开播时间:";
            // 
            // txtstart_time
            // 
            this.txtstart_time.Location = new System.Drawing.Point(127, 188);
            this.txtstart_time.Name = "txtstart_time";
            this.txtstart_time.ReadOnly = true;
            this.txtstart_time.Size = new System.Drawing.Size(220, 21);
            this.txtstart_time.TabIndex = 13;
            // 
            // lblowner_name
            // 
            this.lblowner_name.AutoSize = true;
            this.lblowner_name.Location = new System.Drawing.Point(12, 235);
            this.lblowner_name.Name = "lblowner_name";
            this.lblowner_name.Size = new System.Drawing.Size(107, 12);
            this.lblowner_name.TabIndex = 14;
            this.lblowner_name.Text = "房间所属主播昵称:";
            // 
            // txtowner_name
            // 
            this.txtowner_name.Location = new System.Drawing.Point(127, 231);
            this.txtowner_name.Name = "txtowner_name";
            this.txtowner_name.ReadOnly = true;
            this.txtowner_name.Size = new System.Drawing.Size(220, 21);
            this.txtowner_name.TabIndex = 15;
            // 
            // lblavatar
            // 
            this.lblavatar.AutoSize = true;
            this.lblavatar.Location = new System.Drawing.Point(466, 227);
            this.lblavatar.Name = "lblavatar";
            this.lblavatar.Size = new System.Drawing.Size(107, 12);
            this.lblavatar.TabIndex = 17;
            this.lblavatar.Text = "房间所属主播头像:";
            // 
            // picavatar
            // 
            this.picavatar.Location = new System.Drawing.Point(466, 247);
            this.picavatar.Name = "picavatar";
            this.picavatar.Size = new System.Drawing.Size(205, 200);
            this.picavatar.TabIndex = 16;
            this.picavatar.TabStop = false;
            // 
            // txthn
            // 
            this.txthn.Location = new System.Drawing.Point(127, 274);
            this.txthn.Name = "txthn";
            this.txthn.ReadOnly = true;
            this.txthn.Size = new System.Drawing.Size(220, 21);
            this.txthn.TabIndex = 19;
            // 
            // lblhn
            // 
            this.lblhn.AutoSize = true;
            this.lblhn.Location = new System.Drawing.Point(12, 278);
            this.lblhn.Name = "lblhn";
            this.lblhn.Size = new System.Drawing.Size(35, 12);
            this.lblhn.TabIndex = 18;
            this.lblhn.Text = "热度:";
            // 
            // txtowner_weight
            // 
            this.txtowner_weight.Location = new System.Drawing.Point(127, 317);
            this.txtowner_weight.Name = "txtowner_weight";
            this.txtowner_weight.ReadOnly = true;
            this.txtowner_weight.Size = new System.Drawing.Size(220, 21);
            this.txtowner_weight.TabIndex = 21;
            // 
            // lblowner_weight
            // 
            this.lblowner_weight.AutoSize = true;
            this.lblowner_weight.Location = new System.Drawing.Point(12, 321);
            this.lblowner_weight.Name = "lblowner_weight";
            this.lblowner_weight.Size = new System.Drawing.Size(59, 12);
            this.lblowner_weight.TabIndex = 20;
            this.lblowner_weight.Text = "主播体重:";
            // 
            // txtfans_num
            // 
            this.txtfans_num.Location = new System.Drawing.Point(127, 360);
            this.txtfans_num.Name = "txtfans_num";
            this.txtfans_num.ReadOnly = true;
            this.txtfans_num.Size = new System.Drawing.Size(220, 21);
            this.txtfans_num.TabIndex = 23;
            // 
            // lblfans_num
            // 
            this.lblfans_num.AutoSize = true;
            this.lblfans_num.Location = new System.Drawing.Point(12, 364);
            this.lblfans_num.Name = "lblfans_num";
            this.lblfans_num.Size = new System.Drawing.Size(83, 12);
            this.lblfans_num.TabIndex = 22;
            this.lblfans_num.Text = "直播间关注数:";
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.txtfans_num);
            this.Controls.Add(this.lblfans_num);
            this.Controls.Add(this.txtowner_weight);
            this.Controls.Add(this.lblowner_weight);
            this.Controls.Add(this.txthn);
            this.Controls.Add(this.lblhn);
            this.Controls.Add(this.lblavatar);
            this.Controls.Add(this.picavatar);
            this.Controls.Add(this.txtowner_name);
            this.Controls.Add(this.lblowner_name);
            this.Controls.Add(this.txtstart_time);
            this.Controls.Add(this.lblstart_time);
            this.Controls.Add(this.txtroom_status);
            this.Controls.Add(this.lblroom_status);
            this.Controls.Add(this.txtroom_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcate_name);
            this.Controls.Add(this.lblcate_name);
            this.Controls.Add(this.lblRoomPic);
            this.Controls.Add(this.picroom_thumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtRoomId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "获取直播房间详情信息";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picroom_thumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picavatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picroom_thumb;
        private System.Windows.Forms.Label lblRoomPic;
        private System.Windows.Forms.Label lblcate_name;
        private System.Windows.Forms.TextBox txtcate_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtroom_name;
        private System.Windows.Forms.Label lblroom_status;
        private System.Windows.Forms.TextBox txtroom_status;
        private System.Windows.Forms.Label lblstart_time;
        private System.Windows.Forms.TextBox txtstart_time;
        private System.Windows.Forms.Label lblowner_name;
        private System.Windows.Forms.TextBox txtowner_name;
        private System.Windows.Forms.Label lblavatar;
        private System.Windows.Forms.PictureBox picavatar;
        private System.Windows.Forms.TextBox txthn;
        private System.Windows.Forms.Label lblhn;
        private System.Windows.Forms.TextBox txtowner_weight;
        private System.Windows.Forms.Label lblowner_weight;
        private System.Windows.Forms.TextBox txtfans_num;
        private System.Windows.Forms.Label lblfans_num;
    }
}