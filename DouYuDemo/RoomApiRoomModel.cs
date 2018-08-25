using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouYuDemo
{
    /// <summary>
    /// 房间详细信息
    /// </summary>
    public class RoomApiRoomModel
    {
        /// <summary>
        /// 房间号ID
        /// </summary>
        public string room_id { get; set; }
        /// <summary>
        /// 房间图片,大小320*180
        /// </summary>
        public string room_thumb { get; set; }
        /// <summary>
        /// 房间所属分类ID
        /// </summary>
        public string cate_id { get; set; }
        /// <summary>
        /// 房间所属分类名称(英雄联盟)
        /// </summary>
        public string cate_name { get; set; }
        /// <summary>
        /// 房间名称
        /// </summary>
        public string room_name { get; set; }
        /// <summary>
        /// 房间开播状态:1表示开播,2表示关播
        /// </summary>
        public string room_status { get; set; }
        /// <summary>
        /// 最近开播时间
        /// </summary>
        public string start_time { get; set; }
        /// <summary>
        /// 房间所属主播昵称
        /// </summary>
        public string owner_name { get; set; }
        /// <summary>
        /// 房间所属主播头像地址
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 原人气字段,现在与热度值同步
        /// </summary>
        public int online { get; set; }
        /// <summary>
        /// 在线热度值
        /// </summary>
        public int hn { get; set; }
        /// <summary>
        /// 直播间主播体重
        /// </summary>
        public string owner_weight { get; set; }
        /// <summary>
        /// 直播间关注数
        /// </summary>
        public string fans_num { get; set; }
        /// <summary>
        /// 直播间礼物信息数组列表
        /// </summary>
        public List<GiftModel> gift { get; set; }
    }
    public class GiftModel
    {
        /// <summary>
        /// 礼物ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 礼物名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 礼物类型:1鱼丸礼物,2鱼翅礼物
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 价格:鱼翅礼物(元)/鱼丸礼物(鱼丸)
        /// </summary>
        public float pc { get; set; }
        /// <summary>
        /// 贡献值
        /// </summary>
        public int gx { get; set; }
        /// <summary>
        /// 礼物描述
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 礼物介绍
        /// </summary>
        public string intro { get; set; }
        /// <summary>
        /// 礼物图标静态图片地址
        /// </summary>
        public string mimg { get; set; }
        /// <summary>
        /// 礼物图标动态图片地址
        /// </summary>
        public string himg { get; set; }
    }
}
