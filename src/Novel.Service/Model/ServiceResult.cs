namespace Novel.Service.Model
{
    /// <summary>
    ///     类名称：ServiceResult
    ///     命名空间：DaiShu.Crm.Wechat.Model.Service
    ///     类功能：服务返回值类
    /// </summary>
    /// <typeparam name="TType">泛型对象</typeparam>
    /// 创建者：周超
    /// 创建日期：2015/2/26 16:24
    /// 修改者：
    /// 修改时间：
    /// ----------------------------------------------------------------------------------------
    public class ServiceResult<TType> : DefaultServicesResult
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
        public TType Result { get; set; }
    }
}



