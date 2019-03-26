using System;
using System.Collections.Generic;
using System.Text;

namespace KancelarijaBoilerplate.Models
{
    class ExceptionResponse
    {
        public object Data { get; set; }
        public bool IsError { get; set; }
        public Error Error { get; set; }
    }
}
