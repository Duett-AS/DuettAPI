﻿Usage
```CSHARP
var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://api.duett.no");
var apiClient = new DuettApiClient(httpClient, "integrationKey", "clientKey");
```