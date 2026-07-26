using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationGeminiLlmResponsesTaskPostRequestInfo 
    {

        /// <summary>
        /// prompt for the AI model
        /// <br/>required field
        /// <br/>the question or task you want to send to the AI model;
        /// <br/>you can specify up to 500 characters in the <c>user_prompt</c> field
        /// </summary>
        [JsonProperty("user_prompt", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrompt { get; set; }

        /// <summary>
        /// name of the AI model
        /// <br/>required field
        /// <br/><c>model_nameconsists of the actual model name and version name;if the basic model name is specified, its latest version will be set by default;for example, if gemini-1.5-pro</c> is specified, the <c>gemini-1.5-pro-002</c> will be set as <c>model_name</c> automatically;
        /// <br/>you can receive the list of available LLM models by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/gemini/llm_responses/models</c>
        /// </summary>
        [JsonProperty("model_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// maximum number of tokens in the AI response
        /// <br/>optional field
        /// <br/>minimum value: <c>1</c>;
        /// <br/>maximum value: <c>4096</c>;
        /// <br/>default value: <c>2048</c>;
        /// <br/>Note: if <c>web_search</c> is set to <c>true</c> or the reasoning model is specified in the request, the output token count may exceed the specified <c>max_output_tokens</c> limit
        /// <br/>Note #2: if <c>use_reasoning</c> is set to <c>true</c>, the minimum value for <c>max_output_tokens</c> is <c>1024</c>
        /// </summary>
        [JsonProperty("max_output_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// randomness of the AI response
        /// <br/>optional field
        /// <br/>higher values make output more diverse 
        /// <br/>lower values make output more focused
        /// <br/>minimum value: <c>0</c>
        /// <br/>maximum value: <c>2</c>
        /// <br/>default value: <c>1.3</c>
        /// </summary>
        [JsonProperty("temperature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Temperature { get; set; }

        /// <summary>
        /// diversity of the AI response
        /// <br/>optional field 
        /// <br/>controls diversity of the response by limiting token selection
        /// <br/>minimum value: <c>0</c>
        /// <br/>maximum value: <c>1</c> 
        /// <br/>default value: <c>0.9</c>
        /// </summary>
        [JsonProperty("top_p", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TopP { get; set; }

        /// <summary>
        /// enable web search for current information
        /// <br/>optional field
        /// <br/>when enabled, the AI model can access and cite current web information;
        /// <br/>Note: refer to the <see href="https://docs.dataforseo.com/v3/ai_optimization/gemini/llm_responses/models/">Models endpoint</see> for a list of models that support <c>web_search</c>; 
        /// <br/>default value: <c>false</c>;
        /// <br/>The cost of the parameter can be calculated on the <see href="https://ai.google.dev/gemini-api/docs/pricing">Pricing</see> page
        /// </summary>
        [JsonProperty("web_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// instructions for the AI behavior
        /// <br/>optional field
        /// <br/>defines the AI's role, tone, or specific behavior 
        /// <br/>you can specify up to 500 characters in the <c>system_message</c> field
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
        /// enable reasoning for the AI model
        /// <br/>optional field
        /// <br/>when enabled, the model will perform reasoning before generating a response
        /// <br/>refer to the <see href="https://docs.dataforseo.com/v3/ai_optimization/gemini/llm_responses/models/">Models endpoint</see> for a list of models that support <c>reasoning</c>
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if set to <c>true</c>, the minimum value for <c>max_output_tokens</c> is <c>1024</c>
        /// <br/>Note #2: for Gemini Pro models, the <c>use_reasoning</c> will automatically be set to <c>true</c>
        /// </summary>
        [JsonProperty("use_reasoning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseReasoning { get; set; }

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
        /// URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the <c>gzip</c> format to the <c>postback_url</c> you specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/><c>http://your-server.com/postbackscript?id=$id</c>
        /// <br/><c>http://your-server.com/postbackscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special character in <c>postback_url</c> will be urlencoded;
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("postback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request
        /// <br/>example:
        /// <br/><c>http://your-server.com/pingscript?id=$id</c>
        /// <br/><c>http://your-server.com/pingscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special character in <c>pingback_url</c> will be urlencoded;
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("pingback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}