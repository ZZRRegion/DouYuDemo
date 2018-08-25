using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouYuDemo
{
    public class RoomApiLiveModel
    {
        /// <summary>
        /// 房间ID
        /// </summary>
        public int room_id { get; set; }
        /// <summary>
        /// 房间图片,大小320*180
        /// </summary>
        public string room_src { get; set; }
        /// <summary>
        /// 房间名称
        /// </summary>
        public string room_name { get; set; }
        /// <summary>
        /// 房间所属用户的UID
        /// </summary>
        public string owner_uid { get; set; }
        /// <summary>
        /// 原人气字段,现在与热度值同步
        /// </summary>
        public int online { get; set; }
        /// <summary>
        /// 在线热度值
        /// </summary>
        public int hn { get; set; }
        /// <summary>
        /// 房间所属用户的账号
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 房间的网址
        /// </summary>
        public string url { get; set; }
        public override string ToString()
        {
            return this.room_name;
        }
    }
}
