﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novel.Service.Model
{
    /// <summary>
    /// 类名称：Novel
    /// 命名空间：Novel.Service.Model
    /// 类功能：小说
    /// </summary>
    /// 创建者：史鹏飞
    /// 创建日期：2016/8/19 18:28
    /// 修改者：
    /// 修改时间：
    /// ----------------------------------------------------------------------------------------
    public class Novel
    {
        /// <summary>
        /// 设置或取得 小说Id
        /// </summary>
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:30
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public int Id { get; set; }

        /// <summary>
        /// 设置或取得 小说名称
        /// </summary>
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:30
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public string Name { get; set; }
    }
}
