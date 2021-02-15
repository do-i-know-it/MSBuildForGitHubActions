using NUnit.Framework;
using MSBuildSampleForGitHubActions.Library;

namespace MSBuildSampleForGitHubActions.Testing
{
    [TestFixture(TestOf = typeof(HelloWorld))]
    internal class HelloWorldTest
    {
        [Test]
        public void CannotIsNull()
        {
            Assert.AreNotEqual(null, HelloWorld.Text);
        }
    }
}
