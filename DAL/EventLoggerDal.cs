using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FootPrintApi.DAL
{
    public class EventLoggerDal
    {

        public bool InsertEvent(EventLogger eventLogger)
        {
            try
            {

                
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringBaseProcess"].ToString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "usp_LogEvent";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ApplicationName", eventLogger.ApplicationName);
                    cmd.Parameters.AddWithValue("@CustomerId", eventLogger.CustomerId);
                    cmd.Parameters.AddWithValue("@EventCode ", eventLogger.EventCode);
                    cmd.Parameters.AddWithValue("@EventMessage", eventLogger.EventMessage);
                    cmd.Parameters.AddWithValue("@EventType", eventLogger.EventType);
                    cmd.Parameters.AddWithValue("@FunctionName  ", eventLogger.FunctionName);
                    cmd.Parameters.AddWithValue("@Input", eventLogger.Input);
                    cmd.Parameters.AddWithValue("@Output ", eventLogger.Output);
                    cmd.Parameters.AddWithValue("@PageName", eventLogger.PageName);
                    cmd.Parameters.AddWithValue("@RefNo ", eventLogger.RefNo);
                    cmd.Parameters.AddWithValue("@Source ", eventLogger.Source);
                    cmd.Parameters.AddWithValue("@url ", eventLogger.url);
                    cmd.Parameters.AddWithValue("@IP ", eventLogger.IP);
                    cmd.Parameters.AddWithValue("@IP ", eventLogger.IsLeadIDGenerate);
                    con.Open();
                    DbDataReader dr = cmd.ExecuteReader();
                    con.Close();

                }
                 
                
                return true;
            }
            catch (Exception ex)
            {
                //throw;
                return false;
            }
        }
        public List<EventLogger> GetEvents(EventLogger eventLogger)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringBaseProcess"].ToString();
                SqlDataReader dr;
                EventLogger eventLogged = new EventLogger();
                List<EventLogger> eventLoggedList = new List<EventLogger>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "usp_GetEvents";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ApplicationName", eventLogger.ApplicationName);
                    cmd.Parameters.AddWithValue("@CustomerId", eventLogger.CustomerId);
                    cmd.Parameters.AddWithValue("@EventCode ", eventLogger.EventCode);
                    cmd.Parameters.AddWithValue("@EventMessage", eventLogger.EventMessage);
                    cmd.Parameters.AddWithValue("@EventType", eventLogger.EventType);
                    cmd.Parameters.AddWithValue("@FunctionName  ", eventLogger.FunctionName);
                    cmd.Parameters.AddWithValue("@Input", eventLogger.Input);
                    cmd.Parameters.AddWithValue("@Output ", eventLogger.Output);
                    cmd.Parameters.AddWithValue("@PageName", eventLogger.PageName);
                    cmd.Parameters.AddWithValue("@RefNo ", eventLogger.RefNo);
                    cmd.Parameters.AddWithValue("@Source ", eventLogger.Source);
                    cmd.Parameters.AddWithValue("@url ", eventLogger.url);
                    cmd.Parameters.AddWithValue("@IP ", eventLogger.IP);
                    cmd.Parameters.AddWithValue("@FromDate", eventLogger.FromDate);
                    cmd.Parameters.AddWithValue("@ToDate", eventLogger.ToDate);
                    cmd.Parameters.AddWithValue("@EventId", eventLogger.EventId);
                    cmd.Parameters.AddWithValue("@ApplicationId", eventLogger.ApplicationId);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    //DataTable dr = cmd.ExecuteReader();
                    //DataSet ds = new DataSet();
                    //da.Fill(ds);

                    
                    //ParameterList paramList = new ParameterList();// parameters to be added 
                    //paramList.Add(new SQLParameter("@ApplicationName", eventLogger.ApplicationName));
                    //paramList.Add(new SQLParameter("@CustomerId", eventLogger.CustomerId));
                    //paramList.Add(new SQLParameter("@EventCode ", eventLogger.EventCode));
                    //paramList.Add(new SQLParameter("@EventMessage", eventLogger.EventMessage));
                    //paramList.Add(new SQLParameter("@EventType", eventLogger.EventType));
                    //paramList.Add(new SQLParameter("@FunctionName  ", eventLogger.FunctionName));
                    //paramList.Add(new SQLParameter("@Input", eventLogger.Input));
                    //paramList.Add(new SQLParameter("@Output ", eventLogger.Output));
                    //paramList.Add(new SQLParameter("@PageName", eventLogger.PageName));
                    //paramList.Add(new SQLParameter("@RefNo ", eventLogger.RefNo));
                    //paramList.Add(new SQLParameter("@Source ", eventLogger.Source));
                    //paramList.Add(new SQLParameter("@IP ", eventLogger.IP));
                    //paramList.Add(new SQLParameter("@FromDate", eventLogger.FromDate));
                    //paramList.Add(new SQLParameter("@ToDate", eventLogger.ToDate));
                    //paramList.Add(new SQLParameter("@EventId", eventLogger.EventId));

                    //dr = ExecuteQuery.ExecuteReader(SQL, paramList);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            eventLogged = new EventLogger();
                            eventLogged.ApplicationName = Convert.ToString(dr["ApplicationName"]);
                            eventLogged.CustomerId = Convert.ToString(dr["CustomerId"]);
                            eventLogged.EventCode = Convert.ToString(dr["EventCode"]);
                            eventLogged.EventMessage = Convert.ToString(dr["EventMessage"]);
                            eventLogged.EventType = Convert.ToString(dr["EventType"]);
                            eventLogged.FunctionName = Convert.ToString(dr["FunctionName"]);
                            eventLogged.Input = Convert.ToString(dr["Input"]);
                            eventLogged.Output = Convert.ToString(dr["Output"]);
                            eventLogged.PageName = Convert.ToString(dr["PageName"]);
                            eventLogged.RefNo = Convert.ToString(dr["RefNo"]);
                            eventLogged.Source = Convert.ToString(dr["Source"]);
                            eventLogged.url = Convert.ToString(dr["url"]);
                            eventLogged.IP = Convert.ToString(dr["IP"]);
                            eventLogged.CreatedOn = Convert.ToString(dr["CreatedOn"]);
                            eventLogged.EventId = Convert.ToString(dr["Rowid"]);
                            eventLoggedList.Add(eventLogged);
                        }
                    }
                    con.Close();
                }
                    return eventLoggedList;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}