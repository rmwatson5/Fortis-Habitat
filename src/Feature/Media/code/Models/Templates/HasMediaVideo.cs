namespace Sitecore.Feature.Media.Models.Templates
{
    using Fortis.Model.Fields;
    using Sitecore.Feature.Media.Models.FortisItems;
    using Sitecore.Mvc.Extensions;
    using Sitecore.StringExtensions;

    public partial class HasMediaVideo
    {
        public bool HasMediaItems => this.MediaThumbnail.RawValue.IsNullOrEmpty() == false && this.MediaVideoLink.RawValue.IsEmptyOrNull() == false;
        public IImageFieldWrapperExt BackgroundImage => this.MediaThumbnail;
    }
}