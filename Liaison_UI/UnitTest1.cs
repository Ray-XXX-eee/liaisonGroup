using Microsoft.Playwright;
using NUnit.Framework;

namespace LiaisonDemo;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public async Task Test()
    {
        //playwright 
        using var playwright = await Playwright.CreateAsync();
        //browser
        await using var browser = await playwright.Chromium.LaunchAsync();
        //Page
        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://www.liaisongroup.com/");
        var isExist = await page.Locator(selector:"text='How can we help you today?'").IsVisibleAsync();
        Assert.IsTrue(isExist);

    }

}
