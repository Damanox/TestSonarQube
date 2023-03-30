using TestSonarCube.Services;
using TestSonarQube;

namespace TestSonarCube.Tests;

[TestFixture]
public class UnitTest
{
    [Test]
    public void Test()
    {
        var result = new TestService().TestSomething();
        Assert.False(result);
        var result2 = new TestController().Test();
        Assert.False(result2);
    }
    
    [Test]
    public void Test2()
    {
        var result = new TestService().TestSomething2();
        Assert.True(result);
        var result2 = new TestController().Test2();
        Assert.True(result2);
    }
    
    [Test]
    public void Test3()
    {
        var result = new TestService().TestSomething3();
        Assert.True(result);
    }
}