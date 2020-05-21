//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace GameFramework.DataTable
{
    /// <summary>
    /// 数据表基类。
    /// </summary>
    public abstract class DataTableBase : IDataTable
    {
        private readonly string m_Name;

        /// <summary>
        /// 初始化数据表基类的新实例。
        /// </summary>
        public DataTableBase()
            : this(null)
        {
        }

        /// <summary>
        /// 初始化数据表基类的新实例。
        /// </summary>
        /// <param name="name">数据表名称。</param>
        public DataTableBase(string name)
        {
            m_Name = name ?? string.Empty;
        }



        /// <summary>
        /// 获取数据表名称。
        /// </summary>
        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        /// <summary>
        /// 获取数据表完整名称。
        /// </summary>
        public string FullName
        {
            get
            {
                return new TypeNamePair(Type, m_Name).ToString();
            }
        }

        /// <summary>
        /// 获取数据表行的类型。
        /// </summary>
        public abstract Type Type
        {
            get;
        }

        /// <summary>
        /// 获取数据表行数。
        /// </summary>
        public abstract int Count
        {
            get;
        }

        /// <summary>
        /// 获取编号最小的数据表行。
        /// </summary>
        public abstract IDataRow MinIdDataRow
        {
            get;
        }

        /// <summary>
        /// 获取编号最大的数据表行。
        /// </summary>
        public abstract IDataRow MaxIdDataRow
        {
            get;
        }

        /// <summary>
        /// 检查是否存在数据表行。
        /// </summary>
        /// <param name="id">数据表行的编号。</param>
        /// <returns>是否存在数据表行。</returns>
        public abstract bool HasDataRow(int id);

        /// <summary>
        /// 检查是否存在数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>是否存在数据表行。</returns>
        public abstract bool HasDataRow(Predicate<IDataRow> condition);

        /// <summary>
        /// 获取数据表行。
        /// </summary>
        /// <param name="id">数据表行的编号。</param>
        /// <returns>数据表行。</returns>
        public abstract IDataRow GetDataRow(int id);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>符合条件的数据表行。</returns>
        /// <remarks>当存在多个符合条件的数据表行时，仅返回第一个符合条件的数据表行。</remarks>
        public abstract IDataRow GetDataRow(Predicate<IDataRow> condition);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>符合条件的数据表行。</returns>
        public abstract IDataRow[] GetDataRows(Predicate<IDataRow> condition);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="results">符合条件的数据表行。</param>
        public abstract void GetDataRows(Predicate<IDataRow> condition, List<IDataRow> results);

        /// <summary>
        /// 获取排序后的数据表行。
        /// </summary>
        /// <param name="comparison">要排序的条件。</param>
        /// <returns>排序后的数据表行。</returns>
        public abstract IDataRow[] GetDataRows(Comparison<IDataRow> comparison);

        /// <summary>
        /// 获取排序后的数据表行。
        /// </summary>
        /// <param name="comparison">要排序的条件。</param>
        /// <param name="results">排序后的数据表行。</param>
        public abstract void GetDataRows(Comparison<IDataRow> comparison, List<IDataRow> results);

        /// <summary>
        /// 获取排序后的符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="comparison">要排序的条件。</param>
        /// <returns>排序后的符合条件的数据表行。</returns>
        public abstract IDataRow[] GetDataRows(Predicate<IDataRow> condition, Comparison<IDataRow> comparison);

        /// <summary>
        /// 获取排序后的符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="comparison">要排序的条件。</param>
        /// <param name="results">排序后的符合条件的数据表行。</param>
        public abstract void GetDataRows(Predicate<IDataRow> condition, Comparison<IDataRow> comparison, List<IDataRow> results);

        /// <summary>
        /// 获取所有数据表行。
        /// </summary>
        /// <returns>所有数据表行。</returns>
        public abstract IDataRow[] GetAllDataRows();

        /// <summary>
        /// 获取所有数据表行。
        /// </summary>
        /// <param name="results">所有数据表行。</param>
        public abstract void GetAllDataRows(List<IDataRow> results);


        /// <summary>
        /// 增加数据表行。
        /// </summary>
        /// <param name="dataRowSegment">要解析的数据表行片段。</param>
        /// <param name="dataTableUserData">数据表用户自定义数据。</param>
        /// <returns>是否增加数据表行成功。</returns>
        public abstract bool AddDataRow(GameFrameworkDataSegment dataRowSegment, object dataTableUserData);

        /// <summary>
        /// 关闭并清理数据表。
        /// </summary>
        internal abstract void Shutdown();
    }
}
