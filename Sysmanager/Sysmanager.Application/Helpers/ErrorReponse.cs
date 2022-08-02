using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Helpers
{
    public class ErrorReponse
    {
        public ErrorReponse(string error)
        {
            this.Errors = new List<string>();
            this.Errors.Add(error);
        }

        public ErrorReponse(List<string> errorList)
        {
            this.Errors = new List<string>();
            this.Errors = (errorList);
        }
        
        public ErrorReponse()
        {
            this.Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
    }
}
