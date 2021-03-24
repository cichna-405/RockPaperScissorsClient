using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsClient.RequestProviders
{
    class RequestProvider
    {
        static RequestProvider requestProvider;

        public static RequestProvider Create()
        {
            requestProvider = new RequestProvider();
            return requestProvider;
        }
        public async void Run()
        {

        }
    }
}
