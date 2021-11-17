using System.IO;
using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

public class PlaywrightTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task VerifyAddSkillWorks()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync();
        BrowserNewContextOptions opts = new BrowserNewContextOptions();
        opts.IgnoreHTTPSErrors = true;
        await browser.NewContextAsync( opts);
        var page = await browser.NewPageAsync();        

        await page.GotoAsync("https://localhost:5001/");
        await page.WaitForLoadStateAsync(state: LoadState.DOMContentLoaded);

        // // Click text=Add Skill
        await page.ClickAsync("text=Add Skill");
        Assert.AreEqual("https://localhost:5001/?Capacity=4&Count=4", page.Url);

    }
}
