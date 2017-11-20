














/*
 * Fortis Template Models for Sitecore Demo
 *
 * Generated at 11/20/2017 13:13:11
 */





// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Common;
using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;
using Sitecore.Feature.Media.Models.FortisItems;

#region Background Type Folder (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: Background Type Folder</para><para>ID: {1fd75c49-f524-4c15-9f82-dcb2d4cf2fa9}</para><para>/sitecore/templates/Feature/Media/Background Type Folder</para></summary>
	[TemplateMapping("{1fd75c49-f524-4c15-9f82-dcb2d4cf2fa9}", "InterfaceMap")]
	public partial interface IBackgroundTypeFolder : IItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{1fd75c49-f524-4c15-9f82-dcb2d4cf2fa9}", typeof(Guid))]
	[TemplateMapping("{1fd75c49-f524-4c15-9f82-dcb2d4cf2fa9}")]
	public partial class BackgroundTypeFolder : ItemWrapper, IBackgroundTypeFolder
	{
		public BackgroundTypeFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public BackgroundTypeFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Background Type (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: Background Type</para><para>ID: {55a5bdad-eb69-40f5-8195-cda182e48ee4}</para><para>/sitecore/templates/Feature/Media/Background Type</para></summary>
	[TemplateMapping("{55a5bdad-eb69-40f5-8195-cda182e48ee4}", "InterfaceMap")]
	public partial interface IBackgroundType : IItemWrapper
	{

    	/// <summary><para>Template: Background Type</para><para>Field: Class</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("class")]
		ITextFieldWrapper Class { get; }

    	/// <summary><para>Template: Background Type</para><para>Field: Class</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("class")]
		string ClassValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{55a5bdad-eb69-40f5-8195-cda182e48ee4}", typeof(Guid))]
	[TemplateMapping("{55a5bdad-eb69-40f5-8195-cda182e48ee4}")]
	public partial class BackgroundType : ItemWrapper, IBackgroundType
	{
		public BackgroundType(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public BackgroundType(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: Class</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("class")]
		public virtual ITextFieldWrapper Class => this.GetField<TextFieldWrapper>("Class");

		[IndexField("class")]
 		public string ClassValue => this.Class.Value;
	}
}
#endregion
#region ParametersTemplate_SectionBackground (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: ParametersTemplate_SectionBackground</para><para>ID: {b962a806-d708-4001-b0a3-3fa31f2263c5}</para><para>/sitecore/templates/Feature/Media/ParametersTemplates/ParametersTemplate_SectionBackground</para></summary>
	[TemplateMapping("{b962a806-d708-4001-b0a3-3fa31f2263c5}", "InterfaceMap")]
	public partial interface IParametersTemplateSectionBackground : IItemWrapper
	{

    	/// <summary><para>Template: ParametersTemplate_SectionBackground</para><para>Field: Media</para><para>Data type: Droptree</para></summary>
		[IndexField("media")]
		ILinkFieldWrapper Media { get; }

    	/// <summary><para>Template: ParametersTemplate_SectionBackground</para><para>Field: Media</para><para>Data type: Droptree</para></summary>
		[IndexField("media")]
		Guid MediaValue { get; }

    	/// <summary><para>Template: ParametersTemplate_SectionBackground</para><para>Field: Parallax</para><para>Data type: Checkbox</para></summary>
		[IndexField("parallax")]
		IBooleanFieldWrapper Parallax { get; }

    	/// <summary><para>Template: ParametersTemplate_SectionBackground</para><para>Field: Parallax</para><para>Data type: Checkbox</para></summary>
		[IndexField("parallax")]
		bool ParallaxValue { get; }

    	/// <summary><para>Template: ParametersTemplate_SectionBackground</para><para>Field: Type</para><para>Data type: Droplist</para></summary>
		ITextFieldWrapper Type { get; }

    	/// <summary><para>Template: ParametersTemplate_SectionBackground</para><para>Field: Type</para><para>Data type: Droplist</para></summary>
		string TypeValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{b962a806-d708-4001-b0a3-3fa31f2263c5}", typeof(Guid))]
	[TemplateMapping("{b962a806-d708-4001-b0a3-3fa31f2263c5}")]
	public partial class ParametersTemplateSectionBackground : ItemWrapper, IParametersTemplateSectionBackground
	{
		public ParametersTemplateSectionBackground(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public ParametersTemplateSectionBackground(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: Media</para><para>Data type: Droptree</para></summary>
		[IndexField("media")]
		public virtual ILinkFieldWrapper Media => this.GetField<LinkFieldWrapper>("Media");

		[IndexField("media")]
 		public Guid MediaValue => this.Media.Value;

		/// <summary><para>Field: Parallax</para><para>Data type: Checkbox</para></summary>
		[IndexField("parallax")]
		public virtual IBooleanFieldWrapper Parallax => this.GetField<BooleanFieldWrapper>("Parallax");

		[IndexField("parallax")]
 		public bool ParallaxValue => this.Parallax.Value;

		/// <summary><para>Field: Type</para><para>Data type: Droplist</para></summary>
		public virtual ITextFieldWrapper Type => this.GetField<TextFieldWrapper>("Type");

 		public string TypeValue => this.Type.Value;
	}
}
#endregion
#region _MediaParameters (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: _MediaParameters</para><para>ID: {5df30dc0-e2fc-4921-b8f2-c54fac1bd03e}</para><para>/sitecore/templates/Feature/Media/ParametersTemplates/_MediaParameters</para></summary>
	[TemplateMapping("{5df30dc0-e2fc-4921-b8f2-c54fac1bd03e}", "InterfaceMap")]
	public partial interface IMediaParameters : IItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{5df30dc0-e2fc-4921-b8f2-c54fac1bd03e}", typeof(Guid))]
	[TemplateMapping("{5df30dc0-e2fc-4921-b8f2-c54fac1bd03e}")]
	public partial class MediaParameters : ItemWrapper, IMediaParameters
	{
		public MediaParameters(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MediaParameters(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region _HasMedia (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: _HasMedia</para><para>ID: {a44e450e-ba3f-4faf-9c53-c63241cc34eb}</para><para>/sitecore/templates/Feature/Media/_HasMedia</para></summary>
	[TemplateMapping("{a44e450e-ba3f-4faf-9c53-c63241cc34eb}", "InterfaceMap")]
	public partial interface IHasMedia : IItemWrapper
	{

    	/// <summary><para>Template: _HasMedia</para><para>Field: MediaDescription</para><para>Data type: Rich Text</para></summary>
		[IndexField("mediadescription")]
		IRichTextFieldWrapper MediaDescription { get; }

    	/// <summary><para>Template: _HasMedia</para><para>Field: MediaDescription</para><para>Data type: Rich Text</para></summary>
		[IndexField("mediadescription")]
		string MediaDescriptionValue { get; }

    	/// <summary><para>Template: _HasMedia</para><para>Field: MediaThumbnail</para><para>Data type: Image</para></summary>
		IImageFieldWrapperExt MediaThumbnail { get; }

    	/// <summary><para>Template: _HasMedia</para><para>Field: MediaThumbnail</para><para>Data type: Image</para></summary>
		string MediaThumbnailValue { get; }

    	/// <summary><para>Template: _HasMedia</para><para>Field: MediaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mediatitle")]
		ITextFieldWrapper MediaTitle { get; }

    	/// <summary><para>Template: _HasMedia</para><para>Field: MediaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mediatitle")]
		string MediaTitleValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{a44e450e-ba3f-4faf-9c53-c63241cc34eb}", typeof(Guid))]
	[TemplateMapping("{a44e450e-ba3f-4faf-9c53-c63241cc34eb}")]
	public partial class HasMedia : ItemWrapper, IHasMedia
	{
		public HasMedia(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public HasMedia(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: MediaDescription</para><para>Data type: Rich Text</para></summary>
		[IndexField("mediadescription")]
		public virtual IRichTextFieldWrapper MediaDescription => this.GetField<RichTextFieldWrapper>("MediaDescription");

		[IndexField("mediadescription")]
 		public string MediaDescriptionValue => this.MediaDescription.Value;

		/// <summary><para>Field: MediaThumbnail</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapperExt MediaThumbnail => this.GetField<ImageFieldWrapperExt>("MediaThumbnail");

 		public string MediaThumbnailValue => this.MediaThumbnail.Value;

		/// <summary><para>Field: MediaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mediatitle")]
		public virtual ITextFieldWrapper MediaTitle => this.GetField<TextFieldWrapper>("MediaTitle");

		[IndexField("mediatitle")]
 		public string MediaTitleValue => this.MediaTitle.Value;
	}
}
#endregion
#region _HasMediaImage (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: _HasMediaImage</para><para>ID: {fae0c913-1600-4eba-95a9-4d6fd7407e25}</para><para>/sitecore/templates/Feature/Media/_HasMediaImage</para></summary>
	[TemplateMapping("{fae0c913-1600-4eba-95a9-4d6fd7407e25}", "InterfaceMap")]
	public partial interface IHasMediaImage : IItemWrapper,
		Sitecore.Feature.Media.Models.Templates.IHasMedia
	{

    	/// <summary><para>Template: _HasMediaImage</para><para>Field: MediaImage</para><para>Data type: Image</para></summary>
		IImageFieldWrapperExt MediaImage { get; }

    	/// <summary><para>Template: _HasMediaImage</para><para>Field: MediaImage</para><para>Data type: Image</para></summary>
		string MediaImageValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{fae0c913-1600-4eba-95a9-4d6fd7407e25}", typeof(Guid))]
	[TemplateMapping("{fae0c913-1600-4eba-95a9-4d6fd7407e25}")]
	public partial class HasMediaImage : ItemWrapper, IHasMediaImage
	{
		public HasMediaImage(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public HasMediaImage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: MediaDescription</para><para>Data type: Rich Text</para></summary>
		[IndexField("mediadescription")]
		public virtual IRichTextFieldWrapper MediaDescription => this.GetField<RichTextFieldWrapper>("MediaDescription");

		[IndexField("mediadescription")]
 		public string MediaDescriptionValue => this.MediaDescription.Value;

		/// <summary><para>Field: MediaImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapperExt MediaImage => this.GetField<ImageFieldWrapperExt>("MediaImage");

 		public string MediaImageValue => this.MediaImage.Value;

		/// <summary><para>Field: MediaThumbnail</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapperExt MediaThumbnail => this.GetField<ImageFieldWrapperExt>("MediaThumbnail");

 		public string MediaThumbnailValue => this.MediaThumbnail.Value;

		/// <summary><para>Field: MediaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mediatitle")]
		public virtual ITextFieldWrapper MediaTitle => this.GetField<TextFieldWrapper>("MediaTitle");

		[IndexField("mediatitle")]
 		public string MediaTitleValue => this.MediaTitle.Value;
	}
}
#endregion
#region _HasMediaSelector (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: _HasMediaSelector</para><para>ID: {ae4635af-cfbf-4bf6-9b50-00be23a910c0}</para><para>/sitecore/templates/Feature/Media/_HasMediaSelector</para></summary>
	[TemplateMapping("{ae4635af-cfbf-4bf6-9b50-00be23a910c0}", "InterfaceMap")]
	public partial interface IHasMediaSelector : IItemWrapper
	{

    	/// <summary><para>Template: _HasMediaSelector</para><para>Field: MediaSelector</para><para>Data type: Multilist</para></summary>
		[IndexField("mediaselector")]
		IListFieldWrapper MediaSelector { get; }

    	/// <summary><para>Template: _HasMediaSelector</para><para>Field: MediaSelector</para><para>Data type: Multilist</para></summary>
		[IndexField("mediaselector")]
		IEnumerable<Guid> MediaSelectorValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{ae4635af-cfbf-4bf6-9b50-00be23a910c0}", typeof(Guid))]
	[TemplateMapping("{ae4635af-cfbf-4bf6-9b50-00be23a910c0}")]
	public partial class HasMediaSelector : ItemWrapper, IHasMediaSelector
	{
		public HasMediaSelector(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public HasMediaSelector(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: MediaSelector</para><para>Data type: Multilist</para></summary>
		[IndexField("mediaselector")]
		public virtual IListFieldWrapper MediaSelector => this.GetField<ListFieldWrapper>("MediaSelector");

		[IndexField("mediaselector")]
 		public IEnumerable<Guid> MediaSelectorValue => this.MediaSelector.Value;
	}
}
#endregion
#region _HasMediaVideo (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: _HasMediaVideo</para><para>ID: {5a1b724b-b396-4c48-a833-655cd19018e1}</para><para>/sitecore/templates/Feature/Media/_HasMediaVideo</para></summary>
	[TemplateMapping("{5a1b724b-b396-4c48-a833-655cd19018e1}", "InterfaceMap")]
	public partial interface IHasMediaVideo : IItemWrapper,
		Sitecore.Feature.Media.Models.Templates.IHasMedia
	{

    	/// <summary><para>Template: _HasMediaVideo</para><para>Field: MediaVideoLink</para><para>Data type: link</para></summary>
		ITextFieldWrapper MediaVideoLink { get; }

    	/// <summary><para>Template: _HasMediaVideo</para><para>Field: MediaVideoLink</para><para>Data type: link</para></summary>
		string MediaVideoLinkValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{5a1b724b-b396-4c48-a833-655cd19018e1}", typeof(Guid))]
	[TemplateMapping("{5a1b724b-b396-4c48-a833-655cd19018e1}")]
	public partial class HasMediaVideo : ItemWrapper, IHasMediaVideo
	{
		public HasMediaVideo(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public HasMediaVideo(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: MediaDescription</para><para>Data type: Rich Text</para></summary>
		[IndexField("mediadescription")]
		public virtual IRichTextFieldWrapper MediaDescription => this.GetField<RichTextFieldWrapper>("MediaDescription");

		[IndexField("mediadescription")]
 		public string MediaDescriptionValue => this.MediaDescription.Value;

		/// <summary><para>Field: MediaThumbnail</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapperExt MediaThumbnail => this.GetField<ImageFieldWrapperExt>("MediaThumbnail");

 		public string MediaThumbnailValue => this.MediaThumbnail.Value;

		/// <summary><para>Field: MediaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("mediatitle")]
		public virtual ITextFieldWrapper MediaTitle => this.GetField<TextFieldWrapper>("MediaTitle");

		[IndexField("mediatitle")]
 		public string MediaTitleValue => this.MediaTitle.Value;

		/// <summary><para>Field: MediaVideoLink</para><para>Data type: link</para></summary>
		public virtual ITextFieldWrapper MediaVideoLink => this.GetField<TextFieldWrapper>("MediaVideoLink");

 		public string MediaVideoLinkValue => this.MediaVideoLink.Value;
	}
}
#endregion
#region _MediaSiteExtension (Habitat)
namespace Sitecore.Feature.Media.Models.Templates
{
	/// <summary><para>Template: _MediaSiteExtension</para><para>ID: {d339e56b-6a8a-46bd-a7d3-c9725d50dd4a}</para><para>/sitecore/templates/Feature/Media/_MediaSiteExtension</para></summary>
	[TemplateMapping("{d339e56b-6a8a-46bd-a7d3-c9725d50dd4a}", "InterfaceMap")]
	public partial interface IMediaSiteExtension : IItemWrapper
	{

    	/// <summary><para>Template: _MediaSiteExtension</para><para>Field: Mediafolder</para><para>Data type: Droptree</para></summary>
		[IndexField("mediafolder")]
		ILinkFieldWrapper Mediafolder { get; }

    	/// <summary><para>Template: _MediaSiteExtension</para><para>Field: Mediafolder</para><para>Data type: Droptree</para></summary>
		[IndexField("mediafolder")]
		Guid MediafolderValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{d339e56b-6a8a-46bd-a7d3-c9725d50dd4a}", typeof(Guid))]
	[TemplateMapping("{d339e56b-6a8a-46bd-a7d3-c9725d50dd4a}")]
	public partial class MediaSiteExtension : ItemWrapper, IMediaSiteExtension
	{
		public MediaSiteExtension(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MediaSiteExtension(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: Mediafolder</para><para>Data type: Droptree</para></summary>
		[IndexField("mediafolder")]
		public virtual ILinkFieldWrapper Mediafolder => this.GetField<LinkFieldWrapper>("Mediafolder");

		[IndexField("mediafolder")]
 		public Guid MediafolderValue => this.Mediafolder.Value;
	}
}
#endregion



// Generated in 17ms
