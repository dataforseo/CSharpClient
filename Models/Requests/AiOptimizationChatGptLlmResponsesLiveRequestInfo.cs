using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationChatGptLlmResponsesLiveRequestInfo 
    {

        /// <summary>
        /// prompt for the AI modelrequired fieldthe question or task you want to send to the AI model;you can specify up to 500 characters in the user_prompt field
        /// </summary>
        [JsonProperty("user_prompt", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrompt { get; set; }

        /// <summary>
        /// name of the AI modelrequired fieldmodel_nameconsists of the actual model name and version name;if the basic model name is specified, its latest version will be set by default;for example, if gpt-4.1 is specified, the gpt-4.1-2025-04-14 will be set as model_name automatically;you can receive the list of available LLM models by making a separate request to the https://api.dataforseo.com/v3/ai_optimization/chat_gpt/llm_responses/models
        /// </summary>
        [JsonProperty("model_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// maximum number of tokens in the AI responseoptional fieldminimum value for reasoning models (e.g., reasoning is true in the Models endpoint): 1024;minimum value for non-reasoning models: 16;maximum value: 4096;default value: 2048Note: if web_search is set to true or the reasoning model is specified in the request, the output token count may exceed the specified max_output_tokens limit
        /// </summary>
        [JsonProperty("max_output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// randomness of the AI responseoptional fieldhigher values make output more diverse; lower values make output more focused;minimum value: 0maximum value: 2default value: 0.94Note: not supported in reasoning models
        /// </summary>
        [JsonProperty("temperature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("top_p", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TopP { get; set; }

        /// <summary>
        /// enable web searchoptional fieldwhen enabled, the AI model can access and cite current web information;default value: false;Note: refer to the Models endpoint for a list of models that support web_search;
        /// </summary>
        [JsonProperty("web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// force AI agent to use web searchoptional fieldto enable this parameter, web_search must also be enabled;when enabled, the AI model is forced to access and cite current web information;default value: false;Note: even if the parameter is set to true, there is no guarantee web sources will be cited in the response Note #2: not supported in reasoning models
        /// </summary>
        [JsonProperty("force_web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceWebSearch { get; set; }

        /// <summary>
        /// ISO country code of the locationoptional fieldrequired if web_search_city is specified;to enable this parameter, web_search must also be enabled;when enabled, the AI model will search the web from the country you specify;Note: not supported in o3-mini, o1-pro, o1 models
        /// </summary>
        [JsonProperty("web_search_country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebSearchCountryIsoCode { get; set; }

        /// <summary>
        /// city name of the locationoptional fieldNote: specify web_search_country_iso_code to use this parameterNote #2: not supported in o3-mini, o1-pro, o1 models
        /// </summary>
        [JsonProperty("web_search_city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebSearchCity { get; set; }

        /// <summary>
        /// instructions for the AI behaviouroptional fielddefines the AI's role, tone, or specific behavior you can specify up to 500 characters in the system_message field
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
        /// user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response
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