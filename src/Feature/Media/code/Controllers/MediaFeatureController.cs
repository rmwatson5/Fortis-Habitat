namespace Sitecore.Feature.Media.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Fortis.Model;
    using Sitecore.Feature.Media.Models;
    using Sitecore.Feature.Media.Models.Templates;
    using Sitecore.Foundation.SitecoreExtensions.Repositories;

    //Should be MediaController but this clashes with Sitecore.Controllers.MediaController
    public class MediaFeatureController : Controller
    {
        public ActionResult SectionMedia()
        {
            var renderingPropertiesRepository = new RenderingPropertiesRepository();
            var mediamBackgroundModel = renderingPropertiesRepository.Get<MediaBackgroundRenderingModel>(Mvc.Presentation.RenderingContext.Current.Rendering);

            return this.View(mediamBackgroundModel);
        }

        public ActionResult PageHeaderMedia()
        {
            var renderingPropertiesRepository = new RenderingPropertiesRepository();
            var mediamBackgroundModel = renderingPropertiesRepository.Get<MediaBackgroundRenderingModel>(Mvc.Presentation.RenderingContext.Current.Rendering);

            return this.View(mediamBackgroundModel);
        }

        public ActionResult MediaCarousel()
        {
            // Grabbing via Fortis.Global is temporary until DI is changed
            var model = new MediaCarouselRenderingModel(Fortis.Global.ItemFactory.GetRenderingContextItems<IItemWrapper, IHasMediaSelector>());

            model.Slides = model.RenderingItem.MediaSelector.GetItems<IHasMedia>();
            model.MaxCarouselHeight = model.Slides.Max(s => s.BackgroundImage.Height);
            return this.View(model);
        }
    }
}