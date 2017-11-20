namespace Sitecore.Feature.Media.Models.Templates
{
    using Fortis.Model.Fields;
    using Sitecore.Feature.Media.Models.FortisItems;

    public partial interface IHasMedia
    {
        bool HasMediaItems { get; }
        IImageFieldWrapperExt BackgroundImage { get; }
    }
}
