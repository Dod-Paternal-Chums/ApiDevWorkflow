using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestProject.Models
{
    public class Response<T>
    {
        public T response { get; set; }
        public int ErrorCode { get; set; }
        public int throttleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public Dictionary<string,string> MessageData { get; set; }

    }
}
