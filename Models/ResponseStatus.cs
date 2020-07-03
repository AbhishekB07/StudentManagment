using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckTaleSolutionTask.Models
{
    public class ResponseStatus
    {
        public string Message { get; set; }

        public bool Status { get; protected set; }


        /// <summary>
        /// 
        /// </summary>
        public ResponseStatus()
        {
            Message = "";
            Status = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status"></param>
        public ResponseStatus(string message, bool status)
        {
            Message = message;
            Status = status;
        }
    }
}
