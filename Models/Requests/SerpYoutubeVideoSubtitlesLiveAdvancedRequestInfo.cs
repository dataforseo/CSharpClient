using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// ID of the video
        /// <br/>required field
        /// <br/>you can find video ID in the URL or 'youtube_video' item of <see href="/v3/serp/youtube/organic/live/advanced/">YouTube Organic</see> result
        /// <br/>example:
        /// <br/><c>Y8Wu4rSNJms</c>
        /// </summary>
        [JsonProperty("video_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> 
        /// <br/>if you use this field, you don't need to specify <c>location_name</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/youtube/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/youtube/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>only value: <c>desktop</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/youtube/locations</c>
        /// <br/>example:
        /// <br/><c>United States</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/youtube/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>choose from the following values: <c>windows</c>, <c>macos</c>
        /// <br/>default value: <c>windows</c>
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// language code of original text
        /// <br/>you can get the language code from <see href="https://docs.dataforseo.com/v3/serp-youtube-video_info-live-advanced/">YouTube Video Info</see> result
        /// </summary>
        [JsonProperty("subtitles_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitlesLanguage { get; set; }

        /// <summary>
        /// language code of translated text
        /// <br/>possible values:
        /// <br/><c>'az'</c>, <c>'ay'</c>, <c>'ak'</c>, <c>'sq'</c>, <c>'am'</c>, <c>'en'</c>, <c>'ar'</c>, <c>'hy'</c>, <c>'as'</c>, <c>'af'</c>, <c>'eu'</c>, <c>'be'</c>, <c>'bn'</c>, <c>'my'</c>, <c>'bg'</c>, <c>'bs'</c>, <c>'bho'</c>, <c>'cy'</c>, <c>'hu'</c>, <c>'vi'</c>, <c>'haw'</c>, <c>'ht'</c>, <c>'gl'</c>, <c>'lg'</c>, <c>'el'</c>, <c>'ka'</c>, <c>'gn'</c>, <c>'gu'</c>, <c>'gd'</c>, <c>'da'</c>, <c>'fy'</c>, <c>'zu'</c>, <c>'iw'</c>, <c>'ig'</c>, <c>'yi'</c>, <c>'id'</c>, <c>'ga'</c>, <c>'is'</c>, <c>'es'</c>, <c>'it'</c>, <c>'yo'</c>, <c>'kk'</c>, <c>'kn'</c>, <c>'ca'</c>, <c>'qu'</c>, <c>'rw'</c>, <c>'ky'</c>, <c>'zh-Hant'</c>, <c>'zh-Hans'</c>, <c>'ko'</c>, <c>'co'</c>, <c>'xh'</c>, <c>'ku'</c>, <c>'km'</c>, <c>'lo'</c>, <c>'la'</c>, <c>'lv'</c>, <c>'ln'</c>, <c>'lt'</c>, <c>'lb'</c>, <c>'mk'</c>, <c>'mg'</c>, <c>'ms'</c>, <c>'ml'</c>, <c>'dv'</c>, <c>'mt'</c>, <c>'mi'</c>, <c>'mr'</c>, <c>'mn'</c>, <c>'und'</c>, <c>'de'</c>, <c>'ne'</c>, <c>'nl'</c>, <c>'no'</c>, <c>'ny'</c>, <c>'or'</c>, <c>'om'</c>, <c>'pa'</c>, <c>'fa'</c>, <c>'pl'</c>, <c>'pt'</c>, <c>'ps'</c>, <c>'ro'</c>, <c>'ru'</c>, <c>'sm'</c>, <c>'sa'</c>, <c>'ceb'</c>, <c>'nso'</c>, <c>'sr'</c>, <c>'si'</c>, <c>'sd'</c>, <c>'sk'</c>, <c>'sl'</c>, <c>'so'</c>, <c>'sw'</c>, <c>'su'</c>, <c>'tg'</c>, <c>'th'</c>, <c>'ta'</c>, <c>'tt'</c>, <c>'te'</c>, <c>'ti'</c>, <c>'ts'</c>, <c>'tr'</c>, <c>'tk'</c>, <c>'uz'</c>, <c>'ug'</c>, <c>'uk'</c>, <c>'ur'</c>, <c>'fil'</c>, <c>'fi'</c>, <c>'fr'</c>, <c>'ha'</c>, <c>'hi'</c>, <c>'hmn'</c>, <c>'hr'</c>, <c>'cs'</c>, <c>'sv'</c>, <c>'sn'</c>, <c>'ee'</c>, <c>'eo'</c>, <c>'et'</c>, <c>'st'</c>, <c>'jv'</c>, <c>'ja'</c>, <c>'kri'</c>
        /// </summary>
        [JsonProperty("subtitles_translate_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitlesTranslateLanguage { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}