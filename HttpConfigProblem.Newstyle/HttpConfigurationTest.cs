using System.Web.Http;
using NUnit.Framework;

namespace HttpConfigProblem.Newstyle
{
    public class HttpConfigurationTest
    {

        [Test]
        public void CreateInstance()
        {
            var instance = new HttpConfiguration();
        }
    }
}
