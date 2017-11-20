namespace Sitecore.Feature.Media.Models
{
    using System.Collections.Generic;
    using Fortis.Model;
    using Sitecore.Feature.Media.Models.Templates;

    public class MediaCarouselRenderingModel : RenderingModel<IItemWrapper, IHasMediaSelector>
    {
        public MediaCarouselRenderingModel(IRenderingModel<IItemWrapper, IHasMediaSelector> model)
            : base(model.PageItem, model.RenderingItem)
        {
        }

        public IEnumerable<IHasMedia> Slides { get; set; }
        public int MaxCarouselHeight { get; set; }
    }
}