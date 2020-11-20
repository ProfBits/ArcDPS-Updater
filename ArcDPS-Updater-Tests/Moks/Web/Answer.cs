using System;
using System.Collections.Generic;
using System.Text;

namespace ArcDPS_Updater_Tests.Moks.Web
{
    struct Answer
    {
        internal Answer(Uri uri, MockHttpResponse response)
        {
            Uri = uri ?? throw new ArgumentException();
            Response = response ?? throw new ArgumentException();
        }

        internal Uri Uri { get; }
        internal MockHttpResponse Response { get; }
    }
}
