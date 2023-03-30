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
}