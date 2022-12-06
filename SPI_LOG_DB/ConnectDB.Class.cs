using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SPI_LOG_DB
{
    class ConnectDB
    {
        public SqlConnection ConnectionDB()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string Server = appSettings.Get("Server");
            string DataBase = appSettings.Get("DBNane");
            string User = appSettings.Get("User");
            string PW = appSettings.Get("PW");
            string PoolSize = appSettings.Get("PoolSize");
            string Timeout = appSettings.Get("Timeout");

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=" + Server + ";"
                            + "Initial Catalog=" + DataBase + ";"
                            + "User ID=" + User + ";"
                            + "Password=" + PW + ";"
                            + "Max Pool Size=" + PoolSize + ";"
                            + "Connect Timeout=" + Timeout + ";";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
        public string MAIN_SPI_INS(string Barcode, string DateStart, string DateEnd, string InspTime, string Status, string MC)
        {
            try
            {
                SqlConnection cnn = ConnectionDB();
                SqlCommand objCmd = new SqlCommand();
                SqlDataAdapter dtAdapter = new SqlDataAdapter();

                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                string Result;
                using (cnn)
                {
                    strStored = "MAIN_SPI_INS";
                    objCmd.Parameters.Add(new SqlParameter("@Barcode", Barcode));
                    objCmd.Parameters.Add(new SqlParameter("@DateStart", DateStart));
                    objCmd.Parameters.Add(new SqlParameter("@DateEnd", DateEnd));
                    objCmd.Parameters.Add(new SqlParameter("@InspTime", InspTime));
                    objCmd.Parameters.Add(new SqlParameter("@Status", Status));
                    objCmd.Parameters.Add(new SqlParameter("@MC", MC));

                    objCmd.Connection = cnn;
                    objCmd.CommandText = strStored;
                    objCmd.CommandType = CommandType.StoredProcedure;

                    dtAdapter.SelectCommand = objCmd;

                    dtAdapter.Fill(ds);
                    dt = ds.Tables[0];

                    try
                    {
                        Result = dt.Rows[0]["result"].ToString();
                        return Result;
                    }
                    catch
                    {
                        Result = "SQL Error";
                        return Result;
                    }
                }
            }
            catch (SqlException e)
            {
                string Result = e.ToString();
                return Result;
            }
        }
        public string MAIN_SPI_INS_DETAIL
            (string Barcode
            , string PadNo
            , string ComponentID
            , string PadResult
            , string PositionX
            , string PositionY
            , string OffsetX
            , string OffsetY
            , string Area
            , string AreaUpper
            , string AreaLower
            , string Volume
            , string VolumeUpper
            , string VolumeLower
            , string Height
            , string HeightUpper
            , string HeightLower
            , string BridgeHeight
            , string BridgeDistance
            , string InspectionDateTime 
            )
        {
            try
            {
                SqlConnection cnn = ConnectionDB();
                SqlCommand objCmd = new SqlCommand();
                SqlDataAdapter dtAdapter = new SqlDataAdapter();

                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                string Result;
                using (cnn)
                {
                    strStored = "MAIN_SPI_INS_DETAIL";
                    objCmd.Parameters.Add(new SqlParameter("@Barcode", Barcode));
                    objCmd.Parameters.Add(new SqlParameter("@PadNo", PadNo));
                    objCmd.Parameters.Add(new SqlParameter("@ComponentID", ComponentID));
                    objCmd.Parameters.Add(new SqlParameter("@PadResult", PadResult));
                    objCmd.Parameters.Add(new SqlParameter("@PositionX", PositionX));
                    objCmd.Parameters.Add(new SqlParameter("@PositionY", PositionY));
                    objCmd.Parameters.Add(new SqlParameter("@OffsetX", OffsetX));
                    objCmd.Parameters.Add(new SqlParameter("@OffsetY", OffsetY));
                    objCmd.Parameters.Add(new SqlParameter("@Area", Area));
                    objCmd.Parameters.Add(new SqlParameter("@AreaUpper", AreaUpper));
                    objCmd.Parameters.Add(new SqlParameter("@AreaLower", AreaLower));
                    objCmd.Parameters.Add(new SqlParameter("@Volume", Volume));
                    objCmd.Parameters.Add(new SqlParameter("@VolumeUpper", VolumeUpper));
                    objCmd.Parameters.Add(new SqlParameter("@VolumeLower", VolumeLower));
                    objCmd.Parameters.Add(new SqlParameter("@Height", Height));
                    objCmd.Parameters.Add(new SqlParameter("@HeightUpper", HeightUpper));
                    objCmd.Parameters.Add(new SqlParameter("@HeightLower", HeightLower));
                    objCmd.Parameters.Add(new SqlParameter("@BridgeHeight", BridgeHeight));
                    objCmd.Parameters.Add(new SqlParameter("@BridgeDistance", BridgeDistance));
                    objCmd.Parameters.Add(new SqlParameter("@InspectionDateTime", InspectionDateTime));

                    objCmd.Connection = cnn;
                    objCmd.CommandText = strStored;
                    objCmd.CommandType = CommandType.StoredProcedure;

                    dtAdapter.SelectCommand = objCmd;

                    dtAdapter.Fill(ds);
                    dt = ds.Tables[0];

                    try
                    {
                        Result = dt.Rows[0]["result"].ToString();
                        return Result;
                    }
                    catch
                    {
                        Result = "SQL Error";
                        return Result;
                    }
                }
            }
            catch (SqlException e)
            {
                string Result = e.ToString();
                return Result;
            }
        }
        private void SPI_LOG()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string SQL_SP = appSettings.Get("SQL_SP");
            int StatusSQL;
            using (SqlConnection cnn = ConnectionDB())
            {
                string strStored;
                //TextBox.CheckForIllegalCrossThreadCalls = false;
                strStored = SQL_SP;
                using (SqlCommand cmd = new SqlCommand())
                {
                    //lbResult.Text = ("");
                    cnn.Open();
                    try
                    {
                        cmd.CommandText = strStored;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = cnn;
                        int rowsAffected = cmd.ExecuteNonQuery();
                        StatusSQL = 1;
                    }
                    catch
                    {
                        StatusSQL = 0;
                    }
                    cnn.Close();
                }
            }
        }
    }
}
