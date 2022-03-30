using BestFilmASPNewVersion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Helpers
{
    /// <summary>
    /// Делаем кнопочки для перелистывания страниц
    /// </summary>
    [HtmlTargetElement("ul", Attributes = "page-model")]
    public class PaginatorBootstrap : TagHelper //Генерирует тэги в html
    {
        private readonly IUrlHelperFactory urlHelperFactory;

        public PaginatorBootstrap(IUrlHelperFactory urlHelperFactory)
        {
            this.urlHelperFactory = urlHelperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PageInfoModel PageModel { get; set; }

        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            var tagUl = new TagBuilder("ul");
            tagUl.AddCssClass("pagination pagination-sm");
            for (int i = 1; i <= PageModel.PagesQuantity; i++)
            {
                var tagLi = new TagBuilder("li");
                tagLi.AddCssClass("page-item");

                var tagA = new TagBuilder("a");
                tagA.AddCssClass("page-link");
                tagA.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
                tagA.InnerHtml.Append(i.ToString());

                tagLi.InnerHtml.AppendHtml(tagA);


                //Выделяем активную кнопку страницы
                if (i == PageModel.CurrentPage)
                {
                    tagLi.AddCssClass("active");
                }

                tagUl.InnerHtml.AppendHtml(tagLi);
            }

            output.Content.AppendHtml(tagUl);

            base.Process(context, output);
        }
    }
}
