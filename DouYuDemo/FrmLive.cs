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
using Newtonsoft.Json;

namespace DouYuDemo
{
    public partial class FrmLive : Form
    {
        private StCloud stCloud = new StCloud();
        private int offset = 0;
        public FrmLive()
        {
            InitializeComponent();
        }
        private void LoadLive(int offset = 0, int limit = 30)
        {
            this.lblOffset.Text = $"第{offset + 1}页";
            this.lstLives.Items.Clear();
            JObject json = this.stCloud.Get($"RoomApi/live?offset={offset}&limit={limit}");
            if (json.Value<int>("error") == 0)
            {
                JArray jdata = json.Value<JArray>("data");
                List<RoomApiLiveModel> lst = JsonConvert.DeserializeObject<List<RoomApiLiveModel>>(jdata.ToString());
                lst.ForEach(item =>
                {
                    this.lstLives.Items.Add(item);
                });
                this.lstLives.SelectedIndex = 0;
            }
        }
        private void FrmLive_Load(object sender, EventArgs e)
        {
            this.LoadLive();
        }

        private void lstLives_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomApiLiveModel live = this.lstLives.SelectedItem as RoomApiLiveModel;
            if(live != null)
            {
                this.txthn.Text = live.hn.ToString();
                this.txtnickname.Text = live.nickname;
                this.txtowner_uid.Text = live.owner_uid;
                this.txtroom_id.Text = live.room_id.ToString();
                this.txtroom_name.Text = live.room_name;
                this.txturl.Text = live.url;
                this.picroom_src.ImageLocation = live.room_src;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(this.offset > 0)
            {
                this.offset -= 1;
                this.LoadLive(this.offset);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.offset += 1;
            this.LoadLive(this.offset);
        }
    }
}
