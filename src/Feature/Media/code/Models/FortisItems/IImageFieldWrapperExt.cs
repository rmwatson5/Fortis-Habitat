using IImageFieldWrapper = Fortis.Model.Fields.IImageFieldWrapper;

namespace Sitecore.Feature.Media.Models.FortisItems
{
    using Sitecore.Resources.Media;

    public interface IImageFieldWrapperExt : IImageFieldWrapper
    {
        int Height { get; }
        int Width { get; }

        string GenerateImageUrl(MediaUrlOptions options);
    }
}