using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Novel.Service.IService;
using Novel.Service.Model;
using Novel.Service.Model.Parameter;
using Novel.Utility;
using Dapper;

namespace Novel.Service.Service
{
    /// <summary>
    /// 类名称：NovelService
    /// 命名空间：Novel.Service.Service
    /// 类功能： 小说服务
    /// </summary>
    /// 创建者：史鹏飞
    /// 创建日期：2016/8/19 15:38
    /// 修改者：
    /// 修改时间：
    /// ----------------------------------------------------------------------------------------  
    public class NovelService:INovelService
    {   
        /// <summary>
        /// 获得小说列表
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>
        /// 小说列表
        /// </returns>
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:50
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:45
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public ServiceResultList<Model.Novel> GetNovelList(GetNovelListParameter parameter)
        {
            string sqlStr = @"select Id,Name from novels";
            using (var connection = DbUtility.GetConnection())
            {
                var list = connection.Query<Model.Novel>(sqlStr).ToList();
                return new ServiceResultList<Model.Novel>
                {
                    Result = list,
                };
            }
        }

        /// <summary>
        /// 保存小说
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>
        /// 是否成功
        /// </returns>
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:50
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        /// 创建者：史鹏飞
        /// 创建日期：2016/8/19 18:46
        /// 修改者：
        /// 修改时间：
        /// ----------------------------------------------------------------------------------------
        public ServiceResult<bool> SaveNovel(SaveNovelParameter parameter)
        {
            return null;
        }
    }
}
