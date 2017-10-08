using System.Web.Mvc;

namespace MvcViewDemo
{
    public static class MyHtmlHelpers
    {
        public static TagBuilder Image(this HtmlHelper helper, string imageUrl, string alt)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                TagBuilder imageTag = new TagBuilder("img");
                imageTag.MergeAttribute("src", imageUrl);
                imageTag.MergeAttribute("alt", alt);
                return imageTag;
            }
            return null;
        }
    }
}