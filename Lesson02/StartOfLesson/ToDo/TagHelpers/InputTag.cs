using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.IdentityModel.Protocols.WsFederation.WsFederationConstants;

namespace ToDoApp.TagHelpers
{
    [HtmlTargetElement("input", Attributes = "autocomplete")]
    public class InputTagHelper: TagHelper
    {
        public HtmlAttributeNameAttribute AutoCompleteHelp { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (AutoCompleteHelp.ToString() == "off" || AutoCompleteHelp.ToString() == "false" || AutoCompleteHelp.ToString() == "disabled")
            {
                output.Attributes.SetAttribute("AutoCompleteHelp", "off");
            }
            else
            {
                output.Attributes.SetAttribute("AutoCompleteHelp", "on");
            }
        }
    }
}
