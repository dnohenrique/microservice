using Newtonsoft.Json;

namespace Application.ViewModels.Response
{
    public class EmpresaCarteiraPutResponseViewModel<TResult>
    {
        [JsonProperty(PropertyName = "metadata")]
        public MetaDataViewModel MetaDataViewModel { get; set; }
        public TResult Result { get; set; }   
    }
}
