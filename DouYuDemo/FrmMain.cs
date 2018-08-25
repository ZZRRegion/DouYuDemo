using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DouYuDemo
{
    public partial class FrmMain : Form
    {
        private StCloud stCloud = new StCloud();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            JObject json = this.stCloud.Get("RoomApi/room/1630847");
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            FrmGame frmGame = new FrmGame();
            if(frmGame.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            FrmRoom frmRoom = new FrmRoom();
            if(frmRoom.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            FrmLive frmLive = new FrmLive();
            if(frmLive.ShowDialog(this) == DialogResult.OK)
            {

            }
        }
    }
}
