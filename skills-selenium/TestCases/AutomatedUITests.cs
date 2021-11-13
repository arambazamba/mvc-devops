using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class AutomatedUITests : IDisposable
{
    private readonly IWebDriver _driver;
    public AutomatedUITests() => _driver = new ChromeDriver();
    public void Dispose() 
    {
        _driver.Quit(); 
        _driver.Dispose(); 
    }
}