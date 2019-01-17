using System;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.TagHelpers
{
    [HtmlTargetElement("*", Attributes = "day-of-the-week")]
    public class DayOfWeekTagHelper : TagHelper
    {
        public DateTime TodoDate { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // output.Content.SetContent("Hello from DayOfTheWeek");

            //should receive from the tag helper -
            var stringDate = TodoDate < DateTime.Now.AddDays(7) ? TodoDate.DayOfWeek.ToString() : TodoDate.ToString("MM/dd/yyyy");
            output.Content.SetContent(stringDate);
        }
    }
}
