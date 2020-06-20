using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootPrintApi.Models
{
    public class EventLogger
    {

    }
}
public class EventLogger
{

    public string RefNo { get; set; }
    public string EventCode { get; set; }
    public string EventMessage { get; set; }
    public string ApplicationName { get; set; }
    public string PageName { get; set; }
    public string FunctionName { get; set; }
    public string Input { get; set; }
    public string Output { get; set; }
    public string EventType { get; set; }
    public string Source { get; set; }
    public string CustomerId { get; set; }
    public string IP { get; set; }
    public string FromDate { get; set; }
    public string ToDate { get; set; }
    public string CreatedOn { get; set; }
    public string EventId { get; set; }
    public string url { get; set; }
    public string ApplicationId { get;  set; }
    public int IsLeadIDGenerate { get; set; }
}