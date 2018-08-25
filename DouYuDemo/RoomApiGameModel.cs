using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouYuDemo
{
    /// <summary>
    /// 游戏分类
    /// </summary>
    public class RoomApiGameModel
    {
        /// <summary>
        /// 游戏分类ID
        /// </summary>
        public int cate_id { get; set; }
        /// <summary>
        /// 游戏分类的名称
        /// </summary>
        public string game_name { get; set; }
        /// <summary>
        /// 游戏分类的别名
        /// </summary>
        public string short_name { get; set; }
        /// <summary>
        /// 游戏分类的网址
        /// </summary>
        public string game_url { get; set; }
        /// <summary>
        /// 游戏分类的封面图片,大小140*195
        /// </summary>
        public string game_src { get; set; }
        /// <summary>
        /// 游戏分类的小图标图片,大小16*16
        /// </summary>
        public string game_icon { get; set; }
        public override string ToString()
        {
            return this.game_name;
        }
    }
}
