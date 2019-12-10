using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// 题库
    /// </summary>
    public class Tiku
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id        { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public int TiName    { get; set; }
        /// <summary>
        /// 选项类型
        /// </summary>
        public string XuanTypeid{ get; set; }
        /// <summary>
        /// 选项A
        /// </summary>
        public string XuanA     { get; set; }
        /// <summary>
        /// 选项B
        /// </summary>
        public string XuanB     { get; set; }
        /// <summary>
        /// 选项C
        /// </summary>
        public string XuanC     { get; set; }
        /// <summary>
        /// 选项D
        /// </summary>
        public string XuanD     { get; set; }
        /// <summary>
        /// 答案
        /// </summary>
        public string Daan      { get; set; }
        /// <summary>
        /// 选项名称
        /// </summary>
        public string XuanTypeName { get; set; }
        

    }
}