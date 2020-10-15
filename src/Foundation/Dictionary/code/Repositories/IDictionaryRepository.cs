using FordIndia.Foundation.Dictionary.Models;
using Sitecore.Sites;

namespace FordIndia.Foundation.Dictionary.Repositories
{
  public interface IDictionaryRepository
  {
    Models.Dictionary Get(SiteContext site);
  }
}