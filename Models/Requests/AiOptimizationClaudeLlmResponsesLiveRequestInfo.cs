using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationClaudeLlmResponsesLiveRequestInfo 
    {

        /// <summary>
        /// prompt for the AI modelrequired fieldthe question or task you want to send to the AI model;you can specify up to 500 characters in the user_prompt field
        /// </summary>
        [JsonProperty("user_prompt", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrompt { get; set; }

        /// <summary>
        /// name of the AI modelrequired fieldmodel_nameconsists of the actual model name and version name;if the basic model name is specified, its latest version will be set by default;for example, if claude-opus-4-0 is specified, the claude-opus-4-20250514 will be set as model_name automatically;you can receive the list of available LLM models by making a separate request to the https://api.dataforseo.com/v3/ai_optimization/claude/llm_responses/models
        /// </summary>
        [JsonProperty("model_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// maximum number of tokens in the AI responseoptional fieldminimum value: 1;maximum value: 4096;default value: 2048;Note: if web_search is set to true or the reasoning model is specified in the request, the output token count may exceed the specified max_output_tokens limitNote #2: if use_reasoning is set to true, the minimum value for max_output_tokens is 1025
        /// </summary>
        [JsonProperty("max_output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// randomness of the AI responseoptional fieldhigher values make output more diverse; lower values make output more focused;minimum value: 0maximum value: 1default value: 0.7Note: temperature cannot be used together with top_p in the same request
        /// </summary>
        [JsonProperty("temperature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Temperature { get; set; }

        /// <summary>
        /// diversity of the AI responseoptional field controls diversity of the response by limiting token selection;minimum value: 0maximum value: 1 default value: nullNote: top_p cannot be used together with temperature in the same request
        /// </summary>
        [JsonProperty("top_p", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TopP { get; set; }

        /// <summary>
        /// enable web search for current informationoptional fieldwhen enabled, the AI model can access and cite current web information;Note: refer to the Models endpoint for a list of models that support web_search; default value: false;The cost of the parameter can be calculated on the Pricing page
        /// </summary>
        [JsonProperty("web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// force AI agent to use web searchoptional fieldto enable this parameter, web_search must also be enabled;when enabled, the AI model is forced to access and cite current web information;default value: false;Note: even if the parameter is set to true, there is no guarantee web sources will be cited in the response
        /// </summary>
        [JsonProperty("force_web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceWebSearch { get; set; }

        /// <summary>
        /// ISO country code of the locationoptional fieldpossible values: 'AR','AT','AU','BE','BR','CA','CH','CL','CN','DE','DK','ES','FI','FR','GB','HK','ID','IN','IT','JP','KR','MX','MY','NL','NO','NZ','PH','PL','PT','RU','SA','SE','TR','TW','US','ZA'
        /// </summary>
        [JsonProperty("web_search_country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebSearchCountryIsoCode { get; set; }

        /// <summary>
        /// city name of the locationoptional fieldNote: specify web_search_country_iso_code to use this parameter
        /// </summary>
        [JsonProperty("web_search_city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebSearchCity { get; set; }

        /// <summary>
        /// instructions for the AI behaviouroptional fielddefines the AI's role, tone, or specific behavior;you can specify up to 500 characters in the system_message field
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
        /// enable reasoning for the AI modeloptional fieldwhen enabled, the model will perform reasoning before generating a responserefer to the Models endpoint for a list of models that support reasoningdefault value: falseNote: if set to true, the minimum value for max_output_tokens is 1025Note #2: if set to true, force_web_search must be set to falseNote #3: if set to true, the temperature and top_p cannot be used
        /// </summary>
        [JsonProperty("use_reasoning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseReasoning { get; set; }

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