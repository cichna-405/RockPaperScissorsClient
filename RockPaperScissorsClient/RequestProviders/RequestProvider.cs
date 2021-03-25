using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

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
        public async void Run(MainWindow mainWindow)
        {

        }
    }
}
