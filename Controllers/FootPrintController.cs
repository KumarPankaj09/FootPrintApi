using FootPrintApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FootPrintApi.BAL;
using System.Web.Http;

namespace FootPrintApi.Controllers
{
    public class FootPrintController : ApiController
    {
        // GET: FootPrint
        public void Index()
        {
            //return View();
        }
        [HttpPost]
        [Route("api/FootPrint/InsertEvent")]
        public ResultInfo<bool> InsertEvent(EventLogger eventLogger)
        {
            ResultInfo<bool> resultInfo = new ResultInfo<bool>();
            try
            {

                resultInfo.Result = new EventLoggerBal().InsertEvent(eventLogger);
            }
            catch (Exception ex)
            {
                resultInfo.ResultCode = -1000;
                resultInfo.ResultDesc = ex.Message;
                resultInfo.ResultType = TypeOfResult.Error;
            }
            return resultInfo;

        }
        //[HttpPost]
        //[System.Web.Http.Route("api/FootPrint/GetEvents")]
        //public ResultInfo<List<EventLogger>> GetEvents(EventLogger eventLogger)
        //{
        //    ResultInfo<List<EventLogger>> resultInfo = new ResultInfo<List<EventLogger>>();
        //    try
        //    {

        //        resultInfo.Result = new EventLoggerBal().GetEvents(eventLogger);
        //    }
        //    catch (Exception ex)
        //    {
        //        resultInfo.ResultCode = -1000;
        //        resultInfo.ResultDesc = ex.Message;
        //        resultInfo.ResultType = TypeOfResult.Error;
        //    }
        //    return resultInfo;

        //}
        [HttpPost]
        [Route("api/FootPrint/GetEvents")]
        public List<EventLogger> GetEvents(EventLogger eventLogger)
        {
            ResultInfo<List<EventLogger>> resultInfo = new ResultInfo<List<EventLogger>>();
            try
            {

                resultInfo.Result = new EventLoggerBal().GetEvents(eventLogger);
            }
            catch (Exception ex)
            {
                resultInfo.ResultCode = -1000;
                resultInfo.ResultDesc = ex.Message;
                resultInfo.ResultType = TypeOfResult.Error;
            }
            return resultInfo.Result;

        }
        //[HttpPost]
        //[System.Web.Http.Route("api/FootPrint/GetEvents")]
        //public ResultInfo<List<EventLogger>> GetEvents()
        //{
        //    ResultInfo<List<EventLogger>> resultInfo = new ResultInfo<List<EventLogger>>();
        //    try
        //    {
        //        EventLogger eventLogger = new EventLogger();
        //        resultInfo.Result = new EventLoggerBal().GetEvents(eventLogger);
        //    }
        //    catch (Exception ex)
        //    {
        //        resultInfo.ResultCode = -1000;
        //        resultInfo.ResultDesc = ex.Message;
        //        resultInfo.ResultType = TypeOfResult.Error;
        //    }
        //    return resultInfo;

        //}
    }
}