using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsAvailableFiltersGoogleInfo 
    {
        [JsonProperty("keyword_data.keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeyword { get; set; }
        [JsonProperty("keyword_data.keyword_info.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.keyword_info.competition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoCompetition { get; set; }
        [JsonProperty("keyword_data.keyword_info.competition_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoCompetitionLevel { get; set; }
        [JsonProperty("keyword_data.keyword_info.cpc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoCpc { get; set; }
        [JsonProperty("keyword_data.keyword_info.search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoSearchVolume { get; set; }
        [JsonProperty("keyword_data.keyword_info.low_top_of_page_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoLowTopOfPageBid { get; set; }
        [JsonProperty("keyword_data.keyword_info.high_top_of_page_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoHighTopOfPageBid { get; set; }
        [JsonProperty("keyword_data.keyword_info.categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoCategories { get; set; }
        [JsonProperty("keyword_data.keyword_info.search_volume_trend.monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoSearchVolumeTrendMonthly { get; set; }
        [JsonProperty("keyword_data.keyword_info.search_volume_trend.quarterly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoSearchVolumeTrendQuarterly { get; set; }
        [JsonProperty("keyword_data.keyword_info.search_volume_trend.yearly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoSearchVolumeTrendYearly { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoSearchVolume { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.gender_distribution.female", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoGenderDistributionFemale { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.gender_distribution.male", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoGenderDistributionMale { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.age_distribution.18-24", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoAgeDistribution1824 { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.age_distribution.25-34", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoAgeDistribution2534 { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.age_distribution.35-44", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoAgeDistribution3544 { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.age_distribution.45-54", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoAgeDistribution4554 { get; set; }
        [JsonProperty("keyword_data.clickstream_keyword_info.age_distribution.55-64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataClickstreamKeywordInfoAgeDistribution5564 { get; set; }
        [JsonProperty("keyword_data.keyword_properties.core_keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordPropertiesCoreKeyword { get; set; }
        [JsonProperty("keyword_data.keyword_properties.synonym_clustering_algorithm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordPropertiesSynonymClusteringAlgorithm { get; set; }
        [JsonProperty("keyword_data.keyword_properties.keyword_difficulty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordPropertiesKeywordDifficulty { get; set; }
        [JsonProperty("keyword_data.keyword_properties.detected_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordPropertiesDetectedLanguage { get; set; }
        [JsonProperty("keyword_data.keyword_properties.is_another_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordPropertiesIsAnotherLanguage { get; set; }
        [JsonProperty("keyword_data.serp_info.check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSerpInfoCheckUrl { get; set; }
        [JsonProperty("keyword_data.serp_info.serp_item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSerpInfoSerpItemTypes { get; set; }
        [JsonProperty("keyword_data.serp_info.se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSerpInfoSeResultsCount { get; set; }
        [JsonProperty("keyword_data.serp_info.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSerpInfoLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.serp_info.previous_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSerpInfoPreviousUpdatedTime { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoBacklinks { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.dofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoDofollow { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.referring_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoReferringPages { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoReferringDomains { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoReferringMainDomains { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoRank { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.main_domain_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoMainDomainRank { get; set; }
        [JsonProperty("keyword_data.avg_backlinks_info.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataAvgBacklinksInfoLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.search_intent_info.main_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSearchIntentInfoMainIntent { get; set; }
        [JsonProperty("keyword_data.search_intent_info.foreign_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSearchIntentInfoForeignIntent { get; set; }
        [JsonProperty("keyword_data.search_intent_info.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataSearchIntentInfoLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.keyword_info_normalized_with_bing.search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoNormalizedWithBingSearchVolume { get; set; }
        [JsonProperty("keyword_data.keyword_info_normalized_with_bing.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoNormalizedWithBingLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.keyword_info_normalized_with_bing.is_normalized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoNormalizedWithBingIsNormalized { get; set; }
        [JsonProperty("keyword_data.keyword_info_normalized_with_clickstream.search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoNormalizedWithClickstreamSearchVolume { get; set; }
        [JsonProperty("keyword_data.keyword_info_normalized_with_clickstream.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoNormalizedWithClickstreamLastUpdatedTime { get; set; }
        [JsonProperty("keyword_data.keyword_info_normalized_with_clickstream.is_normalized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordDataKeywordInfoNormalizedWithClickstreamIsNormalized { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("ranked_serp_element.serp_item.type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemType { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankGroup { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankAbsolute { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemPosition { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemXpath { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDomain { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemTitle { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemUrl { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.breadcrumb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemBreadcrumb { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.website_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemWebsiteName { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.is_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemIsImage { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.is_video", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemIsVideo { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.is_featured_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemIsFeaturedSnippet { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.is_malicious", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemIsMalicious { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDescription { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.pre_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemPreSnippet { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.extended_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemExtendedSnippet { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.amp_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemAmpVersion { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rating.rating_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRatingRatingType { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rating.value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRatingValue { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rating.votes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRatingVotesCount { get; set; }

        /// <summary>
        /// the maximum value for a rating_type
        /// </summary>
        [JsonProperty("ranked_serp_element.serp_item.rating.rating_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankedSerpElementSerpItemRatingRatingMax { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.about_this_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemAboutThisResult { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemMainDomain { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.relative_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRelativeUrl { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemEtv { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.estimated_paid_traffic_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemEstimatedPaidTrafficCost { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.clickstream_etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemClickstreamEtv { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_changes.previous_rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankChangesPreviousRankAbsolute { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_changes.is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankChangesIsNew { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_changes.is_up", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankChangesIsUp { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_changes.is_down", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankChangesIsDown { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.backlinks_info.referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemBacklinksInfoReferringDomains { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.backlinks_info.referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemBacklinksInfoReferringMainDomains { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.backlinks_info.referring_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemBacklinksInfoReferringPages { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.backlinks_info.dofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemBacklinksInfoDofollow { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.backlinks_info.backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemBacklinksInfoBacklinks { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.backlinks_info.time_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemBacklinksInfoTimeUpdate { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_info.page_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankInfoPageRank { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.rank_info.main_domain_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemRankInfoMainDomainRank { get; set; }
        [JsonProperty("ranked_serp_element.check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementCheckUrl { get; set; }
        [JsonProperty("ranked_serp_element.serp_item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemTypes { get; set; }
        [JsonProperty("ranked_serp_element.se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSeResultsCount { get; set; }
        [JsonProperty("ranked_serp_element.keyword_difficulty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementKeywordDifficulty { get; set; }
        [JsonProperty("ranked_serp_element.is_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementIsLost { get; set; }
        [JsonProperty("ranked_serp_element.last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementLastUpdatedTime { get; set; }
        [JsonProperty("ranked_serp_element.previous_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementPreviousUpdatedTime { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.extra.ad_aclk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemExtraAdAclk { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.description_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemDescriptionRows { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemPhone { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.is_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemIsPaid { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.featured_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemFeaturedTitle { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemSource { get; set; }
        [JsonProperty("ranked_serp_element.serp_item.text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankedSerpElementSerpItemText { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}