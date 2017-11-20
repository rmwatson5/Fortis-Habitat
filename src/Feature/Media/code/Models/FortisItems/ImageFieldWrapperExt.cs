using ImageFieldWrapper = Fortis.Model.Fields.ImageFieldWrapper;
using ISpawnProvider = Fortis.Providers.ISpawnProvider;
using ItemWrapper = Fortis.Model.ItemWrapper;

namespace Sitecore.Feature.Media.Models.FortisItems
{
    using Sitecore.Data.Fields;
    using Sitecore.Data.Items;
    using Sitecore.Resources.Media;

    public class ImageFieldWrapperExt : ImageFieldWrapper, IImageFieldWrapperExt
    {
        public ImageFieldWrapperExt(Field field, ISpawnProvider spawnProvider) : base(field, spawnProvider)
        {
        }

        public ImageFieldWrapperExt(string key, ref ItemWrapper item, ISpawnProvider spawnProvider, string value = null) : base(key, ref item, spawnProvider, value)
        {
        }

        public int Height => System.Convert.ToInt32(this.ImageField.Height);
        public int Width => System.Convert.ToInt32(this.ImageField.Width);

        public string GenerateImageUrl(MediaUrlOptions options)
        {
            if (string.IsNullOrWhiteSpace(this.Field.Value))
            {
                return string.Empty;
            }

            var mediaItem = this.Original as MediaItem;
            if (mediaItem == null)
            {
                return string.Empty;
            }

            return MediaManager.GetMediaUrl(mediaItem, options);
        }
    }
}