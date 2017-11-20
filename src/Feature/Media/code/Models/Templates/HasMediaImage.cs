namespace Sitecore.Feature.Media.Models.Templates
{
    using Sitecore.Feature.Media.Models.FortisItems;
    using Sitecore.StringExtensions;

    public partial class HasMediaImage
    {
        public bool HasMediaItems => this.MediaThumbnail.RawValue.IsNullOrEmpty() == false && this.MediaImage.RawValue.IsNullOrEmpty() == false;
        public IImageFieldWrapperExt BackgroundImage => string.IsNullOrEmpty(this.MediaThumbnail.RawValue) ? this.MediaImage : this.MediaThumbnail;
    }
}