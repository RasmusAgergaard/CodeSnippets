using System;
using System.Net.Http;

namespace AsyncAwait2
{
    class Program
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async void DownloadButtonClicked()
        {
            // This line will yield control to the UI as the request from the web service is happening.
            // The UI thread is now free to perform other work.
            var stringData = await _httpClient.GetStringAsync("www.test.nu");
        }

        //The code expresses the intent(downloading some data asynchronously) without getting bogged down in interacting with Task objects.
    }
}
