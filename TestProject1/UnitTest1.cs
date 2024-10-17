using Bunit;
using MyBlazorApp.Pages;
using TestContext = Bunit.TestContext;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //官方文件定義

            // Arrange
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();
            var paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();

            // Assert
            var paraElmText = paraElm.TextContent;
            paraElmText.MarkupMatches("Current count: 1");
        }


    }
}