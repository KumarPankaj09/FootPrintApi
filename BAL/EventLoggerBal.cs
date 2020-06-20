using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootPrintApi.BAL
{
    public class EventLoggerBal
    {
        public bool InsertEvent(EventLogger eventLogger)
        {
            try
            {
                new FootPrintApi.DAL.EventLoggerDal().InsertEvent(eventLogger);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public List<EventLogger> GetEvents(EventLogger eventLogger)
        {
            try
            {
                return new FootPrintApi.DAL.EventLoggerDal().GetEvents(eventLogger);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}