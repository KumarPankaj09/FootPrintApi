using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootPrintApi.Models
{

    public class ResultInfo<T>
    {
        public ResultInfo()
        {//CR#18586/IT_1054/CR_77/May-19 : Phoenix - Phase2 (Project Odyssey)
            this.ResultCode = 0;
            this.ResultType = TypeOfResult.Success;
            this.ResultDesc = "Success";
        }

        public string AccessToken { get; set; }
        public string TokenType { get; set; }

        /// <summary>
        /// Default value set to Success
        /// this.ResultType = TypeOfResult.Success;
        /// </summary>
        public TypeOfResult ResultType { get; set; }
        /// <summary>
        /// Default value set to 0 for Success
        /// this.ResultCode = 0;
        /// </summary>
        public int ResultCode { get; set; }
        public string ResultDesc { get; set; }
        public T Result { get; set; }
    }
    public enum TypeOfResult
    {
        Success = 0,
        Failed,
        Warning,
        Info,
        Error
    }
}