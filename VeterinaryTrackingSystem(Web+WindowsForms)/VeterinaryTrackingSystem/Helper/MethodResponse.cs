using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class MethodResponse
    {
        public enum ResponseType
        {
            Succeed,
            Error,
            NotValid,
            DataIsAlreadySaved
        };

        public ResponseType Type { get; set; }
        public string ResultText { get; set; }
        public object Object { get; set; }
    }
}
