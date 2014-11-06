using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kickstarter.Api
{
    class Test
    {

        public static void Main(String[] args)
        {

            KickstarterClient client = new KickstarterClient();

            Task<IKickstarterSession> sessionTask = client.StartSession(null, null);
            sessionTask.Start();
            sessionTask.Wait();
            var result = sessionTask.Result;



        }

    }
}
