using System;
using System.Web.Http;
using Xunit;

namespace HttpConfigProblem.Oldstyle
{
    public class HttpConfigurationTest
    {

        [Fact]
        public void CreateInstance()
        {
            var instance = new HttpConfiguration();
        }
    }
}
