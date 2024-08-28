using DataForSeo.Client.Api;

namespace DataForSeo.Client
{
    public class DataForSeoClient
    {
        private System.Net.Http.HttpClient _client;
        public SerpApi SerpApi { get; }
        public DomainAnalyticsApi DomainAnalyticsApi { get; }
        public DataforseoLabsApi DataforseoLabsApi { get; }
        public KeywordsDataApi KeywordsDataApi { get; }
        public BacklinksApi BacklinksApi { get; }
        public OnPageApi OnPageApi { get; }
        public ContentAnalysisApi ContentAnalysisApi { get; }
        public ContentGenerationApi ContentGenerationApi { get; }
        public MerchantApi MerchantApi { get; }
        public AppDataApi AppDataApi { get; }
        public BusinessDataApi BusinessDataApi { get; }
        public AppendixApi AppendixApi { get; }

        public DataForSeoClient(string username, string password, bool useCompression = true, string userAgent = null) : base()
        {
            _client = new System.Net.Http.HttpClient(new System.Net.Http.HttpClientHandler { AutomaticDecompression = System.Net.DecompressionMethods.GZip, MaxConnectionsPerServer = 1000 });
            _client.Timeout = System.TimeSpan.FromMinutes(1);
            if (!string.IsNullOrEmpty(userAgent))
                _client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{username}:{password}")));
            if (useCompression)
            {
                _client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));
            }

            SerpApi = new SerpApi(_client);
            DomainAnalyticsApi = new DomainAnalyticsApi(_client);
            DataforseoLabsApi = new DataforseoLabsApi(_client);
            KeywordsDataApi = new KeywordsDataApi(_client);
            BacklinksApi = new BacklinksApi(_client);
            OnPageApi = new OnPageApi(_client);
            ContentAnalysisApi = new ContentAnalysisApi(_client);
            ContentGenerationApi = new ContentGenerationApi(_client);
            MerchantApi = new MerchantApi(_client);
            AppDataApi = new AppDataApi(_client);
            BusinessDataApi = new BusinessDataApi(_client);
            AppendixApi = new AppendixApi(_client);
        }
    }
}