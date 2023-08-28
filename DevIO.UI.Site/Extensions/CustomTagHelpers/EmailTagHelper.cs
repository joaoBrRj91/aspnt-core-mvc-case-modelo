using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Net.Mime;

namespace DevIO.UI.Site.Extensions.CustomTagHelpers
{

    public class EmailTagHelper : TagHelper
    {
        public string EmailDomain { get; set; } = "meudominio.com";


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = $"{content.GetContent()}@{EmailDomain}";
            output.Attributes.SetAttribute("href", $"mailto:{target}");
            output.Content.SetContent(target);
        }
    }
}
