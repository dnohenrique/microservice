using Application.ViewModels.Response;
using Newtonsoft.Json;

namespace Application.ViewModels
{
    public class MetaDataViewModel
    {
        [JsonProperty(PropertyName = "resultset")]
        public ResultsetPaginationViewModel ResultSet { get; set; }
    }
}
