using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Novel.Service.Model;
using Novel.Service.Model.Parameter;

namespace Novel.Service.IService
{
    /// <summary>
    /// 接口名称：INovelService
    /// 命名空间：Novel.Service.IService
    /// 接口功能：小说服务
    /// </summary>
    /// 创建者：史鹏飞
    /// 创建日期：2016/8/19 15:37
    /// 修改者：
    /// 修改时间：
    /// ----------------------------------------------------------------------------------------
    public interface INovelService
    {
        /// <summary>
        /// 获得小说列表
        /// </summary>
        /// <returns>
        /// 小说列表
        /// </returns>
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:45
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        ServiceResultList<Model.Novel> GetNovelList(GetNovelListParameter parameter);

        /// <summary>
        /// 保存小说
        /// </summary>
        /// <returns>
        /// 是否成功
        /// </returns>
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:46
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        ServiceResult<bool> SaveNovel(SaveNovelParameter parameter);
    }
}
