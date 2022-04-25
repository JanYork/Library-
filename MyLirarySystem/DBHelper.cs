using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyLirarySystem
{
    /// <summary>
    /// 数据库辅助类
    /// </summary>
    static class DBHelper
    {

        #region 封装连接对象
        //连接字符串
        private const string STR = @"Data Source=Huawei-MateBook;Initial Catalog=MyLibrary;Integrated Security=True";

        /// <summary>
        /// 封装连接对象
        /// </summary>
        private static SqlConnection connection;
        public static SqlConnection Connection
        {
            get
            { 
                if(connection == null)
                {
                    connection = new SqlConnection(STR);
                }
                return connection; 
            }
        }
        #endregion

        #region 打开数据库
        /// <summary>
        /// 打开数据库操作
        /// </summary>
        public static void ConnectionOpen()
        {
            if(Connection.State == ConnectionState.Closed)
            {
                //打开数据库
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }
        #endregion 

        #region 关闭数据库
        /// <summary>
        /// 关闭数据库操作
        /// </summary>
        public static void ConnectionClose()
        { 
            if(Connection.State != ConnectionState.Closed)
            {
                //关闭数据库
                Connection.Close();
            }
        }
        #endregion 

        #region ExecuteScalar()方法
        /// <summary>
        /// 查询单个值ExecuteScalar()
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>第一行第一列</returns>
        public static object ExecuteScalar(string sql)
        {
            try
            {
                //创建Command对象
                using (SqlCommand comm = new SqlCommand(sql, Connection))
                {
                    //打开数据库
                    if (Connection.State != ConnectionState.Open)
                    {
                        Connection.Close();
                        Connection.Open();
                    }

                    //执行
                    return comm.ExecuteScalar();
                }
            }
            catch(Exception ex)
            {
                //查询异常
                return -1;
            }
            finally
            { 
                if(Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }
        #endregion

        #region ExecuteNonQuery()方法
        /// <summary>
        /// 增、删、、改操作
        /// </summary>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand(sql, Connection))
                {
                    //打开数据库
                    if (Connection.State != ConnectionState.Open)
                    {
                        Connection.Close();
                        Connection.Open();
                    }

                    //执行
                    return comm.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                //异常
                return -1;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }
        #endregion

        #region ExecuteReader()方法
        /// <summary>
        /// 查询多行多列
        /// </summary>
        /// <returns>SQLDataReader对象</returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                //创建Command对象
                using (SqlCommand comm = new SqlCommand(sql, Connection))
                {
                    //打开数据库
                    if (Connection.State != ConnectionState.Open)
                    {
                        Connection.Close();
                        Connection.Open();
                    }

                    //执行
                    return comm.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                //查询异常
                return null;
            }
        }
        #endregion
    }
}
