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
    public partial class FrmGame : Form
    {
        private StCloud stCloud = new StCloud();
        public FrmGame()
        {
            InitializeComponent();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            JObject json = this.stCloud.Get("RoomApi/game");   
            if(json.Value<int>("error") == 0)
            {
                JArray jdata = json.Value<JArray>("data");
                List<RoomApiGameModel> lst = JsonConvert.DeserializeObject<List<RoomApiGameModel>>(jdata.ToString());
                lst.ForEach(item => {
                    this.lstGames.Items.Add(item);
                });
                this.lstGames.SelectedIndex = 3;
            }
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtQuery.Text))
            {
                string query = this.txtQuery.Text;
                foreach (RoomApiGameModel game in this.lstGames.Items)
                {
                    if (game.game_name.Contains(query))
                    {
                        this.lstGames.SelectedItem = game;
                        break;
                    }
                }
            }
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomApiGameModel game = this.lstGames.SelectedItem as RoomApiGameModel;
            if(game != null)
            {
                this.txtcate_id.Text = game.cate_id.ToString();
                this.txtgame_name.Text = game.game_name;
                this.txtshort_name.Text = game.short_name;
                this.txtgame_url.Text = game.game_url;
                this.picgame_src.ImageLocation = game.game_src;
                this.txtQuery.Text = game.game_name;
            }
        }
    }
}
