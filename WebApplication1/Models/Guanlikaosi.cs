using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// 在线管理考试
    /// </summary>
    public class Guanlikaosi
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id             { get; set; }
        /// <summary>
        /// 考试名称
        /// </summary>
        public string KaosiName      { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime ChuangjianTime { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime KaishiTime     { get; set; }
        /// <summary>
        /// 截至时间
        /// </summary>
        public DateTime JiezhiTime     { get; set; }
        /// <summary>
        /// 考试说明
        /// </summary>
        public string KaosiShuo      { get; set; }
        /// <summary>
        /// 答题时间
        /// </summary>
        public string DatiTime       { get; set; }
        /// <summary>
        /// 题目数量
        /// </summary>
        public int Ticount { get; set; }
        /// <summary>
        /// 考试状态
        /// </summary>
        public bool KaoState { get; set; }
        /// <summary>
        /// 添加题的编号
        /// </summary>
        public int tikuId { get; set; }
    }                    
}