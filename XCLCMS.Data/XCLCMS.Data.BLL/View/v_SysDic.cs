﻿using System.Collections.Generic;

namespace XCLCMS.Data.BLL.View
{
    public class v_SysDic
    {
        private readonly XCLCMS.Data.DAL.View.v_SysDic dal = new XCLCMS.Data.DAL.View.v_SysDic();

        public v_SysDic()
        { }

        #region BasicMethod

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XCLCMS.Data.Model.View.v_SysDic GetModel(long SysDicID)
        {
            return dal.GetModel(SysDicID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XCLCMS.Data.Model.View.v_SysDic> GetModelList(string strWhere)
        {
            return dal.GetModelList(strWhere);
        }

        #endregion BasicMethod

        #region ExtensionMethod

        /// <summary>
        /// 根据parentID返回列表
        /// </summary>
        public List<XCLCMS.Data.Model.View.v_SysDic> GetList(long parentID)
        {
            return dal.GetList(parentID);
        }

        /// <summary>
        /// 递归获取指定code下的所有列表
        /// </summary>
        public List<XCLCMS.Data.Model.View.v_SysDic> GetAllUnderListByCode(string code)
        {
            return dal.GetAllUnderListByCode(code);
        }

        #endregion ExtensionMethod
    }
}