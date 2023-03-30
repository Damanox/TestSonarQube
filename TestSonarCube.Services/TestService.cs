namespace TestSonarCube.Services;

public class TestService : ITestService
{
    public bool TestSomething()
    {
        var a = 1;
        var b = a.ToString();
        if (a.ToString() == b)
            return false;
        return true;
    }
    
    public bool TestSomething2()
    {
        var a = 2;
        var b = a.ToString();
        if (a.ToString().Equals(b))
            return true;
        return false;
    }
}