namespace Sitecore.Feature.Media.Models.Templates
{
    using Fortis.Model.Fields;
    using Sitecore.Feature.Media.Models.FortisItems;
    using Sitecore.Mvc.Extensions;

    public partial class HasMedia
    {
        public bool HasMediaItems => this.MediaThumbnail.RawValue.IsEmptyOrNull() == false;
        public IImageFieldWrapperExt BackgroundImage => this.MediaThumbnail;
    }
}