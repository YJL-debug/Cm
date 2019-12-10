using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// 选项类型
    /// </summary>
    public class XuanType
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id              { get; set; }
        /// <summary>
        /// 选项名称
        /// </summary>
        public string XuanTypeName { get; set; }
    }
}