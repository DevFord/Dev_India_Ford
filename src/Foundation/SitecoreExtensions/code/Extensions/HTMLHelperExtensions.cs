namespace FordIndia.Foundation.SitecoreExtensions.Extensions
{
    using System;
    using System.Linq.Expressions;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using FordIndia.Foundation.SitecoreExtensions.Attributes;
    using FordIndia.Foundation.SitecoreExtensions.Controls;
    using Sitecore.Mvc;
    using Sitecore.Mvc.Helpers;
    using System.Text.RegularExpressions;
    using Sitecore.Data.Fields;

    public static class HtmlHelperExtensions
    {
        public static HtmlString ImageField(this SitecoreHelper helper, ID fieldID, int mh = 0, int mw = 0, string cssClass = null, bool disableWebEditing = false)
        {
            return helper.Field(fieldID.ToString(), new
            {
                mh,
                mw,
                DisableWebEdit = disableWebEditing,
                @class = cssClass ?? ""
            });
        }

        public static HtmlString ImageField(this SitecoreHelper helper, ID fieldID, Item item, int mh = 0, int mw = 0, string cssClass = null, bool disableWebEditing = false)
        {
            return helper.Field(fieldID.ToString(), item, new
            {
                mh,
                mw,
                DisableWebEdit = disableWebEditing,
                @class = cssClass ?? ""
            });
        }

        public static HtmlString ImageField(this SitecoreHelper helper, string fieldName, Item item, int mh = 0, int mw = 0, string cssClass = null, bool disableWebEditing = false)
        {
            return helper.Field(fieldName, item, new
            {
                mh,
                mw,
                DisableWebEdit = disableWebEditing,
                @class = cssClass ?? ""
            });
        }

        public static EditFrameRendering BeginEditFrame<T>(this HtmlHelper<T> helper, string dataSource, string buttons)
        {
            var frame = new EditFrameRendering(helper.ViewContext.Writer, dataSource, buttons);
            return frame;
        }

        public static HtmlString DynamicPlaceholder(this SitecoreHelper helper, string placeholderName, bool useStaticPlaceholderNames = false)
        {
            return useStaticPlaceholderNames ? helper.Placeholder(placeholderName) : helper.DynamicPlaceholder(placeholderName);
        }

        public static HtmlString Field(this SitecoreHelper helper, ID fieldID)
        {
            Assert.ArgumentNotNullOrEmpty(fieldID, nameof(fieldID));
            return helper.Field(fieldID.ToString());
        }

        public static HtmlString Field(this SitecoreHelper helper, ID fieldID, object parameters)
        {
            Assert.ArgumentNotNullOrEmpty(fieldID, nameof(fieldID));
            Assert.IsNotNull(parameters, nameof(parameters));
            return helper.Field(fieldID.ToString(), parameters);
        }

        public static HtmlString Field(this SitecoreHelper helper, ID fieldID, Item item, object parameters)
        {
            Assert.ArgumentNotNullOrEmpty(fieldID, nameof(fieldID));
            Assert.IsNotNull(item, nameof(item));
            Assert.IsNotNull(parameters, nameof(parameters));
            return helper.Field(fieldID.ToString(), item, parameters);
        }

        public static HtmlString Field(this SitecoreHelper helper, ID fieldID, Item item)
        {
            Assert.ArgumentNotNullOrEmpty(fieldID, nameof(fieldID));
            Assert.IsNotNull(item, nameof(item));
            return helper.Field(fieldID.ToString(), item);
        }

        /// <summary>
        /// Generates a hidden form field for use with form validation
        /// Required for the <see cref="ValidateRenderingIdAttribute">ValidateRenderingIdAttribute</see> to work
        /// </summary>
        /// <param name="htmlHelper">Html Helper class</param>
        /// <returns>Hidden form field with unique ID</returns>
        public static MvcHtmlString AddUniqueFormId(this HtmlHelper htmlHelper)
        {
            var uid = htmlHelper.Sitecore().CurrentRendering?.UniqueId;
            return !uid.HasValue ? null : htmlHelper.Hidden(ValidateRenderingIdAttribute.FormUniqueid, uid.Value);
        }

        public static MvcHtmlString ValidationErrorFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string error)
        {
            return htmlHelper.HasError(ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData), ExpressionHelper.GetExpressionText(expression)) ? new MvcHtmlString(error) : null;
        }

        public static bool HasError(this HtmlHelper htmlHelper, ModelMetadata modelMetadata, string expression)
        {
            var modelName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(expression);
            var formContext = htmlHelper.ViewContext.FormContext;
            if (formContext == null)
            {
                return false;
            }

            if (!htmlHelper.ViewData.ModelState.ContainsKey(modelName))
            {
                return false;
            }

            var modelState = htmlHelper.ViewData.ModelState[modelName];
            var modelErrors = modelState?.Errors;
            return modelErrors?.Count > 0;
        }
        public static class Helpers
        {
            public static string LinkUrl(LinkField linkField)
            {
                if (linkField != null)
                {
                    switch (linkField.LinkType.ToLower())
                    {
                        case "internal":
                            // Use LinkMananger for internal links, if link is not empty
                            return linkField.TargetItem != null ? Sitecore.Links.LinkManager.GetItemUrl(linkField.TargetItem) : string.Empty;
                        case "media":
                            // Use MediaManager for media links, if link is not empty
                            return linkField.TargetItem != null ? Sitecore.Resources.Media.MediaManager.GetMediaUrl(linkField.TargetItem) : string.Empty;
                        case "external":
                            // Just return external links
                            return linkField.Url;
                        case "anchor":
                            // Prefix anchor link with # if link if not empty
                            return !string.IsNullOrEmpty(linkField.Anchor) ? "#" + linkField.Anchor : string.Empty;
                        case "mailto":
                            // Just return mailto link
                            return linkField.Url;
                        case "javascript":
                            // Just return javascript
                            return linkField.Url;
                        default:
                            // Just please the compiler, this
                            // condition will never be met
                            return linkField.Url;
                    }
                }
                return "";
            }
            public static string RemoveHtml(string strSource)
            {
                string result = !string.IsNullOrEmpty(strSource) ?
                    Regex.Replace(strSource, "<(.|\n)*?>", "").Replace("&nbsp;", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Trim() : string.Empty;

                return result;
            }


            //public static bool HasLanguageVersion(this Sitecore.Data.Items.Item item, string language)
            //{

            //    if (item != null)
            //    {
            //        var languageSpecificItem = global::Sitecore.Context.Database.GetItem(item.ID, Sitecore.Context.Language);
            //        if (languageSpecificItem != null && languageSpecificItem.Versions.Count > 0)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}
        }

    }
}