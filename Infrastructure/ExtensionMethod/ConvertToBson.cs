using MongoDB.Bson;

namespace Infrastructure.ExtensionMethod
{
    public static class ConvertToBson
    {
        public static BsonRegularExpression ConvertToCaseInsensitive(this string value)
        {
            return new BsonRegularExpression("/^" + value + "$/i");
        }
    }
}
