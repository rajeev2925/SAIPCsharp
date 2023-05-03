using System;
using PdfCo;

namespace PdfCoApiSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get your own API Key by registering at https://app.pdf.co/documentation/api
            PdfCoApi api = new PdfCoApi("YOUR_API_KEY");
            api.ProcessingCompleted += ProcessingCompleted;

            string url = api.UploadFile(@".\sample.pdf");
            api.PdfToCsv(url, pages: "", password: "", profiles: "", rect: "", unwrap: true, lineGrouping: "1", async: false);
            
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void ProcessingCompleted(PdfCoApi sender, ApiType apiType, ProcessingCompletedEventArgs e)
        {
            if (e.JobStatus != JobStatus.Success)
                Console.WriteLine("Error");

            if (e.Error != null)
                Console.WriteLine(e.Error.Message);

            if (e.ResultFileUrls.Length > 0)
            {
                foreach (string url in e.ResultFileUrls)
                    Console.WriteLine(url);
            }
            
            if (e.ResultJson.Length > 0)
                Console.WriteLine(e.ResultJson);
        }
    }
}
