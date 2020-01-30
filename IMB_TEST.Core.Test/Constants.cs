using IMB_TEST.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMB_TEST.Core.Test
{
    public static class Constants
    {
        public static HelperService GetHelperService()
            => new HelperService();
    }
}
