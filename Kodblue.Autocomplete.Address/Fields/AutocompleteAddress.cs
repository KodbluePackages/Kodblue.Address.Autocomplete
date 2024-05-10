using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Enums;

namespace Kodblue.Autocomplete.Address.Fields
{
    public class AutocompleteAddress : FieldType
    {
        public AutocompleteAddress()
        {
            Id = new Guid("f3b3b3b3-3b3b-3b3b-3b3b-3b3b3b2b3b3b");
            Name = "Address Autocomplete";
            Description = "Address Autocomplete";
            Icon = "icon-location";
            DataType = FieldDataType.String;
            SortOrder = 10;
            SupportsPreValues = false;
            SupportsRegex = false;
            MandatoryByDefault = true;

            FieldTypeViewName = "FieldType.AutocompleteAddress.cshtml";
        }

        public override string GetDesignView() => "~/App_Plugins/Kodblue.Autocomplete.Address/Backoffice/FieldTypes/AutocompleteAddress.html";
    }
}
