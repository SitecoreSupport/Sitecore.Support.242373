using Sitecore.XA.Foundation.Theming.Configuration;

namespace Sitecore.Support.XA.Foundation.Theming.Bundler
{
  public class AssetLinksGenerator : Sitecore.XA.Foundation.Theming.Bundler.AssetLinksGenerator
  {
    private readonly AssetConfiguration _configuration;

    public AssetLinksGenerator() : base()
    {
      _configuration = AssetConfigurationReader.Read();
    }

    protected override string GenerateCacheKey(int hash)
    {
      var siteHostName = Sitecore.Context.Site.HostName;
      return $"{DatabaseRepository.GetContentDatabase().Name}#{Sitecore.Context.User.IsAuthenticated}#{_configuration.CacheKey}#{siteHostName}#{hash}";
    }
  }
}