//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace GameFramework.DataTable
{
    /// <summary>
    /// 数据表接口。
    /// </summary>
    /// <typeparam name="T">数据表行的类型。</typeparam>
    public interface IDataTable<T> : IEnumerable<T> where T : IDataRow
    {
        /// <summary>
        /// 获取数据表名称。
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// 获取数据表完整名称。
        /// </summary>
        string FullName
        {
            get;
        }

        /// <summary>
        /// 获取数据表行的类型。
        /// </summary>
        Type Type
        {
            get;
        }

        /// <summary>
        /// 获取数据表行数。
        /// </summary>
        int Count
        {
            get;
        }

        /// <summary>
        /// 获取数据表行。
        /// </summary>
        /// <param name="id">数据表行的编号。</param>
        /// <returns>数据表行。</returns>
        T this[int id]
        {
            get;
        }

        /// <summary>
        /// 获取编号最小的数据表行。
        /// </summary>
        T MinIdDataRowT
        {
            get;
        }

        /// <summary>
        /// 获取编号最大的数据表行。
        /// </summary>
        T MaxIdDataRowT
        {
            get;
        }

        /// <summary>
        /// 检查是否存在数据表行。
        /// </summary>
        /// <param name="id">数据表行的编号。</param>
        /// <returns>是否存在数据表行。</returns>
        bool HasDataRow(int id);

        /// <summary>
        /// 检查是否存在数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>是否存在数据表行。</returns>
        bool HasDataRow(Predicate<T> condition);

        /// <summary>
        /// 获取数据表行。
        /// </summary>
        /// <param name="id">数据表行的编号。</param>
        /// <returns>数据表行。</returns>
        T GetDataRowT(int id);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>符合条件的数据表行。</returns>
        /// <remarks>当存在多个符合条件的数据表行时，仅返回第一个符合条件的数据表行。</remarks>
        T GetDataRow(Predicate<T> condition);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>符合条件的数据表行。</returns>
        T[] GetDataRows(Predicate<T> condition);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="results">符合条件的数据表行。</param>
        void GetDataRows(Predicate<T> condition, List<T> results);

        /// <summary>
        /// 获取排序后的数据表行。
        /// </summary>
        /// <param name="comparison">要排序的条件。</param>
        /// <returns>排序后的数据表行。</returns>
        T[] GetDataRows(Comparison<T> comparison);

        /// <summary>
        /// 获取排序后的数据表行。
        /// </summary>
        /// <param name="comparison">要排序的条件。</param>
        /// <param name="results">排序后的数据表行。</param>
        void GetDataRows(Comparison<T> comparison, List<T> results);

        /// <summary>
        /// 获取排序后的符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="comparison">要排序的条件。</param>
        /// <returns>排序后的符合条件的数据表行。</returns>
        T[] GetDataRows(Predicate<T> condition, Comparison<T> comparison);

        /// <summary>
        /// 获取排序后的符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="comparison">要排序的条件。</param>
        /// <param name="results">排序后的符合条件的数据表行。</param>
        void GetDataRows(Predicate<T> condition, Comparison<T> comparison, List<T> results);

        /// <summary>
        /// 获取所有数据表行。
        /// </summary>
        /// <returns>所有数据表行。</returns>
        T[] GetAllDataRowsT();

        /// <summary>
        /// 获取所有数据表行。
        /// </summary>
        /// <param name="results">所有数据表行。</param>
        void GetAllDataRows(List<T> results);

        /// <summary>
        /// 增加数据表行。
        /// </summary>
        /// <param name="dataRowSegment">要解析的数据表行片段。</param>
        /// <param name="dataTableUserData">数据表用户自定义数据。</param>
        /// <returns>是否增加数据表行成功。</returns>
        bool AddDataRow(GameFrameworkDataSegment dataRowSegment, object dataTableUserData);

        /// <summary>
        /// 移除指定数据表行。
        /// </summary>
        /// <param name="id">要移除数据表行的编号。</param>
        /// <returns>是否移除数据表行成功。</returns>
        bool RemoveDataRow(int id);

        /// <summary>
        /// 清空所有数据表行。
        /// </summary>
        void RemoveAllDataRows();
    }


    /// <summary>
    /// 数据表接口。
    /// </summary>
    public interface IDataTable
    {
        /// <summary>
        /// 获取数据表名称。
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// 获取数据表完整名称。
        /// </summary>
        string FullName
        {
            get;
        }

        /// <summary>
        /// 获取数据表行的类型。
        /// </summary>
        Type Type
        {
            get;
        }

        /// <summary>
        /// 获取数据表行数。
        /// </summary>
        int Count
        {
            get;
        }

        /// <summary>
        /// 获取编号最小的数据表行。
        /// </summary>
        IDataRow MinIdDataRow
        {
            get;
        }

        /// <summary>
        /// 获取编号最大的数据表行。
        /// </summary>
        IDataRow MaxIdDataRow
        {
            get;
        }

        /// <summary>
        /// 检查是否存在数据表行。
        /// </summary>
        /// <param name="id">数据表行的编号。</param>
        /// <returns>是否存在数据表行。</returns>
        bool HasDataRow(int id);

        /// <summary>
        /// 检查是否存在数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>是否存在数据表行。</returns>
        bool HasDataRow(Predicate<IDataRow> condition);

        /// <summary>
        /// 获取数据表行。
        /// </summary>
        /// <param name="id">数据表行的编号。</param>
        /// <returns>数据表行。</returns>
        IDataRow GetDataRow(int id);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>符合条件的数据表行。</returns>
        /// <remarks>当存在多个符合条件的数据表行时，仅返回第一个符合条件的数据表行。</remarks>
        IDataRow GetDataRow(Predicate<IDataRow> condition);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <returns>符合条件的数据表行。</returns>
        IDataRow[] GetDataRows(Predicate<IDataRow> condition);

        /// <summary>
        /// 获取符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="results">符合条件的数据表行。</param>
        void GetDataRows(Predicate<IDataRow> condition, List<IDataRow> results);

        /// <summary>
        /// 获取排序后的数据表行。
        /// </summary>
        /// <param name="comparison">要排序的条件。</param>
        /// <returns>排序后的数据表行。</returns>
        IDataRow[] GetDataRows(Comparison<IDataRow> comparison);

        /// <summary>
        /// 获取排序后的数据表行。
        /// </summary>
        /// <param name="comparison">要排序的条件。</param>
        /// <param name="results">排序后的数据表行。</param>
        void GetDataRows(Comparison<IDataRow> comparison, List<IDataRow> results);

        /// <summary>
        /// 获取排序后的符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="comparison">要排序的条件。</param>
        /// <returns>排序后的符合条件的数据表行。</returns>
        IDataRow[] GetDataRows(Predicate<IDataRow> condition, Comparison<IDataRow> comparison);

        /// <summary>
        /// 获取排序后的符合条件的数据表行。
        /// </summary>
        /// <param name="condition">要检查的条件。</param>
        /// <param name="comparison">要排序的条件。</param>
        /// <param name="results">排序后的符合条件的数据表行。</param>
        void GetDataRows(Predicate<IDataRow> condition, Comparison<IDataRow> comparison, List<IDataRow> results);

        /// <summary>
        /// 获取所有数据表行。
        /// </summary>
        /// <returns>所有数据表行。</returns>
        IDataRow[] GetAllDataRows();

        /// <summary>
        /// 获取所有数据表行。
        /// </summary>
        /// <param name="results">所有数据表行。</param>
        void GetAllDataRows(List<IDataRow> results);

    }
}
