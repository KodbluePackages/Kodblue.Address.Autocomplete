using Kodblue.Autocomplete.Address.Fields;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Forms.Core.Providers;

namespace Kodblue.Autocomplete.Address
{
    public class AutocompleteAddressComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.WithCollectionBuilder<FieldCollectionBuilder>()
                .Add<AutocompleteAddress>();
        }
    }
}
