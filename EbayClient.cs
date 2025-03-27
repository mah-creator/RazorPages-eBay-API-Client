using System.Net.Http;
using Microsoft.Extensions.Configuration;

class EbayClient: HttpClient
{
    public EbayClient(): base()
    {}
}