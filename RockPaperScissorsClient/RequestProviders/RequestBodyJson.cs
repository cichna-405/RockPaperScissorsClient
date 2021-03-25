using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsClient.RequestProviders
{
    class RequestBodyJson
    {
        public bool IsWaiting { get; set; }

        public bool? Win { get; set; }

        public int Selection { get; set; }

        public string Token { get; set; }
    }
}
