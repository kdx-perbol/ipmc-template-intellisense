using inRiver.Remoting.Objects;
using System;
using System.Collections.Generic;
using System.Web;

namespace iPMC.HtmlTemplate.Intellisense.inRiver
{

    /// <summary>
    /// From https://community.inriver.com/product/technical-descriptions/edit-in-context-templates/ as of 2017-11-08
    /// </summary>
    public class TemplateHelper
    {

        /// <summary>Outputs display name.</summary>
        /// <example>@TemplateHelper.DisplayName(Model)</example>
        public static IHtmlString DisplayName(Entity entityModel) { throw new NotImplementedException(); }

        /// <summary>Outputs display description.</summary>
        /// <example>@TemplateHelper.DisplayDescription(Model)</example>
        public static IHtmlString DisplayDescription(Entity entityModel) { throw new NotImplementedException(); }

        /// <summary>Outputs the url for the Entity default picture, the size parameter defaults to "preview"</summary>
        /// <example><div><img src="@TemplateHelper.PictureUrl(subModel)" style="max-width: 100px;" /></div></example>
        public static IHtmlString PictureUrl(Entity entityModel, string size = null) { throw new NotImplementedException(); }

        /// <summary>Outputs a field value for a given Entity system id.</summary>
        /// <example>@TemplateHelper.FieldValue(1234, "ArtNumber")</example>
        public static IHtmlString FieldValue(int entityId, string fieldTypeId) { throw new NotImplementedException(); }

        /// <summary>Outputs a field value for a given Entity.</summary>
        /// <example>@TemplateHelper.FieldValue(Model, "ArtNumber")</example>
        public static IHtmlString FieldValue(Entity entityModel, string fieldTypeId) { throw new NotImplementedException(); }

        /// <summary>Outputs localized field type name.</summary>
        /// <example>@TemplateHelper.FieldTypeName("ArtNumber")</example>
        public static IHtmlString FieldTypeName(string fieldTypeId) { throw new NotImplementedException(); }

        /// <summary>For Edit Templates only. Outputs an edit icon. When clicked, the full Entity editor is shown.</summary>
        /// <example>@TemplateHelper.EntityEditor(1234)</example>
        public static IHtmlString EntityEditor(int entityId) { throw new NotImplementedException(); }

        /// <summary>For Edit Templates only. Outputs an edit icon. When clicked, the full Entity editor is shown.</summary>
        /// <example>@TemplateHelper.EntityEditor(Model)</example>
        public static IHtmlString EntityEditor(Entity entityModel) { throw new NotImplementedException(); }

        /// <summary>For Edit Templates only. Outputs an edit icon. When clicked, the a single field editor is shown.</summary>
        /// <example>@TemplateHelper.FieldEditor(1234, "assortmentName")</example>
        public static IHtmlString FieldEditor(int entityId, string fieldTypeId) { throw new NotImplementedException(); }

        /// <summary>For Edit Templates only. Outputs an edit icon. When clicked, the a single field editor is shown.</summary>
        /// <example>@TemplateHelper.FieldEditor(Model, "assortmentName")</example>
        public static IHtmlString FieldEditor(Entity entityModel, string fieldTypeId) { throw new NotImplementedException(); }

        /// <summary>Returns an array of outbound linked Entity system IDs.</summary>
        /// <example>@foreach(var subEntityId in TemplateHelper.GetSubEntityIds(1234, "Product"))
        ///     {
        /// <li>@subEntityId</li>
        ///     }
        /// }
        /// </example>
        public static IEnumerable<IHtmlString> GetSubEntityIds(int entityId, string entityType = null) { throw new NotImplementedException(); }

        /// <summary>Returns an array of outbound linked Entities.</summary>
        /// <example>@foreach (var subModel in TemplateHelper.GetSubEntityModels(Model, "Product"))
        /// {
        /// <li>
        /// @TemplateHelper.FieldValue(subModel, "ArtNumber")
        /// @TemplateHelper.FieldEditor(subModel, "ArtNumber")
        /// </li>
        /// }</example>
        public static IEnumerable<Entity> GetSubEntityModels(Entity entityModel, string entityType = null) { throw new NotImplementedException(); }

        /// <summary>Returns an array of outbound linked Entities.</summary>
        /// <example>@foreach (var subModel in TemplateHelper.GetSubEntityModels(1234, "Product"))
        /// {
        /// <li>
        /// @TemplateHelper.FieldValue(subModel, "ArtNumber") 
        /// @TemplateHelper.FieldEditor(subModel, "ArtNumber")
        /// </li>
        /// }</example>
        public static IEnumerable<Entity> GetSubEntityModels(int entityId, string entityType = null) { throw new NotImplementedException(); }

        /// <summary>Outputs a javascript object containing all values of a CVL.</summary>
        /// <example><script type="text/javascript">
        /// var compositionTypes = @TemplateHelper.RenderCvlValuesJson("CompositionType")
        /// var compositionMaterials = @TemplateHelper.RenderCvlValuesJson("CompositionMaterial")
        /// </script></example>
        public static IHtmlString RenderCvlValuesJson(string cvlId) { throw new NotImplementedException(); }

        /// <summary>Outputs a javascript object containing all Entity data and outbound linked Entities.</summary>
        /// <example><script type="text/javascript">
        /// var data = @TemplateHelper.RenderFullEntityJson(Model.Id)
        /// </script></example>
        public static IHtmlString RenderFullEntityJson(int entityId) { throw new NotImplementedException(); }

        /// <summary>Outputs a javascript object containing basic Entity information.</summary>
        /// <example><script type="text/javascript">
        /// var basicData = @TemplateHelper.RenderBasicEntityJson(Model.Id)
        /// </script></example>
        public static IHtmlString RenderBasicEntityJson(int entityId) { throw new NotImplementedException(); }

        /// <summary>Outputs a javascript array containing basic Entity information.</summary>
        /// <example><script type="text/javascript">
        /// var basicDatas = @TemplateHelper.RenderLinkedBasicEntityJson(Model.Id)
        /// </script></example>
        public static IHtmlString RenderLinkedBasicEntityJson(int entityId) { throw new NotImplementedException(); }

    }

}