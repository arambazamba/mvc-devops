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
        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://localhost:5001/");
        await page.WaitForLoadStateAsync(state: LoadState.DOMContentLoaded);

        // // Click text=Add Skill
        // await page.ClickAsync("text=Add Skill");
        // Assert.AreEqual("https://localhost:5001/?Capacity=4&Count=4", page.Url);


        // using var playwright = await Playwright.CreateAsync();
        // await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        // {
        //     Headless = false,
        // });
        // var context = await browser.NewContextAsync();

        // // Open new page
        // var page = await context.NewPageAsync();

        // // Go to about:blank
        // await page.GotoAsync("about:blank");

        // // Go to chrome-error://chromewebdata/
        // await page.GotoAsync("chrome-error://chromewebdata/");

        // // Click text=Advanced
        // await page.ClickAsync("text=Advanced");

        // // Click p:has-text("Proceed to localhost (unsafe)")
        // await page.ClickAsync("p:has-text(\"Proceed to localhost (unsafe)\")");

        // // Click text=Proceed to localhost (unsafe)
        // await page.RunAndWaitForNavigationAsync(async () =>
        // {
        //     await page.ClickAsync("text=Proceed to localhost (unsafe)");
        // }/*, new PageWaitForNavigationOptions
        // {
        //     UrlString = "https://localhost:5001/"
        // }*/);

        // // Click text=Add Skill
        // await page.ClickAsync("text=Add Skill");
        // // Assert.AreEqual("https://localhost:5001/?Capacity=4&Count=4", page.Url);
    }
}
