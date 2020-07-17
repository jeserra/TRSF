using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace SportsStore.Infrastructure
{
    public class EmailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag
        }
    }
}
