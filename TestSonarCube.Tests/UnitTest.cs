using TestSonarCube.Services;

namespace TestSonarCube.Tests;

[TestFixture]
public class UnitTest
{
    [Test]
    public void Test()
    {
        var result = new TestService().TestSomething();
        Assert.False(result);
    }
}