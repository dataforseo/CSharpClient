# SerpApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**serpIdList**](SerpApi.md#serpIdList) | **POST**  /v3/serp/id_list  |
[**serpErrors**](SerpApi.md#serpErrors) | **POST**  /v3/serp/errors  |
[**screenshot**](SerpApi.md#screenshot) | **POST**  /v3/serp/screenshot  |
[**aiSummary**](SerpApi.md#aiSummary) | **POST**  /v3/serp/ai_summary  |
[**serpGoogleLocations**](SerpApi.md#serpGoogleLocations) | **GET**  /v3/serp/google/locations  |
[**serpGoogleLocationsCountry**](SerpApi.md#serpGoogleLocationsCountry) | **GET**  /v3/serp/google/locations/{country}  |
[**serpGoogleLanguages**](SerpApi.md#serpGoogleLanguages) | **GET**  /v3/serp/google/languages  |
[**googleOrganicTaskPost**](SerpApi.md#googleOrganicTaskPost) | **POST**  /v3/serp/google/organic/task_post  |
[**googleOrganicTasksReady**](SerpApi.md#googleOrganicTasksReady) | **GET**  /v3/serp/google/organic/tasks_ready  |
[**tasksReady**](SerpApi.md#tasksReady) | **GET**  /v3/serp/tasks_ready  |
[**googleOrganicTasksFixed**](SerpApi.md#googleOrganicTasksFixed) | **GET**  /v3/serp/google/organic/tasks_fixed  |
[**googleOrganicTaskGetRegular**](SerpApi.md#googleOrganicTaskGetRegular) | **GET**  /v3/serp/google/organic/task_get/regular/{id}  |
[**googleOrganicTaskGetAdvanced**](SerpApi.md#googleOrganicTaskGetAdvanced) | **GET**  /v3/serp/google/organic/task_get/advanced/{id}  |
[**googleOrganicTaskGetHtml**](SerpApi.md#googleOrganicTaskGetHtml) | **GET**  /v3/serp/google/organic/task_get/html/{id}  |
[**googleOrganicLiveRegular**](SerpApi.md#googleOrganicLiveRegular) | **POST**  /v3/serp/google/organic/live/regular  |
[**googleOrganicLiveAdvanced**](SerpApi.md#googleOrganicLiveAdvanced) | **POST**  /v3/serp/google/organic/live/advanced  |
[**googleOrganicLiveHtml**](SerpApi.md#googleOrganicLiveHtml) | **POST**  /v3/serp/google/organic/live/html  |
[**serpGoogleAiModeLanguages**](SerpApi.md#serpGoogleAiModeLanguages) | **GET**  /v3/serp/google/ai_mode/languages  |
[**googleAiModeTaskPost**](SerpApi.md#googleAiModeTaskPost) | **POST**  /v3/serp/google/ai_mode/task_post  |
[**googleAiModeTasksReady**](SerpApi.md#googleAiModeTasksReady) | **GET**  /v3/serp/google/ai_mode/tasks_ready  |
[**googleAiModeTasksFixed**](SerpApi.md#googleAiModeTasksFixed) | **GET**  /v3/serp/google/ai_mode/tasks_fixed  |
[**googleAiModeTaskGetAdvanced**](SerpApi.md#googleAiModeTaskGetAdvanced) | **GET**  /v3/serp/google/ai_mode/task_get/advanced/{id}  |
[**googleAiModeTaskGetHtml**](SerpApi.md#googleAiModeTaskGetHtml) | **GET**  /v3/serp/google/ai_mode/task_get/html/{id}  |
[**googleAiModeLiveAdvanced**](SerpApi.md#googleAiModeLiveAdvanced) | **POST**  /v3/serp/google/ai_mode/live/advanced  |
[**googleAiModeLiveHtml**](SerpApi.md#googleAiModeLiveHtml) | **POST**  /v3/serp/google/ai_mode/live/html  |
[**googleMapsTaskPost**](SerpApi.md#googleMapsTaskPost) | **POST**  /v3/serp/google/maps/task_post  |
[**googleMapsTasksReady**](SerpApi.md#googleMapsTasksReady) | **GET**  /v3/serp/google/maps/tasks_ready  |
[**googleMapsTasksFixed**](SerpApi.md#googleMapsTasksFixed) | **GET**  /v3/serp/google/maps/tasks_fixed  |
[**googleMapsTaskGetAdvanced**](SerpApi.md#googleMapsTaskGetAdvanced) | **GET**  /v3/serp/google/maps/task_get/advanced/{id}  |
[**googleMapsLiveAdvanced**](SerpApi.md#googleMapsLiveAdvanced) | **POST**  /v3/serp/google/maps/live/advanced  |
[**googleLocalFinderTaskPost**](SerpApi.md#googleLocalFinderTaskPost) | **POST**  /v3/serp/google/local_finder/task_post  |
[**googleLocalFinderTasksReady**](SerpApi.md#googleLocalFinderTasksReady) | **GET**  /v3/serp/google/local_finder/tasks_ready  |
[**googleLocalFinderTasksFixed**](SerpApi.md#googleLocalFinderTasksFixed) | **GET**  /v3/serp/google/local_finder/tasks_fixed  |
[**googleLocalFinderTaskGetAdvanced**](SerpApi.md#googleLocalFinderTaskGetAdvanced) | **GET**  /v3/serp/google/local_finder/task_get/advanced/{id}  |
[**googleLocalFinderTaskGetHtml**](SerpApi.md#googleLocalFinderTaskGetHtml) | **GET**  /v3/serp/google/local_finder/task_get/html/{id}  |
[**googleLocalFinderLiveAdvanced**](SerpApi.md#googleLocalFinderLiveAdvanced) | **POST**  /v3/serp/google/local_finder/live/advanced  |
[**googleLocalFinderLiveHtml**](SerpApi.md#googleLocalFinderLiveHtml) | **POST**  /v3/serp/google/local_finder/live/html  |
[**googleNewsTaskPost**](SerpApi.md#googleNewsTaskPost) | **POST**  /v3/serp/google/news/task_post  |
[**googleNewsTasksReady**](SerpApi.md#googleNewsTasksReady) | **GET**  /v3/serp/google/news/tasks_ready  |
[**googleNewsTasksFixed**](SerpApi.md#googleNewsTasksFixed) | **GET**  /v3/serp/google/news/tasks_fixed  |
[**googleNewsTaskGetAdvanced**](SerpApi.md#googleNewsTaskGetAdvanced) | **GET**  /v3/serp/google/news/task_get/advanced/{id}  |
[**googleNewsTaskGetHtml**](SerpApi.md#googleNewsTaskGetHtml) | **GET**  /v3/serp/google/news/task_get/html/{id}  |
[**googleNewsLiveAdvanced**](SerpApi.md#googleNewsLiveAdvanced) | **POST**  /v3/serp/google/news/live/advanced  |
[**googleNewsLiveHtml**](SerpApi.md#googleNewsLiveHtml) | **POST**  /v3/serp/google/news/live/html  |
[**googleEventsTaskPost**](SerpApi.md#googleEventsTaskPost) | **POST**  /v3/serp/google/events/task_post  |
[**googleEventsTasksReady**](SerpApi.md#googleEventsTasksReady) | **GET**  /v3/serp/google/events/tasks_ready  |
[**googleEventsTasksFixed**](SerpApi.md#googleEventsTasksFixed) | **GET**  /v3/serp/google/events/tasks_fixed  |
[**googleEventsTaskGetAdvanced**](SerpApi.md#googleEventsTaskGetAdvanced) | **GET**  /v3/serp/google/events/task_get/advanced/{id}  |
[**googleEventsLiveAdvanced**](SerpApi.md#googleEventsLiveAdvanced) | **POST**  /v3/serp/google/events/live/advanced  |
[**googleImagesTaskPost**](SerpApi.md#googleImagesTaskPost) | **POST**  /v3/serp/google/images/task_post  |
[**googleImagesTasksReady**](SerpApi.md#googleImagesTasksReady) | **GET**  /v3/serp/google/images/tasks_ready  |
[**googleImagesTasksFixed**](SerpApi.md#googleImagesTasksFixed) | **GET**  /v3/serp/google/images/tasks_fixed  |
[**googleImagesTaskGetAdvanced**](SerpApi.md#googleImagesTaskGetAdvanced) | **GET**  /v3/serp/google/images/task_get/advanced/{id}  |
[**googleImagesTaskGetHtml**](SerpApi.md#googleImagesTaskGetHtml) | **GET**  /v3/serp/google/images/task_get/html/{id}  |
[**googleImagesLiveAdvanced**](SerpApi.md#googleImagesLiveAdvanced) | **POST**  /v3/serp/google/images/live/advanced  |
[**googleImagesLiveHtml**](SerpApi.md#googleImagesLiveHtml) | **POST**  /v3/serp/google/images/live/html  |
[**googleSearchByImageTaskPost**](SerpApi.md#googleSearchByImageTaskPost) | **POST**  /v3/serp/google/search_by_image/task_post  |
[**googleSearchByImageTasksReady**](SerpApi.md#googleSearchByImageTasksReady) | **GET**  /v3/serp/google/search_by_image/tasks_ready  |
[**googleSearchByImageTasksFixed**](SerpApi.md#googleSearchByImageTasksFixed) | **GET**  /v3/serp/google/search_by_image/tasks_fixed  |
[**googleSearchByImageTaskGetAdvanced**](SerpApi.md#googleSearchByImageTaskGetAdvanced) | **GET**  /v3/serp/google/search_by_image/task_get/advanced/{id}  |
[**googleJobsTaskPost**](SerpApi.md#googleJobsTaskPost) | **POST**  /v3/serp/google/jobs/task_post  |
[**googleJobsTasksReady**](SerpApi.md#googleJobsTasksReady) | **GET**  /v3/serp/google/jobs/tasks_ready  |
[**googleJobsTasksFixed**](SerpApi.md#googleJobsTasksFixed) | **GET**  /v3/serp/google/jobs/tasks_fixed  |
[**googleJobsTaskGetAdvanced**](SerpApi.md#googleJobsTaskGetAdvanced) | **GET**  /v3/serp/google/jobs/task_get/advanced/{id}  |
[**googleJobsTaskGetHtml**](SerpApi.md#googleJobsTaskGetHtml) | **GET**  /v3/serp/google/jobs/task_get/html/{id}  |
[**googleAutocompleteTaskPost**](SerpApi.md#googleAutocompleteTaskPost) | **POST**  /v3/serp/google/autocomplete/task_post  |
[**googleAutocompleteTasksReady**](SerpApi.md#googleAutocompleteTasksReady) | **GET**  /v3/serp/google/autocomplete/tasks_ready  |
[**googleAutocompleteTasksFixed**](SerpApi.md#googleAutocompleteTasksFixed) | **GET**  /v3/serp/google/autocomplete/tasks_fixed  |
[**googleAutocompleteTaskGetAdvanced**](SerpApi.md#googleAutocompleteTaskGetAdvanced) | **GET**  /v3/serp/google/autocomplete/task_get/advanced/{id}  |
[**googleAutocompleteLiveAdvanced**](SerpApi.md#googleAutocompleteLiveAdvanced) | **POST**  /v3/serp/google/autocomplete/live/advanced  |
[**googleDatasetSearchTaskPost**](SerpApi.md#googleDatasetSearchTaskPost) | **POST**  /v3/serp/google/dataset_search/task_post  |
[**googleDatasetSearchTasksReady**](SerpApi.md#googleDatasetSearchTasksReady) | **GET**  /v3/serp/google/dataset_search/tasks_ready  |
[**googleDatasetSearchTasksFixed**](SerpApi.md#googleDatasetSearchTasksFixed) | **GET**  /v3/serp/google/dataset_search/tasks_fixed  |
[**googleDatasetSearchTaskGetAdvanced**](SerpApi.md#googleDatasetSearchTaskGetAdvanced) | **GET**  /v3/serp/google/dataset_search/task_get/advanced/{id}  |
[**googleDatasetSearchLiveAdvanced**](SerpApi.md#googleDatasetSearchLiveAdvanced) | **POST**  /v3/serp/google/dataset_search/live/advanced  |
[**googleDatasetInfoTaskPost**](SerpApi.md#googleDatasetInfoTaskPost) | **POST**  /v3/serp/google/dataset_info/task_post  |
[**googleDatasetInfoTasksReady**](SerpApi.md#googleDatasetInfoTasksReady) | **GET**  /v3/serp/google/dataset_info/tasks_ready  |
[**googleDatasetInfoTasksFixed**](SerpApi.md#googleDatasetInfoTasksFixed) | **GET**  /v3/serp/google/dataset_info/tasks_fixed  |
[**googleDatasetInfoTaskGetAdvanced**](SerpApi.md#googleDatasetInfoTaskGetAdvanced) | **GET**  /v3/serp/google/dataset_info/task_get/advanced/{id}  |
[**googleDatasetInfoLiveAdvanced**](SerpApi.md#googleDatasetInfoLiveAdvanced) | **POST**  /v3/serp/google/dataset_info/live/advanced  |
[**serpGoogleAdsAdvertisersLocations**](SerpApi.md#serpGoogleAdsAdvertisersLocations) | **GET**  /v3/serp/google/ads_advertisers/locations  |
[**googleAdsAdvertisersTaskPost**](SerpApi.md#googleAdsAdvertisersTaskPost) | **POST**  /v3/serp/google/ads_advertisers/task_post  |
[**googleAdsAdvertisersTasksReady**](SerpApi.md#googleAdsAdvertisersTasksReady) | **GET**  /v3/serp/google/ads_advertisers/tasks_ready  |
[**googleAdsAdvertisersTaskGetAdvanced**](SerpApi.md#googleAdsAdvertisersTaskGetAdvanced) | **GET**  /v3/serp/google/ads_advertisers/task_get/advanced/{id}  |
[**serpGoogleAdsSearchLocations**](SerpApi.md#serpGoogleAdsSearchLocations) | **GET**  /v3/serp/google/ads_search/locations  |
[**googleAdsSearchTaskPost**](SerpApi.md#googleAdsSearchTaskPost) | **POST**  /v3/serp/google/ads_search/task_post  |
[**googleAdsSearchTasksReady**](SerpApi.md#googleAdsSearchTasksReady) | **GET**  /v3/serp/google/ads_search/tasks_ready  |
[**googleAdsSearchTaskGetAdvanced**](SerpApi.md#googleAdsSearchTaskGetAdvanced) | **GET**  /v3/serp/google/ads_search/task_get/advanced/{id}  |
[**serpBingLocations**](SerpApi.md#serpBingLocations) | **GET**  /v3/serp/bing/locations  |
[**serpBingLocationsCountry**](SerpApi.md#serpBingLocationsCountry) | **GET**  /v3/serp/bing/locations/{country}  |
[**serpBingLanguages**](SerpApi.md#serpBingLanguages) | **GET**  /v3/serp/bing/languages  |
[**bingOrganicTaskPost**](SerpApi.md#bingOrganicTaskPost) | **POST**  /v3/serp/bing/organic/task_post  |
[**bingOrganicTasksReady**](SerpApi.md#bingOrganicTasksReady) | **GET**  /v3/serp/bing/organic/tasks_ready  |
[**bingOrganicTasksFixed**](SerpApi.md#bingOrganicTasksFixed) | **GET**  /v3/serp/bing/organic/tasks_fixed  |
[**bingOrganicTaskGetRegular**](SerpApi.md#bingOrganicTaskGetRegular) | **GET**  /v3/serp/bing/organic/task_get/regular/{id}  |
[**bingOrganicTaskGetAdvanced**](SerpApi.md#bingOrganicTaskGetAdvanced) | **GET**  /v3/serp/bing/organic/task_get/advanced/{id}  |
[**bingOrganicTaskGetHtml**](SerpApi.md#bingOrganicTaskGetHtml) | **GET**  /v3/serp/bing/organic/task_get/html/{id}  |
[**bingOrganicLiveRegular**](SerpApi.md#bingOrganicLiveRegular) | **POST**  /v3/serp/bing/organic/live/regular  |
[**bingOrganicLiveAdvanced**](SerpApi.md#bingOrganicLiveAdvanced) | **POST**  /v3/serp/bing/organic/live/advanced  |
[**bingOrganicLiveHtml**](SerpApi.md#bingOrganicLiveHtml) | **POST**  /v3/serp/bing/organic/live/html  |
[**bingLocalPackTaskPost**](SerpApi.md#bingLocalPackTaskPost) | **POST**  /v3/serp/bing/local_pack/task_post  |
[**bingLocalPackTasksReady**](SerpApi.md#bingLocalPackTasksReady) | **GET**  /v3/serp/bing/local_pack/tasks_ready  |
[**bingLocalPackTasksFixed**](SerpApi.md#bingLocalPackTasksFixed) | **GET**  /v3/serp/bing/local_pack/tasks_fixed  |
[**bingLocalPackTaskGetRegular**](SerpApi.md#bingLocalPackTaskGetRegular) | **GET**  /v3/serp/bing/local_pack/task_get/regular/{id}  |
[**bingLocalPackTaskGetHtml**](SerpApi.md#bingLocalPackTaskGetHtml) | **GET**  /v3/serp/bing/local_pack/task_get/html/{id}  |
[**bingLocalPackLiveRegular**](SerpApi.md#bingLocalPackLiveRegular) | **POST**  /v3/serp/bing/local_pack/live/regular  |
[**bingLocalPackLiveHtml**](SerpApi.md#bingLocalPackLiveHtml) | **POST**  /v3/serp/bing/local_pack/live/html  |
[**serpYoutubeLocations**](SerpApi.md#serpYoutubeLocations) | **GET**  /v3/serp/youtube/locations  |
[**serpYoutubeLocationsCountry**](SerpApi.md#serpYoutubeLocationsCountry) | **GET**  /v3/serp/youtube/locations/{country}  |
[**serpYoutubeLanguages**](SerpApi.md#serpYoutubeLanguages) | **GET**  /v3/serp/youtube/languages  |
[**youtubeVideoInfoTaskPost**](SerpApi.md#youtubeVideoInfoTaskPost) | **POST**  /v3/serp/youtube/video_info/task_post  |
[**youtubeVideoInfoTasksReady**](SerpApi.md#youtubeVideoInfoTasksReady) | **GET**  /v3/serp/youtube/video_info/tasks_ready  |
[**youtubeVideoInfoTasksFixed**](SerpApi.md#youtubeVideoInfoTasksFixed) | **GET**  /v3/serp/youtube/video_info/tasks_fixed  |
[**youtubeVideoInfoTaskGetAdvanced**](SerpApi.md#youtubeVideoInfoTaskGetAdvanced) | **GET**  /v3/serp/youtube/video_info/task_get/advanced/{id}  |
[**youtubeVideoInfoLiveAdvanced**](SerpApi.md#youtubeVideoInfoLiveAdvanced) | **POST**  /v3/serp/youtube/video_info/live/advanced  |
[**youtubeVideoSubtitlesTaskPost**](SerpApi.md#youtubeVideoSubtitlesTaskPost) | **POST**  /v3/serp/youtube/video_subtitles/task_post  |
[**youtubeVideoSubtitlesTasksReady**](SerpApi.md#youtubeVideoSubtitlesTasksReady) | **GET**  /v3/serp/youtube/video_subtitles/tasks_ready  |
[**youtubeVideoSubtitlesTasksFixed**](SerpApi.md#youtubeVideoSubtitlesTasksFixed) | **GET**  /v3/serp/youtube/video_subtitles/tasks_fixed  |
[**youtubeVideoSubtitlesTaskGetAdvanced**](SerpApi.md#youtubeVideoSubtitlesTaskGetAdvanced) | **GET**  /v3/serp/youtube/video_subtitles/task_get/advanced/{id}  |
[**youtubeVideoSubtitlesLiveAdvanced**](SerpApi.md#youtubeVideoSubtitlesLiveAdvanced) | **POST**  /v3/serp/youtube/video_subtitles/live/advanced  |
[**youtubeVideoCommentsTaskPost**](SerpApi.md#youtubeVideoCommentsTaskPost) | **POST**  /v3/serp/youtube/video_comments/task_post  |
[**youtubeVideoCommentsTasksReady**](SerpApi.md#youtubeVideoCommentsTasksReady) | **GET**  /v3/serp/youtube/video_comments/tasks_ready  |
[**youtubeVideoCommentsTasksFixed**](SerpApi.md#youtubeVideoCommentsTasksFixed) | **GET**  /v3/serp/youtube/video_comments/tasks_fixed  |
[**youtubeVideoCommentsTaskGetAdvanced**](SerpApi.md#youtubeVideoCommentsTaskGetAdvanced) | **GET**  /v3/serp/youtube/video_comments/task_get/advanced/{id}  |
[**youtubeVideoCommentsLiveAdvanced**](SerpApi.md#youtubeVideoCommentsLiveAdvanced) | **POST**  /v3/serp/youtube/video_comments/live/advanced  |
[**serpYahooLocations**](SerpApi.md#serpYahooLocations) | **GET**  /v3/serp/yahoo/locations  |
[**serpYahooLocationsCountry**](SerpApi.md#serpYahooLocationsCountry) | **GET**  /v3/serp/yahoo/locations/{country}  |
[**serpYahooLanguages**](SerpApi.md#serpYahooLanguages) | **GET**  /v3/serp/yahoo/languages  |
[**yahooOrganicTaskPost**](SerpApi.md#yahooOrganicTaskPost) | **POST**  /v3/serp/yahoo/organic/task_post  |
[**yahooOrganicTasksReady**](SerpApi.md#yahooOrganicTasksReady) | **GET**  /v3/serp/yahoo/organic/tasks_ready  |
[**yahooOrganicTasksFixed**](SerpApi.md#yahooOrganicTasksFixed) | **GET**  /v3/serp/yahoo/organic/tasks_fixed  |
[**yahooOrganicTaskGetRegular**](SerpApi.md#yahooOrganicTaskGetRegular) | **GET**  /v3/serp/yahoo/organic/task_get/regular/{id}  |
[**yahooOrganicTaskGetAdvanced**](SerpApi.md#yahooOrganicTaskGetAdvanced) | **GET**  /v3/serp/yahoo/organic/task_get/advanced/{id}  |
[**yahooOrganicTaskGetHtml**](SerpApi.md#yahooOrganicTaskGetHtml) | **GET**  /v3/serp/yahoo/organic/task_get/html/{id}  |
[**yahooOrganicLiveRegular**](SerpApi.md#yahooOrganicLiveRegular) | **POST**  /v3/serp/yahoo/organic/live/regular  |
[**yahooOrganicLiveAdvanced**](SerpApi.md#yahooOrganicLiveAdvanced) | **POST**  /v3/serp/yahoo/organic/live/advanced  |
[**yahooOrganicLiveHtml**](SerpApi.md#yahooOrganicLiveHtml) | **POST**  /v3/serp/yahoo/organic/live/html  |
[**serpBaiduLocations**](SerpApi.md#serpBaiduLocations) | **GET**  /v3/serp/baidu/locations  |
[**serpBaiduLocationsCountry**](SerpApi.md#serpBaiduLocationsCountry) | **GET**  /v3/serp/baidu/locations/{country}  |
[**serpBaiduLanguages**](SerpApi.md#serpBaiduLanguages) | **GET**  /v3/serp/baidu/languages  |
[**baiduOrganicTaskPost**](SerpApi.md#baiduOrganicTaskPost) | **POST**  /v3/serp/baidu/organic/task_post  |
[**baiduOrganicTasksReady**](SerpApi.md#baiduOrganicTasksReady) | **GET**  /v3/serp/baidu/organic/tasks_ready  |
[**baiduOrganicTasksFixed**](SerpApi.md#baiduOrganicTasksFixed) | **GET**  /v3/serp/baidu/organic/tasks_fixed  |
[**baiduOrganicTaskGetRegular**](SerpApi.md#baiduOrganicTaskGetRegular) | **GET**  /v3/serp/baidu/organic/task_get/regular/{id}  |
[**baiduOrganicTaskGetAdvanced**](SerpApi.md#baiduOrganicTaskGetAdvanced) | **GET**  /v3/serp/baidu/organic/task_get/advanced/{id}  |
[**baiduOrganicTaskGetHtml**](SerpApi.md#baiduOrganicTaskGetHtml) | **GET**  /v3/serp/baidu/organic/task_get/html/{id}  |
[**naverOrganicTaskPost**](SerpApi.md#naverOrganicTaskPost) | **POST**  /v3/serp/naver/organic/task_post  |
[**naverOrganicTasksReady**](SerpApi.md#naverOrganicTasksReady) | **GET**  /v3/serp/naver/organic/tasks_ready  |
[**naverOrganicTasksFixed**](SerpApi.md#naverOrganicTasksFixed) | **GET**  /v3/serp/naver/organic/tasks_fixed  |
[**naverOrganicTaskGetRegular**](SerpApi.md#naverOrganicTaskGetRegular) | **GET**  /v3/serp/naver/organic/task_get/regular/{id}  |
[**naverOrganicTaskGetAdvanced**](SerpApi.md#naverOrganicTaskGetAdvanced) | **GET**  /v3/serp/naver/organic/task_get/advanced/{id}  |
[**naverOrganicTaskGetHtml**](SerpApi.md#naverOrganicTaskGetHtml) | **GET**  /v3/serp/naver/organic/task_get/html/{id}  |
[**serpSeznamLocations**](SerpApi.md#serpSeznamLocations) | **GET**  /v3/serp/seznam/locations  |
[**serpSeznamLocationsCountry**](SerpApi.md#serpSeznamLocationsCountry) | **GET**  /v3/serp/seznam/locations/{country}  |
[**serpSeznamLanguages**](SerpApi.md#serpSeznamLanguages) | **GET**  /v3/serp/seznam/languages  |
[**seznamOrganicTaskPost**](SerpApi.md#seznamOrganicTaskPost) | **POST**  /v3/serp/seznam/organic/task_post  |
[**seznamOrganicTasksReady**](SerpApi.md#seznamOrganicTasksReady) | **GET**  /v3/serp/seznam/organic/tasks_ready  |
[**seznamOrganicTasksFixed**](SerpApi.md#seznamOrganicTasksFixed) | **GET**  /v3/serp/seznam/organic/tasks_fixed  |
[**seznamOrganicTaskGetRegular**](SerpApi.md#seznamOrganicTaskGetRegular) | **GET**  /v3/serp/seznam/organic/task_get/regular/{id}  |
[**seznamOrganicTaskGetAdvanced**](SerpApi.md#seznamOrganicTaskGetAdvanced) | **GET**  /v3/serp/seznam/organic/task_get/advanced/{id}  |
[**seznamOrganicTaskGetHtml**](SerpApi.md#seznamOrganicTaskGetHtml) | **GET**  /v3/serp/seznam/organic/task_get/html/{id}  |
[**googleFinanceExploreTaskPost**](SerpApi.md#googleFinanceExploreTaskPost) | **POST**  /v3/serp/google/finance_explore/task_post  |
[**googleFinanceExploreTasksReady**](SerpApi.md#googleFinanceExploreTasksReady) | **GET**  /v3/serp/google/finance_explore/tasks_ready  |
[**googleFinanceExploreTaskGetAdvanced**](SerpApi.md#googleFinanceExploreTaskGetAdvanced) | **GET**  /v3/serp/google/finance_explore/task_get/advanced/{id}  |
[**googleFinanceExploreTaskGetHtml**](SerpApi.md#googleFinanceExploreTaskGetHtml) | **GET**  /v3/serp/google/finance_explore/task_get/html/{id}  |
[**googleFinanceExploreLiveAdvanced**](SerpApi.md#googleFinanceExploreLiveAdvanced) | **POST**  /v3/serp/google/finance_explore/live/advanced  |
[**googleFinanceExploreLiveHtml**](SerpApi.md#googleFinanceExploreLiveHtml) | **POST**  /v3/serp/google/finance_explore/live/html  |
[**googleFinanceMarketsTaskPost**](SerpApi.md#googleFinanceMarketsTaskPost) | **POST**  /v3/serp/google/finance_markets/task_post  |
[**googleFinanceMarketsTasksReady**](SerpApi.md#googleFinanceMarketsTasksReady) | **GET**  /v3/serp/google/finance_markets/tasks_ready  |
[**googleFinanceMarketsTaskGetAdvanced**](SerpApi.md#googleFinanceMarketsTaskGetAdvanced) | **GET**  /v3/serp/google/finance_markets/task_get/advanced/{id}  |
[**googleFinanceMarketsTaskGetHtml**](SerpApi.md#googleFinanceMarketsTaskGetHtml) | **GET**  /v3/serp/google/finance_markets/task_get/html/{id}  |
[**googleFinanceMarketsLiveAdvanced**](SerpApi.md#googleFinanceMarketsLiveAdvanced) | **POST**  /v3/serp/google/finance_markets/live/advanced  |
[**googleFinanceMarketsLiveHtml**](SerpApi.md#googleFinanceMarketsLiveHtml) | **POST**  /v3/serp/google/finance_markets/live/html  |
[**googleFinanceQuoteTaskPost**](SerpApi.md#googleFinanceQuoteTaskPost) | **POST**  /v3/serp/google/finance_quote/task_post  |
[**googleFinanceQuoteTasksReady**](SerpApi.md#googleFinanceQuoteTasksReady) | **GET**  /v3/serp/google/finance_quote/tasks_ready  |
[**googleFinanceQuoteTaskGetAdvanced**](SerpApi.md#googleFinanceQuoteTaskGetAdvanced) | **GET**  /v3/serp/google/finance_quote/task_get/advanced/{id}  |
[**googleFinanceQuoteTaskGetHtml**](SerpApi.md#googleFinanceQuoteTaskGetHtml) | **GET**  /v3/serp/google/finance_quote/task_get/html/{id}  |
[**googleFinanceQuoteLiveAdvanced**](SerpApi.md#googleFinanceQuoteLiveAdvanced) | **POST**  /v3/serp/google/finance_quote/live/advanced  |
[**googleFinanceQuoteLiveHtml**](SerpApi.md#googleFinanceQuoteLiveHtml) | **POST**  /v3/serp/google/finance_quote/live/html  |
[**googleFinanceTickerSearchTaskPost**](SerpApi.md#googleFinanceTickerSearchTaskPost) | **POST**  /v3/serp/google/finance_ticker_search/task_post  |
[**googleFinanceTickerSearchTasksReady**](SerpApi.md#googleFinanceTickerSearchTasksReady) | **GET**  /v3/serp/google/finance_ticker_search/tasks_ready  |
[**googleFinanceTickerSearchTaskGetAdvanced**](SerpApi.md#googleFinanceTickerSearchTaskGetAdvanced) | **GET**  /v3/serp/google/finance_ticker_search/task_get/advanced/{id}  |
[**googleFinanceTickerSearchLiveAdvanced**](SerpApi.md#googleFinanceTickerSearchLiveAdvanced) | **POST**  /v3/serp/google/finance_ticker_search/live/advanced  |

<a id="serpIdList"></a>
# **serpIdList**
> SerpIdListResponseInfo serpIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpIdListAsync(new List<SerpIdListRequestInfo>()
{
    new()
    {
        DatetimeFrom = "2025-05-06 08:27:31 +00:00",
        DatetimeTo = "2025-07-06 08:27:31 +00:00",
        Limit = 100,
        Offset = 0,
        Sort = "desc",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpIdListRequestInfo>&gt;**](IEnumerable<SerpIdListRequestInfo>.md)|  | [optional] |



### Return type

[**SerpIdListResponseInfo**](SerpIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpErrors"></a>
# **serpErrors**
> SerpErrorsResponseInfo serpErrors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpErrorsAsync(new List<SerpErrorsRequestInfo>()
{
    new()
    {
        Limit = 10,
        Offset = 0,
        FilteredFunction = "pingback_url",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpErrorsRequestInfo>&gt;**](IEnumerable<SerpErrorsRequestInfo>.md)|  | [optional] |



### Return type

[**SerpErrorsResponseInfo**](SerpErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="screenshot"></a>
# **screenshot**
> SerpScreenshotResponseInfo screenshot()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.ScreenshotAsync(new List<SerpScreenshotRequestInfo>()
{
    new()
    {
        TaskId = "06211235-0696-0139-1000-36727fbd3c90",
        BrowserScreenScaleFactor = 0.5,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpScreenshotRequestInfo>&gt;**](IEnumerable<SerpScreenshotRequestInfo>.md)|  | [optional] |



### Return type

[**SerpScreenshotResponseInfo**](SerpScreenshotResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="aiSummary"></a>
# **aiSummary**
> SerpAiSummaryResponseInfo aiSummary()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.AiSummaryAsync(new List<SerpAiSummaryRequestInfo>()
{
    new()
    {
        TaskId = "07031739-1535-0139-0000-9d1e639a5b7d",
        Prompt = "explain what DataForSEO is",
        FetchContent = true,
        IncludeLinks = true,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpAiSummaryRequestInfo>&gt;**](IEnumerable<SerpAiSummaryRequestInfo>.md)|  | [optional] |



### Return type

[**SerpAiSummaryResponseInfo**](SerpAiSummaryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpGoogleLocations"></a>
# **serpGoogleLocations**
> SerpGoogleLocationsResponseInfo serpGoogleLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpGoogleLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleLocationsResponseInfo**](SerpGoogleLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpGoogleLocationsCountry"></a>
# **serpGoogleLocationsCountry**
> SerpGoogleLocationsCountryResponseInfo serpGoogleLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.SerpApi.SerpGoogleLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleLocationsCountryResponseInfo**](SerpGoogleLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpGoogleLanguages"></a>
# **serpGoogleLanguages**
> SerpGoogleLanguagesResponseInfo serpGoogleLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpGoogleLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleLanguagesResponseInfo**](SerpGoogleLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicTaskPost"></a>
# **googleOrganicTaskPost**
> SerpGoogleOrganicTaskPostResponseInfo googleOrganicTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicTaskPostAsync(new List<SerpGoogleOrganicTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleOrganicTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleOrganicTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleOrganicTaskPostResponseInfo**](SerpGoogleOrganicTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicTasksReady"></a>
# **googleOrganicTasksReady**
> SerpGoogleOrganicTasksReadyResponseInfo googleOrganicTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleOrganicTasksReadyResponseInfo**](SerpGoogleOrganicTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="tasksReady"></a>
# **tasksReady**
> SerpTasksReadyResponseInfo tasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.TasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpTasksReadyResponseInfo**](SerpTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicTasksFixed"></a>
# **googleOrganicTasksFixed**
> SerpGoogleOrganicTasksFixedResponseInfo googleOrganicTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleOrganicTasksFixedResponseInfo**](SerpGoogleOrganicTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicTaskGetRegular"></a>
# **googleOrganicTaskGetRegular**
> SerpGoogleOrganicTaskGetRegularResponseInfo googleOrganicTaskGetRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleOrganicTaskGetRegularAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleOrganicTaskGetRegularResponseInfo**](SerpGoogleOrganicTaskGetRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicTaskGetAdvanced"></a>
# **googleOrganicTaskGetAdvanced**
> SerpGoogleOrganicTaskGetAdvancedResponseInfo googleOrganicTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleOrganicTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleOrganicTaskGetAdvancedResponseInfo**](SerpGoogleOrganicTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicTaskGetHtml"></a>
# **googleOrganicTaskGetHtml**
> SerpGoogleOrganicTaskGetHtmlResponseInfo googleOrganicTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleOrganicTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleOrganicTaskGetHtmlResponseInfo**](SerpGoogleOrganicTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicLiveRegular"></a>
# **googleOrganicLiveRegular**
> SerpGoogleOrganicLiveRegularResponseInfo googleOrganicLiveRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicLiveRegularAsync(new List<SerpGoogleOrganicLiveRegularRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleOrganicLiveRegularRequestInfo>&gt;**](IEnumerable<SerpGoogleOrganicLiveRegularRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleOrganicLiveRegularResponseInfo**](SerpGoogleOrganicLiveRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicLiveAdvanced"></a>
# **googleOrganicLiveAdvanced**
> SerpGoogleOrganicLiveAdvancedResponseInfo googleOrganicLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicLiveAdvancedAsync(new List<SerpGoogleOrganicLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
        CalculateRectangles = true,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleOrganicLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleOrganicLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleOrganicLiveAdvancedResponseInfo**](SerpGoogleOrganicLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleOrganicLiveHtml"></a>
# **googleOrganicLiveHtml**
> SerpGoogleOrganicLiveHtmlResponseInfo googleOrganicLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleOrganicLiveHtmlAsync(new List<SerpGoogleOrganicLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleOrganicLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleOrganicLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleOrganicLiveHtmlResponseInfo**](SerpGoogleOrganicLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpGoogleAiModeLanguages"></a>
# **serpGoogleAiModeLanguages**
> SerpGoogleAiModeLanguagesResponseInfo serpGoogleAiModeLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpGoogleAiModeLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAiModeLanguagesResponseInfo**](SerpGoogleAiModeLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAiModeTaskPost"></a>
# **googleAiModeTaskPost**
> SerpGoogleAiModeTaskPostResponseInfo googleAiModeTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAiModeTaskPostAsync(new List<SerpGoogleAiModeTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "what is google ai mode",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleAiModeTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleAiModeTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleAiModeTaskPostResponseInfo**](SerpGoogleAiModeTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAiModeTasksReady"></a>
# **googleAiModeTasksReady**
> SerpGoogleAiModeTasksReadyResponseInfo googleAiModeTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAiModeTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAiModeTasksReadyResponseInfo**](SerpGoogleAiModeTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAiModeTasksFixed"></a>
# **googleAiModeTasksFixed**
> SerpGoogleAiModeTasksFixedResponseInfo googleAiModeTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAiModeTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAiModeTasksFixedResponseInfo**](SerpGoogleAiModeTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAiModeTaskGetAdvanced"></a>
# **googleAiModeTaskGetAdvanced**
> SerpGoogleAiModeTaskGetAdvancedResponseInfo googleAiModeTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleAiModeTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAiModeTaskGetAdvancedResponseInfo**](SerpGoogleAiModeTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAiModeTaskGetHtml"></a>
# **googleAiModeTaskGetHtml**
> SerpGoogleAiModeTaskGetHtmlResponseInfo googleAiModeTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleAiModeTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAiModeTaskGetHtmlResponseInfo**](SerpGoogleAiModeTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAiModeLiveAdvanced"></a>
# **googleAiModeLiveAdvanced**
> SerpGoogleAiModeLiveAdvancedResponseInfo googleAiModeLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAiModeLiveAdvancedAsync(new List<SerpGoogleAiModeLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "what is google ai mode",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleAiModeLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleAiModeLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleAiModeLiveAdvancedResponseInfo**](SerpGoogleAiModeLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAiModeLiveHtml"></a>
# **googleAiModeLiveHtml**
> SerpGoogleAiModeLiveHtmlResponseInfo googleAiModeLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAiModeLiveHtmlAsync(new List<SerpGoogleAiModeLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleAiModeLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleAiModeLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleAiModeLiveHtmlResponseInfo**](SerpGoogleAiModeLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMapsTaskPost"></a>
# **googleMapsTaskPost**
> SerpGoogleMapsTaskPostResponseInfo googleMapsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleMapsTaskPostAsync(new List<SerpGoogleMapsTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleMapsTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleMapsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleMapsTaskPostResponseInfo**](SerpGoogleMapsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMapsTasksReady"></a>
# **googleMapsTasksReady**
> SerpGoogleMapsTasksReadyResponseInfo googleMapsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleMapsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleMapsTasksReadyResponseInfo**](SerpGoogleMapsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMapsTasksFixed"></a>
# **googleMapsTasksFixed**
> SerpGoogleMapsTasksFixedResponseInfo googleMapsTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleMapsTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleMapsTasksFixedResponseInfo**](SerpGoogleMapsTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMapsTaskGetAdvanced"></a>
# **googleMapsTaskGetAdvanced**
> SerpGoogleMapsTaskGetAdvancedResponseInfo googleMapsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleMapsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleMapsTaskGetAdvancedResponseInfo**](SerpGoogleMapsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMapsLiveAdvanced"></a>
# **googleMapsLiveAdvanced**
> SerpGoogleMapsLiveAdvancedResponseInfo googleMapsLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleMapsLiveAdvancedAsync(new List<SerpGoogleMapsLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleMapsLiveAdvancedResponseInfo**](SerpGoogleMapsLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleLocalFinderTaskPost"></a>
# **googleLocalFinderTaskPost**
> SerpGoogleLocalFinderTaskPostResponseInfo googleLocalFinderTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleLocalFinderTaskPostAsync(new List<SerpGoogleLocalFinderTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "local nail services",
        LocationCode = 2840,
        LanguageCode = "en",
        MinRating = 4.5,
        TimeFilter = "monday",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleLocalFinderTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleLocalFinderTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleLocalFinderTaskPostResponseInfo**](SerpGoogleLocalFinderTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleLocalFinderTasksReady"></a>
# **googleLocalFinderTasksReady**
> SerpGoogleLocalFinderTasksReadyResponseInfo googleLocalFinderTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleLocalFinderTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleLocalFinderTasksReadyResponseInfo**](SerpGoogleLocalFinderTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleLocalFinderTasksFixed"></a>
# **googleLocalFinderTasksFixed**
> SerpGoogleLocalFinderTasksFixedResponseInfo googleLocalFinderTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleLocalFinderTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleLocalFinderTasksFixedResponseInfo**](SerpGoogleLocalFinderTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleLocalFinderTaskGetAdvanced"></a>
# **googleLocalFinderTaskGetAdvanced**
> SerpGoogleLocalFinderTaskGetAdvancedResponseInfo googleLocalFinderTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleLocalFinderTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleLocalFinderTaskGetAdvancedResponseInfo**](SerpGoogleLocalFinderTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleLocalFinderTaskGetHtml"></a>
# **googleLocalFinderTaskGetHtml**
> SerpGoogleLocalFinderTaskGetHtmlResponseInfo googleLocalFinderTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleLocalFinderTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleLocalFinderTaskGetHtmlResponseInfo**](SerpGoogleLocalFinderTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleLocalFinderLiveAdvanced"></a>
# **googleLocalFinderLiveAdvanced**
> SerpGoogleLocalFinderLiveAdvancedResponseInfo googleLocalFinderLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleLocalFinderLiveAdvancedAsync(new List<SerpGoogleLocalFinderLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "local nail services",
        LocationCode = 2840,
        LanguageCode = "en",
        MinRating = 4.5,
        TimeFilter = "monday",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleLocalFinderLiveAdvancedResponseInfo**](SerpGoogleLocalFinderLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleLocalFinderLiveHtml"></a>
# **googleLocalFinderLiveHtml**
> SerpGoogleLocalFinderLiveHtmlResponseInfo googleLocalFinderLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleLocalFinderLiveHtmlAsync(new List<SerpGoogleLocalFinderLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleLocalFinderLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleLocalFinderLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleLocalFinderLiveHtmlResponseInfo**](SerpGoogleLocalFinderLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleNewsTaskPost"></a>
# **googleNewsTaskPost**
> SerpGoogleNewsTaskPostResponseInfo googleNewsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleNewsTaskPostAsync(new List<SerpGoogleNewsTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleNewsTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleNewsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleNewsTaskPostResponseInfo**](SerpGoogleNewsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleNewsTasksReady"></a>
# **googleNewsTasksReady**
> SerpGoogleNewsTasksReadyResponseInfo googleNewsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleNewsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleNewsTasksReadyResponseInfo**](SerpGoogleNewsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleNewsTasksFixed"></a>
# **googleNewsTasksFixed**
> SerpGoogleNewsTasksFixedResponseInfo googleNewsTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleNewsTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleNewsTasksFixedResponseInfo**](SerpGoogleNewsTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleNewsTaskGetAdvanced"></a>
# **googleNewsTaskGetAdvanced**
> SerpGoogleNewsTaskGetAdvancedResponseInfo googleNewsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleNewsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleNewsTaskGetAdvancedResponseInfo**](SerpGoogleNewsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleNewsTaskGetHtml"></a>
# **googleNewsTaskGetHtml**
> SerpGoogleNewsTaskGetHtmlResponseInfo googleNewsTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleNewsTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleNewsTaskGetHtmlResponseInfo**](SerpGoogleNewsTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleNewsLiveAdvanced"></a>
# **googleNewsLiveAdvanced**
> SerpGoogleNewsLiveAdvancedResponseInfo googleNewsLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleNewsLiveAdvancedAsync(new List<SerpGoogleNewsLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "android",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleNewsLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleNewsLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleNewsLiveAdvancedResponseInfo**](SerpGoogleNewsLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleNewsLiveHtml"></a>
# **googleNewsLiveHtml**
> SerpGoogleNewsLiveHtmlResponseInfo googleNewsLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleNewsLiveHtmlAsync(new List<SerpGoogleNewsLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleNewsLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleNewsLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleNewsLiveHtmlResponseInfo**](SerpGoogleNewsLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleEventsTaskPost"></a>
# **googleEventsTaskPost**
> SerpGoogleEventsTaskPostResponseInfo googleEventsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleEventsTaskPostAsync(new List<SerpGoogleEventsTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleEventsTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleEventsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleEventsTaskPostResponseInfo**](SerpGoogleEventsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleEventsTasksReady"></a>
# **googleEventsTasksReady**
> SerpGoogleEventsTasksReadyResponseInfo googleEventsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleEventsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleEventsTasksReadyResponseInfo**](SerpGoogleEventsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleEventsTasksFixed"></a>
# **googleEventsTasksFixed**
> SerpGoogleEventsTasksFixedResponseInfo googleEventsTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleEventsTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleEventsTasksFixedResponseInfo**](SerpGoogleEventsTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleEventsTaskGetAdvanced"></a>
# **googleEventsTaskGetAdvanced**
> SerpGoogleEventsTaskGetAdvancedResponseInfo googleEventsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleEventsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleEventsTaskGetAdvancedResponseInfo**](SerpGoogleEventsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleEventsLiveAdvanced"></a>
# **googleEventsLiveAdvanced**
> SerpGoogleEventsLiveAdvancedResponseInfo googleEventsLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleEventsLiveAdvancedAsync(new List<SerpGoogleEventsLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "concerts",
        LocationName = "Los Angeles,California,United States",
        DateRange = "today",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleEventsLiveAdvancedResponseInfo**](SerpGoogleEventsLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleImagesTaskPost"></a>
# **googleImagesTaskPost**
> SerpGoogleImagesTaskPostResponseInfo googleImagesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleImagesTaskPostAsync(new List<SerpGoogleImagesTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleImagesTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleImagesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleImagesTaskPostResponseInfo**](SerpGoogleImagesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleImagesTasksReady"></a>
# **googleImagesTasksReady**
> SerpGoogleImagesTasksReadyResponseInfo googleImagesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleImagesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleImagesTasksReadyResponseInfo**](SerpGoogleImagesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleImagesTasksFixed"></a>
# **googleImagesTasksFixed**
> SerpGoogleImagesTasksFixedResponseInfo googleImagesTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleImagesTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleImagesTasksFixedResponseInfo**](SerpGoogleImagesTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleImagesTaskGetAdvanced"></a>
# **googleImagesTaskGetAdvanced**
> SerpGoogleImagesTaskGetAdvancedResponseInfo googleImagesTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleImagesTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleImagesTaskGetAdvancedResponseInfo**](SerpGoogleImagesTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleImagesTaskGetHtml"></a>
# **googleImagesTaskGetHtml**
> SerpGoogleImagesTaskGetHtmlResponseInfo googleImagesTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleImagesTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleImagesTaskGetHtmlResponseInfo**](SerpGoogleImagesTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleImagesLiveAdvanced"></a>
# **googleImagesLiveAdvanced**
> SerpGoogleImagesLiveAdvancedResponseInfo googleImagesLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleImagesLiveAdvancedAsync(new List<SerpGoogleImagesLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleImagesLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleImagesLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleImagesLiveAdvancedResponseInfo**](SerpGoogleImagesLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleImagesLiveHtml"></a>
# **googleImagesLiveHtml**
> SerpGoogleImagesLiveHtmlResponseInfo googleImagesLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleImagesLiveHtmlAsync(new List<SerpGoogleImagesLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleImagesLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleImagesLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleImagesLiveHtmlResponseInfo**](SerpGoogleImagesLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleSearchByImageTaskPost"></a>
# **googleSearchByImageTaskPost**
> SerpGoogleSearchByImageTaskPostResponseInfo googleSearchByImageTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleSearchByImageTaskPostAsync(new List<SerpGoogleSearchByImageTaskPostRequestInfo>()
{
    new()
    {
        ImageUrl = "https://dataforseo.com/wp-content/uploads/2016/11/data_for_seo_light_429.png",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleSearchByImageTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleSearchByImageTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleSearchByImageTaskPostResponseInfo**](SerpGoogleSearchByImageTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleSearchByImageTasksReady"></a>
# **googleSearchByImageTasksReady**
> SerpGoogleSearchByImageTasksReadyResponseInfo googleSearchByImageTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleSearchByImageTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleSearchByImageTasksReadyResponseInfo**](SerpGoogleSearchByImageTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleSearchByImageTasksFixed"></a>
# **googleSearchByImageTasksFixed**
> SerpGoogleSearchByImageTasksFixedResponseInfo googleSearchByImageTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleSearchByImageTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleSearchByImageTasksFixedResponseInfo**](SerpGoogleSearchByImageTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleSearchByImageTaskGetAdvanced"></a>
# **googleSearchByImageTaskGetAdvanced**
> SerpGoogleSearchByImageTaskGetAdvancedResponseInfo googleSearchByImageTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleSearchByImageTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleSearchByImageTaskGetAdvancedResponseInfo**](SerpGoogleSearchByImageTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleJobsTaskPost"></a>
# **googleJobsTaskPost**
> SerpGoogleJobsTaskPostResponseInfo googleJobsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleJobsTaskPostAsync(new List<SerpGoogleJobsTaskPostRequestInfo>()
{
    new()
    {
        Keyword = ".net developer",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleJobsTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleJobsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleJobsTaskPostResponseInfo**](SerpGoogleJobsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleJobsTasksReady"></a>
# **googleJobsTasksReady**
> SerpGoogleJobsTasksReadyResponseInfo googleJobsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleJobsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleJobsTasksReadyResponseInfo**](SerpGoogleJobsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleJobsTasksFixed"></a>
# **googleJobsTasksFixed**
> SerpGoogleJobsTasksFixedResponseInfo googleJobsTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleJobsTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleJobsTasksFixedResponseInfo**](SerpGoogleJobsTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleJobsTaskGetAdvanced"></a>
# **googleJobsTaskGetAdvanced**
> SerpGoogleJobsTaskGetAdvancedResponseInfo googleJobsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleJobsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleJobsTaskGetAdvancedResponseInfo**](SerpGoogleJobsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleJobsTaskGetHtml"></a>
# **googleJobsTaskGetHtml**
> SerpGoogleJobsTaskGetHtmlResponseInfo googleJobsTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleJobsTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleJobsTaskGetHtmlResponseInfo**](SerpGoogleJobsTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAutocompleteTaskPost"></a>
# **googleAutocompleteTaskPost**
> SerpGoogleAutocompleteTaskPostResponseInfo googleAutocompleteTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAutocompleteTaskPostAsync(new List<SerpGoogleAutocompleteTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
        CursorPointer = 6,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleAutocompleteTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleAutocompleteTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleAutocompleteTaskPostResponseInfo**](SerpGoogleAutocompleteTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAutocompleteTasksReady"></a>
# **googleAutocompleteTasksReady**
> SerpGoogleAutocompleteTasksReadyResponseInfo googleAutocompleteTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAutocompleteTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAutocompleteTasksReadyResponseInfo**](SerpGoogleAutocompleteTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAutocompleteTasksFixed"></a>
# **googleAutocompleteTasksFixed**
> SerpGoogleAutocompleteTasksFixedResponseInfo googleAutocompleteTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAutocompleteTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAutocompleteTasksFixedResponseInfo**](SerpGoogleAutocompleteTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAutocompleteTaskGetAdvanced"></a>
# **googleAutocompleteTaskGetAdvanced**
> SerpGoogleAutocompleteTaskGetAdvancedResponseInfo googleAutocompleteTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleAutocompleteTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAutocompleteTaskGetAdvancedResponseInfo**](SerpGoogleAutocompleteTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAutocompleteLiveAdvanced"></a>
# **googleAutocompleteLiveAdvanced**
> SerpGoogleAutocompleteLiveAdvancedResponseInfo googleAutocompleteLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAutocompleteLiveAdvancedAsync(new List<SerpGoogleAutocompleteLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
        Client = "gws-wiz-serp",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleAutocompleteLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleAutocompleteLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleAutocompleteLiveAdvancedResponseInfo**](SerpGoogleAutocompleteLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetSearchTaskPost"></a>
# **googleDatasetSearchTaskPost**
> SerpGoogleDatasetSearchTaskPostResponseInfo googleDatasetSearchTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetSearchTaskPostAsync(new List<SerpGoogleDatasetSearchTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "water quality",
        LastUpdated = "1m",
        FileFormats = new List<string>()
        {
            "archive",
            "image",
        },
        UsageRights = "noncommercial",
        IsFree = true,
        Topics = new List<string>()
        {
            "natural_sciences",
            "geo",
        },
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleDatasetSearchTaskPostResponseInfo**](SerpGoogleDatasetSearchTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetSearchTasksReady"></a>
# **googleDatasetSearchTasksReady**
> SerpGoogleDatasetSearchTasksReadyResponseInfo googleDatasetSearchTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetSearchTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleDatasetSearchTasksReadyResponseInfo**](SerpGoogleDatasetSearchTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetSearchTasksFixed"></a>
# **googleDatasetSearchTasksFixed**
> SerpGoogleDatasetSearchTasksFixedResponseInfo googleDatasetSearchTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetSearchTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleDatasetSearchTasksFixedResponseInfo**](SerpGoogleDatasetSearchTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetSearchTaskGetAdvanced"></a>
# **googleDatasetSearchTaskGetAdvanced**
> SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo googleDatasetSearchTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleDatasetSearchTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo**](SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetSearchLiveAdvanced"></a>
# **googleDatasetSearchLiveAdvanced**
> SerpGoogleDatasetSearchLiveAdvancedResponseInfo googleDatasetSearchLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetSearchLiveAdvancedAsync(new List<SerpGoogleDatasetSearchLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "water quality",
        LastUpdated = "1m",
        FileFormats = new List<string>()
        {
            "archive",
            "image",
        },
        UsageRights = "noncommercial",
        IsFree = true,
        Topics = new List<string>()
        {
            "natural_sciences",
            "geo",
        },
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleDatasetSearchLiveAdvancedResponseInfo**](SerpGoogleDatasetSearchLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetInfoTaskPost"></a>
# **googleDatasetInfoTaskPost**
> SerpGoogleDatasetInfoTaskPostResponseInfo googleDatasetInfoTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetInfoTaskPostAsync(new List<SerpGoogleDatasetInfoTaskPostRequestInfo>()
{
    new()
    {
        DatasetId = "L2cvMTFqbl85ZHN6MQ==",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleDatasetInfoTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleDatasetInfoTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleDatasetInfoTaskPostResponseInfo**](SerpGoogleDatasetInfoTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetInfoTasksReady"></a>
# **googleDatasetInfoTasksReady**
> SerpGoogleDatasetInfoTasksReadyResponseInfo googleDatasetInfoTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetInfoTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleDatasetInfoTasksReadyResponseInfo**](SerpGoogleDatasetInfoTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetInfoTasksFixed"></a>
# **googleDatasetInfoTasksFixed**
> SerpGoogleDatasetInfoTasksFixedResponseInfo googleDatasetInfoTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetInfoTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleDatasetInfoTasksFixedResponseInfo**](SerpGoogleDatasetInfoTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetInfoTaskGetAdvanced"></a>
# **googleDatasetInfoTaskGetAdvanced**
> SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo googleDatasetInfoTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleDatasetInfoTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo**](SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDatasetInfoLiveAdvanced"></a>
# **googleDatasetInfoLiveAdvanced**
> SerpGoogleDatasetInfoLiveAdvancedResponseInfo googleDatasetInfoLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleDatasetInfoLiveAdvancedAsync(new List<SerpGoogleDatasetInfoLiveAdvancedRequestInfo>()
{
    new()
    {
        DatasetId = "L2cvMTFqbl85ZHN6MQ==",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleDatasetInfoLiveAdvancedResponseInfo**](SerpGoogleDatasetInfoLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpGoogleAdsAdvertisersLocations"></a>
# **serpGoogleAdsAdvertisersLocations**
> SerpGoogleAdsAdvertisersLocationsResponseInfo serpGoogleAdsAdvertisersLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpGoogleAdsAdvertisersLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAdsAdvertisersLocationsResponseInfo**](SerpGoogleAdsAdvertisersLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsAdvertisersTaskPost"></a>
# **googleAdsAdvertisersTaskPost**
> SerpGoogleAdsAdvertisersTaskPostResponseInfo googleAdsAdvertisersTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAdsAdvertisersTaskPostAsync(new List<SerpGoogleAdsAdvertisersTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "apple",
        LocationCode = 2840,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleAdsAdvertisersTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleAdsAdvertisersTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleAdsAdvertisersTaskPostResponseInfo**](SerpGoogleAdsAdvertisersTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsAdvertisersTasksReady"></a>
# **googleAdsAdvertisersTasksReady**
> SerpGoogleAdsAdvertisersTasksReadyResponseInfo googleAdsAdvertisersTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAdsAdvertisersTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAdsAdvertisersTasksReadyResponseInfo**](SerpGoogleAdsAdvertisersTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsAdvertisersTaskGetAdvanced"></a>
# **googleAdsAdvertisersTaskGetAdvanced**
> SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo googleAdsAdvertisersTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleAdsAdvertisersTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo**](SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpGoogleAdsSearchLocations"></a>
# **serpGoogleAdsSearchLocations**
> SerpGoogleAdsSearchLocationsResponseInfo serpGoogleAdsSearchLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpGoogleAdsSearchLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAdsSearchLocationsResponseInfo**](SerpGoogleAdsSearchLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsSearchTaskPost"></a>
# **googleAdsSearchTaskPost**
> SerpGoogleAdsSearchTaskPostResponseInfo googleAdsSearchTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAdsSearchTaskPostAsync(new List<SerpGoogleAdsSearchTaskPostRequestInfo>()
{
    new()
    {
        AdvertiserIds = new List<string>()
        {
            "AR13752565271262920705",
            "AR02439908557932462081",
        },
        LocationCode = 2840,
        Platform = "google_search",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleAdsSearchTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleAdsSearchTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleAdsSearchTaskPostResponseInfo**](SerpGoogleAdsSearchTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsSearchTasksReady"></a>
# **googleAdsSearchTasksReady**
> SerpGoogleAdsSearchTasksReadyResponseInfo googleAdsSearchTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleAdsSearchTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAdsSearchTasksReadyResponseInfo**](SerpGoogleAdsSearchTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsSearchTaskGetAdvanced"></a>
# **googleAdsSearchTaskGetAdvanced**
> SerpGoogleAdsSearchTaskGetAdvancedResponseInfo googleAdsSearchTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleAdsSearchTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleAdsSearchTaskGetAdvancedResponseInfo**](SerpGoogleAdsSearchTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpBingLocations"></a>
# **serpBingLocations**
> SerpBingLocationsResponseInfo serpBingLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpBingLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingLocationsResponseInfo**](SerpBingLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpBingLocationsCountry"></a>
# **serpBingLocationsCountry**
> SerpBingLocationsCountryResponseInfo serpBingLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.SerpApi.SerpBingLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingLocationsCountryResponseInfo**](SerpBingLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpBingLanguages"></a>
# **serpBingLanguages**
> SerpBingLanguagesResponseInfo serpBingLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpBingLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingLanguagesResponseInfo**](SerpBingLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicTaskPost"></a>
# **bingOrganicTaskPost**
> SerpBingOrganicTaskPostResponseInfo bingOrganicTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingOrganicTaskPostAsync(new List<SerpBingOrganicTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBingOrganicTaskPostRequestInfo>&gt;**](IEnumerable<SerpBingOrganicTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBingOrganicTaskPostResponseInfo**](SerpBingOrganicTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicTasksReady"></a>
# **bingOrganicTasksReady**
> SerpBingOrganicTasksReadyResponseInfo bingOrganicTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingOrganicTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingOrganicTasksReadyResponseInfo**](SerpBingOrganicTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicTasksFixed"></a>
# **bingOrganicTasksFixed**
> SerpBingOrganicTasksFixedResponseInfo bingOrganicTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingOrganicTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingOrganicTasksFixedResponseInfo**](SerpBingOrganicTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicTaskGetRegular"></a>
# **bingOrganicTaskGetRegular**
> SerpBingOrganicTaskGetRegularResponseInfo bingOrganicTaskGetRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BingOrganicTaskGetRegularAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingOrganicTaskGetRegularResponseInfo**](SerpBingOrganicTaskGetRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicTaskGetAdvanced"></a>
# **bingOrganicTaskGetAdvanced**
> SerpBingOrganicTaskGetAdvancedResponseInfo bingOrganicTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BingOrganicTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingOrganicTaskGetAdvancedResponseInfo**](SerpBingOrganicTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicTaskGetHtml"></a>
# **bingOrganicTaskGetHtml**
> SerpBingOrganicTaskGetHtmlResponseInfo bingOrganicTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BingOrganicTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingOrganicTaskGetHtmlResponseInfo**](SerpBingOrganicTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicLiveRegular"></a>
# **bingOrganicLiveRegular**
> SerpBingOrganicLiveRegularResponseInfo bingOrganicLiveRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingOrganicLiveRegularAsync(new List<SerpBingOrganicLiveRegularRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBingOrganicLiveRegularRequestInfo>&gt;**](IEnumerable<SerpBingOrganicLiveRegularRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBingOrganicLiveRegularResponseInfo**](SerpBingOrganicLiveRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicLiveAdvanced"></a>
# **bingOrganicLiveAdvanced**
> SerpBingOrganicLiveAdvancedResponseInfo bingOrganicLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingOrganicLiveAdvancedAsync(new List<SerpBingOrganicLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "flight ticket new york san francisco",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBingOrganicLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpBingOrganicLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBingOrganicLiveAdvancedResponseInfo**](SerpBingOrganicLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingOrganicLiveHtml"></a>
# **bingOrganicLiveHtml**
> SerpBingOrganicLiveHtmlResponseInfo bingOrganicLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingOrganicLiveHtmlAsync(new List<SerpBingOrganicLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBingOrganicLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpBingOrganicLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBingOrganicLiveHtmlResponseInfo**](SerpBingOrganicLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingLocalPackTaskPost"></a>
# **bingLocalPackTaskPost**
> SerpBingLocalPackTaskPostResponseInfo bingLocalPackTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingLocalPackTaskPostAsync(new List<SerpBingLocalPackTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBingLocalPackTaskPostRequestInfo>&gt;**](IEnumerable<SerpBingLocalPackTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBingLocalPackTaskPostResponseInfo**](SerpBingLocalPackTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingLocalPackTasksReady"></a>
# **bingLocalPackTasksReady**
> SerpBingLocalPackTasksReadyResponseInfo bingLocalPackTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingLocalPackTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingLocalPackTasksReadyResponseInfo**](SerpBingLocalPackTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingLocalPackTasksFixed"></a>
# **bingLocalPackTasksFixed**
> SerpBingLocalPackTasksFixedResponseInfo bingLocalPackTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingLocalPackTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingLocalPackTasksFixedResponseInfo**](SerpBingLocalPackTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingLocalPackTaskGetRegular"></a>
# **bingLocalPackTaskGetRegular**
> SerpBingLocalPackTaskGetRegularResponseInfo bingLocalPackTaskGetRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BingLocalPackTaskGetRegularAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingLocalPackTaskGetRegularResponseInfo**](SerpBingLocalPackTaskGetRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingLocalPackTaskGetHtml"></a>
# **bingLocalPackTaskGetHtml**
> SerpBingLocalPackTaskGetHtmlResponseInfo bingLocalPackTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BingLocalPackTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBingLocalPackTaskGetHtmlResponseInfo**](SerpBingLocalPackTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingLocalPackLiveRegular"></a>
# **bingLocalPackLiveRegular**
> SerpBingLocalPackLiveRegularResponseInfo bingLocalPackLiveRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingLocalPackLiveRegularAsync(new List<SerpBingLocalPackLiveRegularRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBingLocalPackLiveRegularRequestInfo>&gt;**](IEnumerable<SerpBingLocalPackLiveRegularRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBingLocalPackLiveRegularResponseInfo**](SerpBingLocalPackLiveRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingLocalPackLiveHtml"></a>
# **bingLocalPackLiveHtml**
> SerpBingLocalPackLiveHtmlResponseInfo bingLocalPackLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BingLocalPackLiveHtmlAsync(new List<SerpBingLocalPackLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBingLocalPackLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpBingLocalPackLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBingLocalPackLiveHtmlResponseInfo**](SerpBingLocalPackLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpYoutubeLocations"></a>
# **serpYoutubeLocations**
> SerpYoutubeLocationsResponseInfo serpYoutubeLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpYoutubeLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeLocationsResponseInfo**](SerpYoutubeLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpYoutubeLocationsCountry"></a>
# **serpYoutubeLocationsCountry**
> SerpYoutubeLocationsCountryResponseInfo serpYoutubeLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.SerpApi.SerpYoutubeLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeLocationsCountryResponseInfo**](SerpYoutubeLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpYoutubeLanguages"></a>
# **serpYoutubeLanguages**
> SerpYoutubeLanguagesResponseInfo serpYoutubeLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpYoutubeLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeLanguagesResponseInfo**](SerpYoutubeLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoInfoTaskPost"></a>
# **youtubeVideoInfoTaskPost**
> SerpYoutubeVideoInfoTaskPostResponseInfo youtubeVideoInfoTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoInfoTaskPostAsync(new List<SerpYoutubeVideoInfoTaskPostRequestInfo>()
{
    new()
    {
        VideoId = "vQXvyV0zIP4",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo>&gt;**](IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYoutubeVideoInfoTaskPostResponseInfo**](SerpYoutubeVideoInfoTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoInfoTasksReady"></a>
# **youtubeVideoInfoTasksReady**
> SerpYoutubeVideoInfoTasksReadyResponseInfo youtubeVideoInfoTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoInfoTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoInfoTasksReadyResponseInfo**](SerpYoutubeVideoInfoTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoInfoTasksFixed"></a>
# **youtubeVideoInfoTasksFixed**
> SerpYoutubeVideoInfoTasksFixedResponseInfo youtubeVideoInfoTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoInfoTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoInfoTasksFixedResponseInfo**](SerpYoutubeVideoInfoTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoInfoTaskGetAdvanced"></a>
# **youtubeVideoInfoTaskGetAdvanced**
> SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo youtubeVideoInfoTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.YoutubeVideoInfoTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo**](SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoInfoLiveAdvanced"></a>
# **youtubeVideoInfoLiveAdvanced**
> SerpYoutubeVideoInfoLiveAdvancedResponseInfo youtubeVideoInfoLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoInfoLiveAdvancedAsync(new List<SerpYoutubeVideoInfoLiveAdvancedRequestInfo>()
{
    new()
    {
        VideoId = "vQXvyV0zIP4",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYoutubeVideoInfoLiveAdvancedResponseInfo**](SerpYoutubeVideoInfoLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoSubtitlesTaskPost"></a>
# **youtubeVideoSubtitlesTaskPost**
> SerpYoutubeVideoSubtitlesTaskPostResponseInfo youtubeVideoSubtitlesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoSubtitlesTaskPostAsync(new List<SerpYoutubeVideoSubtitlesTaskPostRequestInfo>()
{
    new()
    {
        VideoId = "Y8Wu4rSNJms",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYoutubeVideoSubtitlesTaskPostRequestInfo>&gt;**](IEnumerable<SerpYoutubeVideoSubtitlesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYoutubeVideoSubtitlesTaskPostResponseInfo**](SerpYoutubeVideoSubtitlesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoSubtitlesTasksReady"></a>
# **youtubeVideoSubtitlesTasksReady**
> SerpYoutubeVideoSubtitlesTasksReadyResponseInfo youtubeVideoSubtitlesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoSubtitlesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoSubtitlesTasksReadyResponseInfo**](SerpYoutubeVideoSubtitlesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoSubtitlesTasksFixed"></a>
# **youtubeVideoSubtitlesTasksFixed**
> SerpYoutubeVideoSubtitlesTasksFixedResponseInfo youtubeVideoSubtitlesTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoSubtitlesTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoSubtitlesTasksFixedResponseInfo**](SerpYoutubeVideoSubtitlesTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoSubtitlesTaskGetAdvanced"></a>
# **youtubeVideoSubtitlesTaskGetAdvanced**
> SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo youtubeVideoSubtitlesTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.YoutubeVideoSubtitlesTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo**](SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoSubtitlesLiveAdvanced"></a>
# **youtubeVideoSubtitlesLiveAdvanced**
> SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo youtubeVideoSubtitlesLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoSubtitlesLiveAdvancedAsync(new List<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo>()
{
    new()
    {
        VideoId = "Y8Wu4rSNJms",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo**](SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoCommentsTaskPost"></a>
# **youtubeVideoCommentsTaskPost**
> SerpYoutubeVideoCommentsTaskPostResponseInfo youtubeVideoCommentsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoCommentsTaskPostAsync(new List<SerpYoutubeVideoCommentsTaskPostRequestInfo>()
{
    new()
    {
        VideoId = "vQXvyV0zIP4",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYoutubeVideoCommentsTaskPostRequestInfo>&gt;**](IEnumerable<SerpYoutubeVideoCommentsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYoutubeVideoCommentsTaskPostResponseInfo**](SerpYoutubeVideoCommentsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoCommentsTasksReady"></a>
# **youtubeVideoCommentsTasksReady**
> SerpYoutubeVideoCommentsTasksReadyResponseInfo youtubeVideoCommentsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoCommentsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoCommentsTasksReadyResponseInfo**](SerpYoutubeVideoCommentsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoCommentsTasksFixed"></a>
# **youtubeVideoCommentsTasksFixed**
> SerpYoutubeVideoCommentsTasksFixedResponseInfo youtubeVideoCommentsTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoCommentsTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoCommentsTasksFixedResponseInfo**](SerpYoutubeVideoCommentsTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoCommentsTaskGetAdvanced"></a>
# **youtubeVideoCommentsTaskGetAdvanced**
> SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo youtubeVideoCommentsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.YoutubeVideoCommentsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo**](SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="youtubeVideoCommentsLiveAdvanced"></a>
# **youtubeVideoCommentsLiveAdvanced**
> SerpYoutubeVideoCommentsLiveAdvancedResponseInfo youtubeVideoCommentsLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YoutubeVideoCommentsLiveAdvancedAsync(new List<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo>()
{
    new()
    {
        VideoId = "vQXvyV0zIP4",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYoutubeVideoCommentsLiveAdvancedResponseInfo**](SerpYoutubeVideoCommentsLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpYahooLocations"></a>
# **serpYahooLocations**
> SerpYahooLocationsResponseInfo serpYahooLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpYahooLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooLocationsResponseInfo**](SerpYahooLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpYahooLocationsCountry"></a>
# **serpYahooLocationsCountry**
> SerpYahooLocationsCountryResponseInfo serpYahooLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.SerpApi.SerpYahooLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooLocationsCountryResponseInfo**](SerpYahooLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpYahooLanguages"></a>
# **serpYahooLanguages**
> SerpYahooLanguagesResponseInfo serpYahooLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpYahooLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooLanguagesResponseInfo**](SerpYahooLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicTaskPost"></a>
# **yahooOrganicTaskPost**
> SerpYahooOrganicTaskPostResponseInfo yahooOrganicTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YahooOrganicTaskPostAsync(new List<SerpYahooOrganicTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYahooOrganicTaskPostRequestInfo>&gt;**](IEnumerable<SerpYahooOrganicTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYahooOrganicTaskPostResponseInfo**](SerpYahooOrganicTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicTasksReady"></a>
# **yahooOrganicTasksReady**
> SerpYahooOrganicTasksReadyResponseInfo yahooOrganicTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YahooOrganicTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooOrganicTasksReadyResponseInfo**](SerpYahooOrganicTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicTasksFixed"></a>
# **yahooOrganicTasksFixed**
> SerpYahooOrganicTasksFixedResponseInfo yahooOrganicTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YahooOrganicTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooOrganicTasksFixedResponseInfo**](SerpYahooOrganicTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicTaskGetRegular"></a>
# **yahooOrganicTaskGetRegular**
> SerpYahooOrganicTaskGetRegularResponseInfo yahooOrganicTaskGetRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.YahooOrganicTaskGetRegularAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooOrganicTaskGetRegularResponseInfo**](SerpYahooOrganicTaskGetRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicTaskGetAdvanced"></a>
# **yahooOrganicTaskGetAdvanced**
> SerpYahooOrganicTaskGetAdvancedResponseInfo yahooOrganicTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.YahooOrganicTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooOrganicTaskGetAdvancedResponseInfo**](SerpYahooOrganicTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicTaskGetHtml"></a>
# **yahooOrganicTaskGetHtml**
> SerpYahooOrganicTaskGetHtmlResponseInfo yahooOrganicTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.YahooOrganicTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpYahooOrganicTaskGetHtmlResponseInfo**](SerpYahooOrganicTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicLiveRegular"></a>
# **yahooOrganicLiveRegular**
> SerpYahooOrganicLiveRegularResponseInfo yahooOrganicLiveRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YahooOrganicLiveRegularAsync(new List<SerpYahooOrganicLiveRegularRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYahooOrganicLiveRegularRequestInfo>&gt;**](IEnumerable<SerpYahooOrganicLiveRegularRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYahooOrganicLiveRegularResponseInfo**](SerpYahooOrganicLiveRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicLiveAdvanced"></a>
# **yahooOrganicLiveAdvanced**
> SerpYahooOrganicLiveAdvancedResponseInfo yahooOrganicLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YahooOrganicLiveAdvancedAsync(new List<SerpYahooOrganicLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYahooOrganicLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpYahooOrganicLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYahooOrganicLiveAdvancedResponseInfo**](SerpYahooOrganicLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="yahooOrganicLiveHtml"></a>
# **yahooOrganicLiveHtml**
> SerpYahooOrganicLiveHtmlResponseInfo yahooOrganicLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.YahooOrganicLiveHtmlAsync(new List<SerpYahooOrganicLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpYahooOrganicLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpYahooOrganicLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpYahooOrganicLiveHtmlResponseInfo**](SerpYahooOrganicLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpBaiduLocations"></a>
# **serpBaiduLocations**
> SerpBaiduLocationsResponseInfo serpBaiduLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpBaiduLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduLocationsResponseInfo**](SerpBaiduLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpBaiduLocationsCountry"></a>
# **serpBaiduLocationsCountry**
> SerpBaiduLocationsCountryResponseInfo serpBaiduLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.SerpApi.SerpBaiduLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduLocationsCountryResponseInfo**](SerpBaiduLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpBaiduLanguages"></a>
# **serpBaiduLanguages**
> SerpBaiduLanguagesResponseInfo serpBaiduLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpBaiduLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduLanguagesResponseInfo**](SerpBaiduLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="baiduOrganicTaskPost"></a>
# **baiduOrganicTaskPost**
> SerpBaiduOrganicTaskPostResponseInfo baiduOrganicTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BaiduOrganicTaskPostAsync(new List<SerpBaiduOrganicTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "best iphone ever",
        Priority = 2,
        LocationCode = 2156,
        Tag = "some_string_123",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpBaiduOrganicTaskPostRequestInfo>&gt;**](IEnumerable<SerpBaiduOrganicTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpBaiduOrganicTaskPostResponseInfo**](SerpBaiduOrganicTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="baiduOrganicTasksReady"></a>
# **baiduOrganicTasksReady**
> SerpBaiduOrganicTasksReadyResponseInfo baiduOrganicTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BaiduOrganicTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduOrganicTasksReadyResponseInfo**](SerpBaiduOrganicTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="baiduOrganicTasksFixed"></a>
# **baiduOrganicTasksFixed**
> SerpBaiduOrganicTasksFixedResponseInfo baiduOrganicTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.BaiduOrganicTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduOrganicTasksFixedResponseInfo**](SerpBaiduOrganicTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="baiduOrganicTaskGetRegular"></a>
# **baiduOrganicTaskGetRegular**
> SerpBaiduOrganicTaskGetRegularResponseInfo baiduOrganicTaskGetRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BaiduOrganicTaskGetRegularAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduOrganicTaskGetRegularResponseInfo**](SerpBaiduOrganicTaskGetRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="baiduOrganicTaskGetAdvanced"></a>
# **baiduOrganicTaskGetAdvanced**
> SerpBaiduOrganicTaskGetAdvancedResponseInfo baiduOrganicTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BaiduOrganicTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduOrganicTaskGetAdvancedResponseInfo**](SerpBaiduOrganicTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="baiduOrganicTaskGetHtml"></a>
# **baiduOrganicTaskGetHtml**
> SerpBaiduOrganicTaskGetHtmlResponseInfo baiduOrganicTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.BaiduOrganicTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpBaiduOrganicTaskGetHtmlResponseInfo**](SerpBaiduOrganicTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="naverOrganicTaskPost"></a>
# **naverOrganicTaskPost**
> SerpNaverOrganicTaskPostResponseInfo naverOrganicTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.NaverOrganicTaskPostAsync(new List<SerpNaverOrganicTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        Device = "desktop",
        Tag = "some_string_123",
        PostbackUrl = "https://your-server.com/postbackscript.php",
        PostbackData = "regular",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpNaverOrganicTaskPostRequestInfo>&gt;**](IEnumerable<SerpNaverOrganicTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpNaverOrganicTaskPostResponseInfo**](SerpNaverOrganicTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="naverOrganicTasksReady"></a>
# **naverOrganicTasksReady**
> SerpNaverOrganicTasksReadyResponseInfo naverOrganicTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.NaverOrganicTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpNaverOrganicTasksReadyResponseInfo**](SerpNaverOrganicTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="naverOrganicTasksFixed"></a>
# **naverOrganicTasksFixed**
> SerpNaverOrganicTasksFixedResponseInfo naverOrganicTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.NaverOrganicTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpNaverOrganicTasksFixedResponseInfo**](SerpNaverOrganicTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="naverOrganicTaskGetRegular"></a>
# **naverOrganicTaskGetRegular**
> SerpNaverOrganicTaskGetRegularResponseInfo naverOrganicTaskGetRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.NaverOrganicTaskGetRegularAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpNaverOrganicTaskGetRegularResponseInfo**](SerpNaverOrganicTaskGetRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="naverOrganicTaskGetAdvanced"></a>
# **naverOrganicTaskGetAdvanced**
> SerpNaverOrganicTaskGetAdvancedResponseInfo naverOrganicTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.NaverOrganicTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpNaverOrganicTaskGetAdvancedResponseInfo**](SerpNaverOrganicTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="naverOrganicTaskGetHtml"></a>
# **naverOrganicTaskGetHtml**
> SerpNaverOrganicTaskGetHtmlResponseInfo naverOrganicTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.NaverOrganicTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpNaverOrganicTaskGetHtmlResponseInfo**](SerpNaverOrganicTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpSeznamLocations"></a>
# **serpSeznamLocations**
> SerpSeznamLocationsResponseInfo serpSeznamLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpSeznamLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamLocationsResponseInfo**](SerpSeznamLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpSeznamLocationsCountry"></a>
# **serpSeznamLocationsCountry**
> SerpSeznamLocationsCountryResponseInfo serpSeznamLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.SerpApi.SerpSeznamLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamLocationsCountryResponseInfo**](SerpSeznamLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="serpSeznamLanguages"></a>
# **serpSeznamLanguages**
> SerpSeznamLanguagesResponseInfo serpSeznamLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SerpSeznamLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamLanguagesResponseInfo**](SerpSeznamLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="seznamOrganicTaskPost"></a>
# **seznamOrganicTaskPost**
> SerpSeznamOrganicTaskPostResponseInfo seznamOrganicTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SeznamOrganicTaskPostAsync(new List<SerpSeznamOrganicTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2203,
        LanguageCode = "cs",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpSeznamOrganicTaskPostRequestInfo>&gt;**](IEnumerable<SerpSeznamOrganicTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpSeznamOrganicTaskPostResponseInfo**](SerpSeznamOrganicTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="seznamOrganicTasksReady"></a>
# **seznamOrganicTasksReady**
> SerpSeznamOrganicTasksReadyResponseInfo seznamOrganicTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SeznamOrganicTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamOrganicTasksReadyResponseInfo**](SerpSeznamOrganicTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="seznamOrganicTasksFixed"></a>
# **seznamOrganicTasksFixed**
> SerpSeznamOrganicTasksFixedResponseInfo seznamOrganicTasksFixed()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.SeznamOrganicTasksFixedAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamOrganicTasksFixedResponseInfo**](SerpSeznamOrganicTasksFixedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="seznamOrganicTaskGetRegular"></a>
# **seznamOrganicTaskGetRegular**
> SerpSeznamOrganicTaskGetRegularResponseInfo seznamOrganicTaskGetRegular()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.SeznamOrganicTaskGetRegularAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamOrganicTaskGetRegularResponseInfo**](SerpSeznamOrganicTaskGetRegularResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="seznamOrganicTaskGetAdvanced"></a>
# **seznamOrganicTaskGetAdvanced**
> SerpSeznamOrganicTaskGetAdvancedResponseInfo seznamOrganicTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.SeznamOrganicTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamOrganicTaskGetAdvancedResponseInfo**](SerpSeznamOrganicTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="seznamOrganicTaskGetHtml"></a>
# **seznamOrganicTaskGetHtml**
> SerpSeznamOrganicTaskGetHtmlResponseInfo seznamOrganicTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.SeznamOrganicTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpSeznamOrganicTaskGetHtmlResponseInfo**](SerpSeznamOrganicTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceExploreTaskPost"></a>
# **googleFinanceExploreTaskPost**
> SerpGoogleFinanceExploreTaskPostResponseInfo googleFinanceExploreTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceExploreTaskPostAsync(new List<SerpGoogleFinanceExploreTaskPostRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceExploreTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceExploreTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceExploreTaskPostResponseInfo**](SerpGoogleFinanceExploreTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceExploreTasksReady"></a>
# **googleFinanceExploreTasksReady**
> SerpGoogleFinanceExploreTasksReadyResponseInfo googleFinanceExploreTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceExploreTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceExploreTasksReadyResponseInfo**](SerpGoogleFinanceExploreTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceExploreTaskGetAdvanced"></a>
# **googleFinanceExploreTaskGetAdvanced**
> SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo googleFinanceExploreTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleFinanceExploreTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo**](SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceExploreTaskGetHtml"></a>
# **googleFinanceExploreTaskGetHtml**
> SerpGoogleFinanceExploreTaskGetHtmlResponseInfo googleFinanceExploreTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleFinanceExploreTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceExploreTaskGetHtmlResponseInfo**](SerpGoogleFinanceExploreTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceExploreLiveAdvanced"></a>
# **googleFinanceExploreLiveAdvanced**
> SerpGoogleFinanceExploreLiveAdvancedResponseInfo googleFinanceExploreLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceExploreLiveAdvancedAsync(new List<SerpGoogleFinanceExploreLiveAdvancedRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceExploreLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceExploreLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceExploreLiveAdvancedResponseInfo**](SerpGoogleFinanceExploreLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceExploreLiveHtml"></a>
# **googleFinanceExploreLiveHtml**
> SerpGoogleFinanceExploreLiveHtmlResponseInfo googleFinanceExploreLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceExploreLiveHtmlAsync(new List<SerpGoogleFinanceExploreLiveHtmlRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceExploreLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceExploreLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceExploreLiveHtmlResponseInfo**](SerpGoogleFinanceExploreLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceMarketsTaskPost"></a>
# **googleFinanceMarketsTaskPost**
> SerpGoogleFinanceMarketsTaskPostResponseInfo googleFinanceMarketsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceMarketsTaskPostAsync(new List<SerpGoogleFinanceMarketsTaskPostRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceMarketsTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceMarketsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceMarketsTaskPostResponseInfo**](SerpGoogleFinanceMarketsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceMarketsTasksReady"></a>
# **googleFinanceMarketsTasksReady**
> SerpGoogleFinanceMarketsTasksReadyResponseInfo googleFinanceMarketsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceMarketsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceMarketsTasksReadyResponseInfo**](SerpGoogleFinanceMarketsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceMarketsTaskGetAdvanced"></a>
# **googleFinanceMarketsTaskGetAdvanced**
> SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo googleFinanceMarketsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleFinanceMarketsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo**](SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceMarketsTaskGetHtml"></a>
# **googleFinanceMarketsTaskGetHtml**
> SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo googleFinanceMarketsTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleFinanceMarketsTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo**](SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceMarketsLiveAdvanced"></a>
# **googleFinanceMarketsLiveAdvanced**
> SerpGoogleFinanceMarketsLiveAdvancedResponseInfo googleFinanceMarketsLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceMarketsLiveAdvancedAsync(new List<SerpGoogleFinanceMarketsLiveAdvancedRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceMarketsLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceMarketsLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceMarketsLiveAdvancedResponseInfo**](SerpGoogleFinanceMarketsLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceMarketsLiveHtml"></a>
# **googleFinanceMarketsLiveHtml**
> SerpGoogleFinanceMarketsLiveHtmlResponseInfo googleFinanceMarketsLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceMarketsLiveHtmlAsync(new List<SerpGoogleFinanceMarketsLiveHtmlRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceMarketsLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceMarketsLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceMarketsLiveHtmlResponseInfo**](SerpGoogleFinanceMarketsLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceQuoteTaskPost"></a>
# **googleFinanceQuoteTaskPost**
> SerpGoogleFinanceQuoteTaskPostResponseInfo googleFinanceQuoteTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceQuoteTaskPostAsync(new List<SerpGoogleFinanceQuoteTaskPostRequestInfo>()
{
    new()
    {
        Keyword = ".DJI:INDEXDJX",
        LocationCode = 2840,
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceQuoteTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceQuoteTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceQuoteTaskPostResponseInfo**](SerpGoogleFinanceQuoteTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceQuoteTasksReady"></a>
# **googleFinanceQuoteTasksReady**
> SerpGoogleFinanceQuoteTasksReadyResponseInfo googleFinanceQuoteTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceQuoteTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceQuoteTasksReadyResponseInfo**](SerpGoogleFinanceQuoteTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceQuoteTaskGetAdvanced"></a>
# **googleFinanceQuoteTaskGetAdvanced**
> SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo googleFinanceQuoteTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleFinanceQuoteTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo**](SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceQuoteTaskGetHtml"></a>
# **googleFinanceQuoteTaskGetHtml**
> SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo googleFinanceQuoteTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleFinanceQuoteTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo**](SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceQuoteLiveAdvanced"></a>
# **googleFinanceQuoteLiveAdvanced**
> SerpGoogleFinanceQuoteLiveAdvancedResponseInfo googleFinanceQuoteLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceQuoteLiveAdvancedAsync(new List<SerpGoogleFinanceQuoteLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "CLW00:NYMEX",
        LocationCode = 2840,
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceQuoteLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceQuoteLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceQuoteLiveAdvancedResponseInfo**](SerpGoogleFinanceQuoteLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceQuoteLiveHtml"></a>
# **googleFinanceQuoteLiveHtml**
> SerpGoogleFinanceQuoteLiveHtmlResponseInfo googleFinanceQuoteLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceQuoteLiveHtmlAsync(new List<SerpGoogleFinanceQuoteLiveHtmlRequestInfo>()
{
    new()
    {
        Keyword = "NASDAQ-100",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceQuoteLiveHtmlRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceQuoteLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceQuoteLiveHtmlResponseInfo**](SerpGoogleFinanceQuoteLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceTickerSearchTaskPost"></a>
# **googleFinanceTickerSearchTaskPost**
> SerpGoogleFinanceTickerSearchTaskPostResponseInfo googleFinanceTickerSearchTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceTickerSearchTaskPostAsync(new List<SerpGoogleFinanceTickerSearchTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "DJ",
        LocationCode = 2840,
        LanguageName = "English",
        Priority = 2,
        Category = "all",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceTickerSearchTaskPostRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceTickerSearchTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceTickerSearchTaskPostResponseInfo**](SerpGoogleFinanceTickerSearchTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceTickerSearchTasksReady"></a>
# **googleFinanceTickerSearchTasksReady**
> SerpGoogleFinanceTickerSearchTasksReadyResponseInfo googleFinanceTickerSearchTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceTickerSearchTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceTickerSearchTasksReadyResponseInfo**](SerpGoogleFinanceTickerSearchTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceTickerSearchTaskGetAdvanced"></a>
# **googleFinanceTickerSearchTaskGetAdvanced**
> SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo googleFinanceTickerSearchTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.SerpApi.GoogleFinanceTickerSearchTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo**](SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleFinanceTickerSearchLiveAdvanced"></a>
# **googleFinanceTickerSearchLiveAdvanced**
> SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo googleFinanceTickerSearchLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.SerpApi.GoogleFinanceTickerSearchLiveAdvancedAsync(new List<SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo>()
{
    new()
    {
        Keyword = "DJ",
        LocationCode = 2840,
        LanguageName = "English",
        Category = "all",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo>&gt;**](IEnumerable<SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo**](SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |