using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.BulmaDarkTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("BulmaDarkTheme")
                .SetUrl("~/BulmaDarkTheme/dist/css/main.css")
                .SetVersion("1.0.0");
				
        }
    }
}
