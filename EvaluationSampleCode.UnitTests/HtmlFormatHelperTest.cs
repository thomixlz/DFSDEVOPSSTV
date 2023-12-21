using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitsTests
{
    [TestClass]
    internal class HtmlFormatHelperTest
    {
        [TestMethod]
        public void GetBoldFormat_ShouldEncloseStringWithBoldTags()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var content = "test";

            // Act
            var result = helper.GetBoldFormat(content);

            // Assert
            Assert.AreEqual("<b>test</b>", result);
        }

        [TestMethod]
        public void GetItalicFormat_ShouldEncloseStringWithItalicTags()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var content = "test";

            // Act
            var result = helper.GetItalicFormat(content);

            // Assert
            Assert.AreEqual("<i>test</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_ShouldReturnFormattedList()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var contents = new List<string> { "Item1", "Item2", "Item3" };

            // Act
            var result = helper.GetFormattedListElements(contents);

            // Assert
            var expected = new StringBuilder();
            expected.Append("<ul>");
            expected.Append("<li>Item1</li>");
            expected.Append("<li>Item2</li>");
            expected.Append("<li>Item3</li>");
            expected.Append("</ul>");

            Assert.AreEqual(expected.ToString(), result);
        }
    }
}