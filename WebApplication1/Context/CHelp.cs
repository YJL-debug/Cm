using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using Dapper;
using System.Data.SqlClient;
namespace WebApplication1.Context
{
    public class CHelp<T>where T:new()
    {
        /// <summary>
        /// 添加SQL语句
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private string SQLinsert (T t)
        {
            Type ty = typeof(T);
            string SQLName = ty.Name;

            PropertyInfo Key = ty.GetProperties().Where(s => s.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();//获取主键
            string keyname = Key.Name;
            string filename = string.Join(",", ty.GetProperties().Where(s => s.Name != keyname).Select(s => s.Name));
            string filevalues = string.Join(",", ty.GetProperties().Where(s => s.Name != keyname).Select(s =>  "'"+s.GetValue(ty)+"'"));
            string sql = $"insert into Guanlikaosi({filename}) values({filevalues})";
            return sql;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(T t)
        {
            try
            {
                string sql = SQLinsert(t);
                int n = DaperExute(sql);
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// 修改SQL语句
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private string SQLUpdate(T t)
        {
            Type ty = typeof(T);
            string SQLName = ty.Name;

            PropertyInfo Key = ty.GetProperties().Where(s => s.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();//获取主键
            string keyname = Key.Name;
            string keyvalues = Key.GetValue(ty).ToString();
            string filevalues = string.Join(",", ty.GetProperties().Where(s => s.Name != keyname).Select(s =>s.Name+"="+ "'" + s.GetValue(ty) + "'"));
            string sql = $"update Guanlikaosi set {filevalues} where Id={keyvalues}";
            return sql;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(T t)
        {
            try
            {
                string sql = SQLUpdate(t);
                int n = DaperExute(sql);
                return n;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int DaperExute(string sql)
        {
            using (SqlConnection conn=new SqlConnection("Data Source=.;Initial Catalog=WeekTwo;Integrated Security=True"))
            {
                int n = conn.Execute(sql);
                return n;   
            }
        }


    }
}