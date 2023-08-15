public class ViaCepConsumidor
{
    public const string URI_BASE = "https://viacep.com.br/ws";
    private static readonly HttpClient cliente = new HttpClient();

    public static Task<HttpResponseMessage> ConsultarV1(string cep)
    {
        string uri = $"{URI_BASE}/{cep}/json";
        return cliente.GetAsync(uri);
    }
    
}