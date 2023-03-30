using Microsoft.AspNetCore.Mvc;
using TestSonarCube.Services;

namespace TestSonarQube;

public class TestController: Controller
{
    public bool Test()
    {
        return new TestService().TestSomething();
    }
    
    public bool Test2()
    {
        return new TestService().TestSomething2();
    }
}