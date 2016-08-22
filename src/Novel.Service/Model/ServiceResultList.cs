using System.Collections.Generic;

namespace Novel.Service.Model
{
    /// <summary>
    ///     类名称：ServiceResultList
    ///     命名空间：DaiShu.Crm.Wechat.Model.Service
    ///     类功能：服务返回值类
    /// </summary>
    /// <typeparam name="TType">泛型对象类型</typeparam>
    /// 创建者：周超
    /// 创建日期：2015/2/26 16:25
    /// 修改者：
    /// 修改时间：
    /// ----------------------------------------------------------------------------------------
    public class ServiceResultList<TType> : DefaultServicesResult
    {
        /// <summary>
        ///     设置或取得返回值
        /// </summary>
        /// <value>
        ///     返回值
        /// </value>
        /// 创建者：周超
        /// 创建日期：6/21/2014 1:22 PM
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public List<TType> Result { get; set; }

        /// <summary>
        ///     设置或取得总条数
        /// </summary>
        /// <value>
        ///     总条数
        /// </value>
        /// 创建者：周超
        /// 创建日期：6/21/2014 1:22 PM
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public int Count { get; set; }
    }
}



