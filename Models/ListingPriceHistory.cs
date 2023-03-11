using Newtonsoft.Json;
using System;

namespace listingapi.Models;

public partial class ListingPriceHistory
{
    [JsonProperty("listing_id")]
    public int? ListingId { get; set; }

    [JsonProperty("price")]
    public double Price { get; set; }

    [JsonProperty("price_date")]
    public DateTime PriceDate { get; set; }
}
