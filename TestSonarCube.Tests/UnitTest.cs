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
    
    [Test]
    public void Test2()
    {
        var result = new TestService().TestSomething2();
        Assert.True(result);
    }
    
    [Test]
    public void Test3()
    {
        var result = new TestService().TestSomething3();
        Assert.True(result);
    }
}