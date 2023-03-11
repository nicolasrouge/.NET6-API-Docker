using Newtonsoft.Json;
using System;

namespace listingapi.Models;

public partial class ListingPriceHistoriesReadOnly
{
    [JsonProperty("listing_id")]
    public int? ListingId { get; set; }

    [JsonProperty("price")]
    public double Price { get; set; }

    [JsonProperty("price_date")]
    public DateTime PriceDate { get; set; }

    [JsonProperty("ListingId")]
    public virtual Listing Listing { get; set; }
}
