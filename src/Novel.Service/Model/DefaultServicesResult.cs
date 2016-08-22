﻿namespace Novel.Service.Model
{
    /// <summary>
    ///     类名称：DefaultServicesResult
    ///     命名空间：DaiShu.Crm.Wechat.Model.Service
    ///     类功能：服务返回值基类
    /// </summary>
    /// 创建者：周超
    /// 创建日期：2015/2/26 16:24
    /// 修改者：
    /// 修改时间：
    /// ----------------------------------------------------------------------------------------
    public class DefaultServicesResult
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DefaultServicesResult" /> class.
        /// </summary>
        /// 创建者：周超
        /// 创建日期：2015/2/28 16:08
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public DefaultServicesResult()
        {
            this.State = true;
        }

        /// <summary>
        ///     设置或取得请求状态（true 正常，false 异常）
        /// </summary>
        /// <value>
        ///     请求状态（true 正常，false 异常）
        /// </value>
        /// 创建者：周超
        /// 创建日期：6/21/2014 1:22 PM
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public bool State { get; set; }

        /// <summary>
        ///     设置或取得错误码
        /// </summary>
        /// <value>
        ///     错误码
        /// </value>
        /// 创建者：周超
        /// 创建日期：6/21/2014 1:20 PM
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public string Code { get; set; }

        /// <summary>
        ///     设置或取得错误信息
        /// </summary>
        /// <value>
        ///     错误信息
        /// </value>
        /// 创建者：周超
        /// 创建日期：6/21/2014 1:20 PM
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public string Messge { get; set; }

        /// <summary>
        ///     设置或取得附加数据
        /// </summary>
        /// <value>
        ///     附加数据
        /// </value>
        /// 创建者：周超
        /// 创建日期：6/21/2014 1:20 PM
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public string ExtraData { get; set; }
    }
}


