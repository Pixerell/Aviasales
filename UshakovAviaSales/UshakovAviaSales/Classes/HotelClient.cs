using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UshakovAviaSales.MyWindows;

namespace UshakovAviaSales.Classes
{
    public class BMaxLosData
    {
        public int max_allowed_los { get; set; }
        public int is_fullon { get; set; }
        public string experiment { get; set; }
        public int default_los { get; set; }
        public int extended_los { get; set; }
        public int has_extended_los { get; set; }
    }

    public class Root
    {
        public double longitude { get; set; }
        public int landmark_type { get; set; }
        public string image_url { get; set; }
        public string dest_id { get; set; }
        public BMaxLosData b_max_los_data { get; set; }
        public double latitude { get; set; }
        public string region { get; set; }
        public int hotels { get; set; }
        public int nr_hotels { get; set; }
        public string lc { get; set; }
        public string dest_type { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public int rtl { get; set; }
        public string type { get; set; }
        public int? city_ufi { get; set; }
        public string city_name { get; set; }
        public string timezone { get; set; }
        public string cc1 { get; set; }
        public string country { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AllInclusiveAmount
    {
        public double value { get; set; }
        public string currency { get; set; }
    }

    public class Amount
    {
        public string currency { get; set; }
        public double value { get; set; }
    }

    public class Badge
    {
        public string badge_variant { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Base
    {
        public string kind { get; set; }
        public double percentage { get; set; }
        public double? base_amount { get; set; }
    }

    public class Benefit
    {
        public string kind { get; set; }
        public string badge_variant { get; set; }
        public string identifier { get; set; }
        public string details { get; set; }
        public object icon { get; set; }
        public string name { get; set; }
    }

    public class Block
    {
        public string block_id { get; set; }
        public List<Credit> credits { get; set; }
    }

    public class BookingHome
    {
        public double quality_class { get; set; }
        public string is_single_unit_property { get; set; }
        public string group { get; set; }
        public int segment { get; set; }
        //    public int is_booking_home { get; set; }
    }

    public class Breakdown
    {
        public string formatted_amount { get; set; }
        public Amount amount { get; set; }
        public string product_type { get; set; }
    }

    public class Bwallet
    {
        public int hotel_eligibility { get; set; }
    }

    public class Checkin
    {
        public string from { get; set; }
        public string until { get; set; }
    }

    public class Checkout
    {
        public string until { get; set; }
        public string from { get; set; }
    }

    public class CompositePriceBreakdown
    {
        public AllInclusiveAmount all_inclusive_amount { get; set; }
        public RewardAmount reward_amount { get; set; }
        public List<Benefit> benefits { get; set; }
        public GrossAmount gross_amount { get; set; }
        public ExcludedAmount excluded_amount { get; set; }
        public List<Item> items { get; set; }
        public IncludedTaxesAndChargesAmount included_taxes_and_charges_amount { get; set; }
        public GrossAmountPerNight gross_amount_per_night { get; set; }
        public NetAmount net_amount { get; set; }
        public List<ProductPriceBreakdown> product_price_breakdowns { get; set; }
        public StrikethroughAmountPerNight strikethrough_amount_per_night { get; set; }
        public StrikethroughAmount strikethrough_amount { get; set; }
        public DiscountedAmount discounted_amount { get; set; }
    }

    public class Credit
    {
        public string reward_currency { get; set; }
        public string terms_conditions { get; set; }
        public double reward_amount { get; set; }
    }

    public class DiscountedAmount
    {
        public string currency { get; set; }
        public double value { get; set; }
    }

    public class Distance
    {
        public string text { get; set; }
        public string icon_name { get; set; }
        public object icon_set { get; set; }
    }

    public class ExcludedAmount
    {
        public string currency { get; set; }
        public int value { get; set; }
    }

    public class GrossAmount
    {
        public double value { get; set; }
        public string currency { get; set; }
    }

    public class GrossAmountPerNight
    {
        public double value { get; set; }
        public string currency { get; set; }
    }

    public class IncludedTaxesAndChargesAmount
    {
        public string currency { get; set; }
        public double value { get; set; }
    }

    public class Item
    {
        public Base @base { get; set; }
        public string inclusion_type { get; set; }
        public string kind { get; set; }
        public string details { get; set; }
        public ItemAmount item_amount { get; set; }
        public string name { get; set; }
        public List<Breakdown> breakdown { get; set; }
        public string identifier { get; set; }
    }

    public class ItemAmount
    {
        public string currency { get; set; }
        public double value { get; set; }
    }

    public class MapBoundingBox
    {
        public double ne_long { get; set; }
        public double sw_long { get; set; }
        public double ne_lat { get; set; }
        public double sw_lat { get; set; }
    }

    public class NetAmount
    {
        public double value { get; set; }
        public string currency { get; set; }
    }

    public class PriceBreakdown
    {
        //public string sum_excluded_raw { get; set; }
        public int has_fine_print_charges { get; set; }
        public int has_tax_exceptions { get; set; }
        public double all_inclusive_price { get; set; }
        public string currency { get; set; }
        public int has_incalculable_charges { get; set; }
        public object gross_price { get; set; }
    }

    public class ProductPriceBreakdown
    {
        public GrossAmountPerNight gross_amount_per_night { get; set; }
        public NetAmount net_amount { get; set; }
        public IncludedTaxesAndChargesAmount included_taxes_and_charges_amount { get; set; }
        public List<Item> items { get; set; }
        public List<Benefit> benefits { get; set; }
        public ExcludedAmount excluded_amount { get; set; }
        public GrossAmount gross_amount { get; set; }
        public AllInclusiveAmount all_inclusive_amount { get; set; }
        public RewardAmount reward_amount { get; set; }
        public DiscountedAmount discounted_amount { get; set; }
        public StrikethroughAmount strikethrough_amount { get; set; }
        public StrikethroughAmountPerNight strikethrough_amount_per_night { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public int hotel_include_breakfast { get; set; }
        public int price_is_final { get; set; }
        public double native_ads_cpc { get; set; }
        public int cc_required { get; set; }
        public string distance { get; set; }
        public int is_beach_front { get; set; }
        public string timezone { get; set; }
        public object review_score { get; set; }
        //public string is_geo_rate { get; set; }
        public string hotel_name_trans { get; set; }
        public string native_ad_id { get; set; }
        public int accommodation_type { get; set; }
        public double longitude { get; set; }
        public int wishlist_count { get; set; }
        public double mobile_discount_percentage { get; set; }
        public int class_is_estimated { get; set; }
        public int district_id { get; set; }
        public Bwallet bwallet { get; set; }
        public string address { get; set; }
        public string default_language { get; set; }
        public string type { get; set; }
        public int cant_book { get; set; }
        public string unit_configuration_label { get; set; }
        public int is_free_cancellable { get; set; }
        public object selected_review_topic { get; set; }
        public double latitude { get; set; }
        public object review_nr { get; set; }
        public int in_best_district { get; set; }
        public int children_not_allowed { get; set; }
        public string address_trans { get; set; }
        public string default_wishlist_name { get; set; }
        public string district { get; set; }
        public string currency_code { get; set; }
        public string city_name_en { get; set; }
        public string accommodation_type_name { get; set; }
        public string city_in_trans { get; set; }
        public string review_score_word { get; set; }
        public string hotel_facilities { get; set; }
        public string countrycode { get; set; }
        public string city_trans { get; set; }
        public int ufi { get; set; }
        public int main_photo_id { get; set; }
        public string distance_to_cc { get; set; }
        public string url { get; set; }
        public int is_mobile_deal { get; set; }
        public string city { get; set; }
        public double @class { get; set; }
        public int hotel_has_vb_boost { get; set; }
        public int genius_discount_percentage { get; set; }
        public string districts { get; set; }
        public int is_city_center { get; set; }
        public double min_total_price { get; set; }
        public int is_smart_deal { get; set; }
        public int preferred { get; set; }
        public int hotel_id { get; set; }
        public List<string> block_ids { get; set; }
        public string main_photo_url { get; set; }
        public List<Badge> badges { get; set; }
        //public CompositePriceBreakdown composite_price_breakdown { get; set; }
        public string currencycode { get; set; }
        public string country_trans { get; set; }
        public string zip { get; set; }
        public int extended { get; set; }
        public Checkout checkout { get; set; }
        public PriceBreakdown price_breakdown { get; set; }
        public Rewards rewards { get; set; }
        public string cc1 { get; set; }
        public string hotel_name { get; set; }
        public List<Distance> distances { get; set; }
        public int is_no_prepayment_block { get; set; }
        public int soldout { get; set; }
        public string native_ads_tracking { get; set; }
        public int preferred_plus { get; set; }
        public Checkin checkin { get; set; }
        public string review_recommendation { get; set; }
        public int is_genius_deal { get; set; }
        public string max_photo_url { get; set; }
        public string max_1440_photo_url { get; set; }
        public string ribbon_text { get; set; }
        // public BookingHome booking_home { get; set; }
    }

    public class RewardAmount
    {
        public double value { get; set; }
        public string currency { get; set; }
    }

    public class Rewards
    {
        public Total total { get; set; }
        public List<Block> blocks { get; set; }
    }

    public class RoomDistribution
    {
        public string adults { get; set; }
        public List<int> children { get; set; }
    }

    public class Root2
    {
        public int primary_count { get; set; }
        public int count { get; set; }
        public List<RoomDistribution> room_distribution { get; set; }
        public MapBoundingBox map_bounding_box { get; set; }
        public int total_count_with_filters { get; set; }
        public int unfiltered_count { get; set; }
        public int extended_count { get; set; }
        public int unfiltered_primary_count { get; set; }
        public double search_radius { get; set; }
        public List<Sort> sort { get; set; }
        public List<Result> result { get; set; }
    }

    public class Sort
    {
        public string name { get; set; }
        public string id { get; set; }
    }

    public class StrikethroughAmount
    {
        public string currency { get; set; }
        public double value { get; set; }
    }

    public class StrikethroughAmountPerNight
    {
        public double value { get; set; }
        public string currency { get; set; }
    }

    public class SumCredits
    {
        public double reward_amount { get; set; }
        public string reward_currency { get; set; }
    }

    public class Total
    {
        public List<Credit> credits { get; set; }
        public SumCredits sum_credits { get; set; }
    }



    public class BookingHome2
    {
        public object quality_class { get; set; }
        public string group { get; set; }
        public int is_single_unit_property { get; set; }
        public int is_single_type_property { get; set; }
        public int is_vacation_rental { get; set; }
        public int is_aparthotel { get; set; }
        public int is_booking_home { get; set; }
        public int segment { get; set; }
    }

    public class Checkin2
    {
        public int _24_hour_available { get; set; }
        public string to { get; set; }
        public string from { get; set; }
    }

    public class Checkout2
    {
        public int _24_hour_available { get; set; }
        public string to { get; set; }
        public string from { get; set; }
    }

    public class DescriptionTranslation
    {
        public string languagecode { get; set; }
        public int descriptiontype_id { get; set; }
        public string description { get; set; }
    }

    public class LanguagesSpoken
    {
        public List<string> languagecode { get; set; }
    }

    public class Location
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
    }

    public class Root3
    {
        public LanguagesSpoken languages_spoken { get; set; }
        public int preferred_plus { get; set; }
        public object review_nr { get; set; }
        public string main_photo_url { get; set; }
        public string hotel_facilities { get; set; }
        public int preferred { get; set; }
        public int district_id { get; set; }
        public string url { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public double @class { get; set; }
      //  public BookingHome booking_home { get; set; }
        public string hotel_facilities_filtered { get; set; }
        public int hoteltype_id { get; set; }
        public int city_id { get; set; }
        public string country { get; set; }
        public int ranking { get; set; }
        public string city { get; set; }
        public int main_photo_id { get; set; }
        public int class_is_estimated { get; set; }
        public List<DescriptionTranslation> description_translations { get; set; }
        public Location location { get; set; }
        public double maxrate { get; set; }
        public int hotel_id { get; set; }
        public object review_score { get; set; }
        public Checkin checkin { get; set; }
        public int is_single_unit_vr { get; set; }
        public string currencycode { get; set; }
        public string review_score_word { get; set; }
        public string countrycode { get; set; }
        public double minrate { get; set; }
        public string address { get; set; }
        public int is_vacation_rental { get; set; }
        public string name { get; set; }
        public Checkout checkout { get; set; }
        public object district { get; set; }
    }





    public class HotelClient
    {
        private readonly RestClient client;

        public HotelClient()
        {
            client = new RestClient("https://booking-com.p.rapidapi.com");
            client.AddDefaultHeaders(new Dictionary<string, string>
            {
                {"X-RapidAPI-Host", "booking-com.p.rapidapi.com"},
                {"X-RapidAPI-Key", "8f438bb223msh180fe2566f5e077p10d766jsn040614d70cc2"},

            });

        }

        public async Task<string> GetDestId(string cityName)
        {
            var request = new RestRequest($"/v1/hotels/locations?locale=en-gb&name={cityName}", Method.Get);
            var response = await client.ExecuteAsync<List<Root>>(request);

            if (!response.IsSuccessful)
            {
                return null;
            }

            return response.Data.First().dest_id;
        }

        public async Task<List<Result>> GetHotels(string idDest)
        {
            var request = new RestRequest($"/v1/hotels/search?checkin_date=2023-09-27&dest_type=city&units=metric&checkout_date=2023-09-28&adults_number=2&order_by=popularity&dest_id={idDest}&filter_by_currency=AED&locale=en-gb&room_number=1&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&include_adjacency=true", Method.Get);
            var response = await client.ExecuteAsync<Root2>(request);

            if (!response.IsSuccessful)
            {
                return null;
            }

            try
            {
                if (response.Data.result == null)
                {
                    bool? mb1 = new CustomMbox("Something went wrong, try again", MessageType.Info, MessageButtons.Ok).ShowDialog();
                    return null;

                }
                else
                {
                    return response.Data.result;
                }

            }
            catch (Exception)
            {

                bool? mb1 = new CustomMbox("Something went wrong, try again", MessageType.Info, MessageButtons.Ok).ShowDialog();
                return null;
            }
        }
        public async Task<Root3> GetHotelById(int HotelId)
        {
            var request = new RestRequest($"/v1/hotels/data?hotel_id={HotelId}&locale=en-gb", Method.Get);
            var response1 = await client.ExecuteAsync<Root3>(request);

            if (!response1.IsSuccessful)
            {
                return null;
            }

            try
            {
                if (response1.Data == null)
                {
                    bool? mb1 = new CustomMbox("Something went wrong, try again", MessageType.Info, MessageButtons.Ok).ShowDialog();
                    return null;

                }
                else
                {
                    return response1.Data;
                }

            }
            catch (Exception)
            {

                bool? mb1 = new CustomMbox("Something went wrong, try again", MessageType.Info, MessageButtons.Ok).ShowDialog();
                return null;
            }

        }
    }
}
