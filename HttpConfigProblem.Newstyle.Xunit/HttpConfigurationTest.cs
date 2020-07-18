using System.Web.Http;
using Xunit;

namespace HttpConfigProblem.Newstyle.Xunit
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
