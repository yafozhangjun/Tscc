using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace Xlinktscc.Models
{
    public class SqlOperat
    {
        private string constr = "UID=sa;Password=tsccdb;Initial Catalog=TsccDB;Data Source=192.168.4.105";

        SqlConnection sqlConn;

        /// <summary>
        /// 查询数据库
        /// </summary>
        /// <param name="sqlstring"></param>
        /// <returns></returns>
        public DataSet SelectFromDataSet(string sqlstring)
        {
            sqlConn = new SqlConnection(constr);
            SqlCommand sqlCom = new SqlCommand(sqlstring, sqlConn); //数据库操作指令

            SqlDataAdapter adapter = new SqlDataAdapter();//定义一个数据适配器
            adapter.SelectCommand = sqlCom;

            DataSet dataset = new DataSet();
            try
            {
                sqlConn.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                //sqlConn.Close();
                CloseConnec();
                adapter.Fill(dataset);
                return dataset;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="insertCommand"></param>
        public void InsertToDataSet(string insertCommand)
        {
            sqlConn = new SqlConnection(constr);
            SqlCommand sqlCom = new SqlCommand(insertCommand, sqlConn);
            try
            {
                sqlConn.Open();
                sqlCom.ExecuteNonQuery();
                sqlConn.Close();
                // CloseConnec();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="updateCommand"></param>
        public void UpdateDataSet(string updateCommand)
        {
            sqlConn = new SqlConnection(constr);
            SqlCommand sqlCom = new SqlCommand(updateCommand, sqlConn);
            try
            {
                sqlConn.Open();
                sqlCom.ExecuteNonQuery();
                //sqlConn.Close();
                CloseConnec();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="deleteCommand"></param>
        public void DeleteDateSet(string deleteCommand)
        {
            sqlConn = new SqlConnection(constr);
            SqlCommand sqlCom = new SqlCommand(deleteCommand, sqlConn);
            try
            {
                sqlConn.Open();
                sqlCom.ExecuteNonQuery();
                //sqlConn.Close();
                CloseConnec();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CloseConnec()
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }
    }
}