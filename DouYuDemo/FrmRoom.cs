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
    public partial class FrmRoom : Form
    {
        private StCloud stCloud = new StCloud();
        public FrmRoom()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string id = this.txtRoomId.Text;
            string api = $"RoomApi/room/{id}";
            JObject json = this.stCloud.Get(api);
            if(json.Value<int>("error") == 0)
            {
                JObject jdata = json.Value<JObject>("data");
                RoomApiRoomModel roomApiRoomModel = JsonConvert.DeserializeObject<RoomApiRoomModel>(jdata.ToString());
                this.picroom_thumb.ImageLocation = roomApiRoomModel.room_thumb;
                this.txtcate_name.Text = roomApiRoomModel.cate_name;
                this.txtroom_name.Text = roomApiRoomModel.room_name;
                this.txtroom_status.Text = roomApiRoomModel.room_status == "1" ? "开播":"关播";
                this.txtstart_time.Text = roomApiRoomModel.start_time;
                this.txtowner_name.Text = roomApiRoomModel.owner_name;
                this.picavatar.ImageLocation = roomApiRoomModel.avatar;
                this.txthn.Text = roomApiRoomModel.hn.ToString();
                this.txtowner_weight.Text = roomApiRoomModel.owner_weight;
                this.txtfans_num.Text = roomApiRoomModel.fans_num;
            }
        }

        private void FrmRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
