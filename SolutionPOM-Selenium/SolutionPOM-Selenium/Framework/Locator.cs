using OpenQA.Selenium;

namespace SolutionPOM_Selenium.Framework
{
    public class Locator
    {
         internal By By { get; set; }

         private Locator(By by)
         {
             this.By = by;
         }

         public static Locator Class(string className)
         {
             return new Locator(By.ClassName(className));
         }
         
         
        public static Locator Css(string cssSelector)
        {
            return new Locator(By.CssSelector(cssSelector));
        }

        public static Locator Id(string id)
        {
            return new Locator(By.Id(id));
        }

        public static Locator LinkText(string linkText)
        {
            return new Locator(By.LinkText(linkText));
        }

        public static Locator Name(string name)
        {
            return new Locator(By.Name(name));
        }

        public static Locator PartialLinkText(string partialLinkText)
        {
            return new Locator(By.PartialLinkText(partialLinkText));
        }

        public static Locator Tag(string tag)
        {
            return new Locator(By.TagName(tag));
        }

        public static Locator XPath(string xpath)
        {
            return new Locator(By.XPath(xpath));
        }
         
         
    }
}