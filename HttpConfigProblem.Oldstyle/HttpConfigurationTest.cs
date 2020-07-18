using System.Web.Http;
using NUnit.Framework;

namespace HttpConfigProblem.Oldstyle
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
