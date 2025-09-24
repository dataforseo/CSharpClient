using DataForSeo.Client.Api;
using System.Collections.Generic;

namespace DataForSeo.Client
{
    public class DataForSeoClient
    {
        private System.Net.Http.HttpClient _client;

        public SerpApi SerpApi { get; }
        public DataforseoLabsApi DataforseoLabsApi { get; }
        public DomainAnalyticsApi DomainAnalyticsApi { get; }
        public KeywordsDataApi KeywordsDataApi { get; }
        public BacklinksApi BacklinksApi { get; }
        public AiOptimizationApi AiOptimizationApi { get; }
        public OnPageApi OnPageApi { get; }
        public ContentAnalysisApi ContentAnalysisApi { get; }
        public ContentGenerationApi ContentGenerationApi { get; }
        public MerchantApi MerchantApi { get; }
        public AppDataApi AppDataApi { get; }
        public BusinessDataApi BusinessDataApi { get; }
        public AppendixApi AppendixApi { get; }

        public DataForSeoClient(DataForSeoClientConfiguration configuration) : base()
        {
            _client = new System.Net.Http.HttpClient(new System.Net.Http.HttpClientHandler { AutomaticDecompression = System.Net.DecompressionMethods.GZip, MaxConnectionsPerServer = 1000 });
            _client.Timeout = System.TimeSpan.FromMinutes(1);

            _client.DefaultRequestHeaders.UserAgent.ParseAdd("csharp-client/2.0.7");
            if (configuration.CustomHeaders != null)
            {
                foreach (var header in configuration.CustomHeaders)
                {
                    _client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{configuration.Username}:{configuration.Password}")));
            _client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));
            

            SerpApi = new SerpApi(_client);
            DataforseoLabsApi = new DataforseoLabsApi(_client);
            DomainAnalyticsApi = new DomainAnalyticsApi(_client);
            KeywordsDataApi = new KeywordsDataApi(_client);
            BacklinksApi = new BacklinksApi(_client);
            AiOptimizationApi = new AiOptimizationApi(_client);
            OnPageApi = new OnPageApi(_client);
            ContentAnalysisApi = new ContentAnalysisApi(_client);
            ContentGenerationApi = new ContentGenerationApi(_client);
            MerchantApi = new MerchantApi(_client);
            AppDataApi = new AppDataApi(_client);
            BusinessDataApi = new BusinessDataApi(_client);
            AppendixApi = new AppendixApi(_client);
        }
    }

    public class DataForSeoClientConfiguration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Dictionary<string, string> CustomHeaders { get; set; }
    }
}