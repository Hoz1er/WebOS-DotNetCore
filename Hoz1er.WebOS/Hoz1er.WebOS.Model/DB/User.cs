using Hoz1er.WebOS.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoz1er.WebOS.Model.DB
{
    [Table("user")]
    public class User
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public string ID { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedTime { get; set; }
        /// <summary>
        /// 更新人ID
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdatedTime { get; set; }
        /// <summary>
        /// 用户名（登录名）
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public EnumYesNo Enabled { get; set; }
        /// <summary>
        /// 盐值
        /// </summary>
        public string Salt { get; set; }

        public User()
        {
            this.ID = string.Empty;
            this.Version = string.Empty;
            this.CreatedBy = string.Empty;
            this.UpdatedBy = string.Empty;
            this.Username = string.Empty;
            this.Nickname = string.Empty;
            this.Enabled = EnumYesNo.No;
            this.Salt = string.Empty;
        }
    }
}
