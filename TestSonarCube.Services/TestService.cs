namespace TestSonarCube.Services;

public class TestService : ITestService
{
    public bool TestSomething()
    {
        var a = 1;
        var b = a.ToString();
        return a.ToString() != b;
    }
    
    public bool TestSomething2()
    {
        var a = 3;
        var b = a.ToString();
        switch (a)
        {
            case 0:
                break;
            default:
                break;
            case 1:
                break;
        }
        return a.ToString().Equals(b);
    }
    
    public bool TestSomething3()
    {
        var a = 3;
        var b = a.ToString();
        return a.ToString().Equals(b);
    }
}