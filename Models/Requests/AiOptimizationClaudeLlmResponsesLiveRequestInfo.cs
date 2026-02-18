using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationClaudeLlmResponsesLiveRequestInfo 
    {

        /// <summary>
        /// prompt for the AI model
        /// <br/>required field
        /// <br/>the question or task you want to send to the AI model;
        /// <br/>you can specify up to 500 characters in the user_prompt field
        /// </summary>
        [JsonProperty("user_prompt", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrompt { get; set; }

        /// <summary>
        /// name of the AI model
        /// <br/>required field
        /// <br/>model_nameconsists of the actual model name and version name;
        /// <br/>if the basic model name is specified, its latest version will be set by default;
        /// <br/>for example, if claude-opus-4-0 is specified, the claude-opus-4-20250514 will be set as model_name automatically;
        /// <br/>you can receive the list of available LLM models by making a separate request to the https://api.dataforseo.com/v3/ai_optimization/claude/llm_responses/models
        /// </summary>
        [JsonProperty("model_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// maximum number of tokens in the AI response
        /// <br/>optional field
        /// <br/>minimum value: 1;
        /// <br/>maximum value: 4096;
        /// <br/>default value: 2048;
        /// <br/>Note: if web_search is set to true or the reasoning model is specified in the request, the output token count may exceed the specified max_output_tokens limit
        /// </summary>
        [JsonProperty("max_output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// randomness of the AI response
        /// <br/>optional field
        /// <br/>higher values make output more diverse;
        /// <br/>lower values make output more focused;
        /// <br/>minimum value: 0
        /// <br/>maximum value: 1
        /// <br/>default value: 0.7
        /// <br/>Note: temperature cannot be used together with top_p in the same request
        /// </summary>
        [JsonProperty("temperature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Temperature { get; set; }

        /// <summary>
        /// diversity of the AI response
        /// <br/>optional field
        /// <br/>controls diversity of the response by limiting token selection;
        /// <br/>minimum value: 0
        /// <br/>maximum value: 1
        /// <br/>default value: null
        /// <br/>Note: top_p cannot be used together with temperature in the same request
        /// </summary>
        [JsonProperty("top_p", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TopP { get; set; }

        /// <summary>
        /// enable web search for current information
        /// <br/>optional field
        /// <br/>when enabled, the AI model can access and cite current web information;
        /// <br/>Note: refer to the Models endpoint for a list of models that support web_search;
        /// <br/>default value: false;
        /// <br/>The cost of the parameter can be calculated on the Pricing page
        /// </summary>
        [JsonProperty("web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// force AI agent to use web search
        /// <br/>optional field
        /// <br/>to enable this parameter, web_search must also be enabled;
        /// <br/>when enabled, the AI model is forced to access and cite current web information;
        /// <br/>default value: false;
        /// <br/>Note: even if the parameter is set to true, there is no guarantee web sources will be cited in the response
        /// </summary>
        [JsonProperty("force_web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceWebSearch { get; set; }

        /// <summary>
        /// ISO country code of the location
        /// <br/>optional field
        /// <br/>possible values: 'AR','AT','AU','BE','BR','CA','CH','CL','CN','DE','DK','ES','FI','FR','GB','HK','ID','IN','IT','JP','KR','MX','MY','NL','NO','NZ','PH','PL','PT','RU','SA','SE','TR','TW','US','ZA'
        /// </summary>
        [JsonProperty("web_search_country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebSearchCountryIsoCode { get; set; }

        /// <summary>
        /// city name of the location
        /// <br/>optional field
        /// <br/>Note: specify web_search_country_iso_code to use this parameter
        /// </summary>
        [JsonProperty("web_search_city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebSearchCity { get; set; }

        /// <summary>
        /// instructions for the AI behaviour
        /// <br/>optional field
        /// <br/>defines the AI’s role, tone, or specific behavior;
        /// <br/>you can specify up to 500 characters in the system_message field
        /// </summary>
        [JsonProperty("system_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SystemMessage { get; set; }

        /// <summary>
        /// conversation history
        /// <br/>optional field
        /// <br/>array of message objects representing previous conversation turns;
        /// <br/>each object must contain:
        /// <br/>role string with either user or ai role;
        /// <br/>message string with message content (max 500 characters);
        /// <br/>you can specify maximum of 10 message objects in the array;
        /// <br/>Note: for Perplexity models, messages must strictly alternate between user and AI roles (user → ai);
        /// <br/>example:
        /// <br/>'message_chain': [{'role':'user','message':'Hello, what’s up?'},{'role':'ai','message':'Hello! I’m doing well, thank you. How can I assist you today?'}]
        /// </summary>
        [JsonProperty("message_chain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LlmMessageChainItem> MessageChain { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}