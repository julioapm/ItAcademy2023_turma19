try
{
    Console.WriteLine("ConsultarV1:");
    var resultado = await ViaCepConsumidor.ConsultarV1("01001000");
    Console.WriteLine(resultado.IsSuccessStatusCode);
    Console.WriteLine(resultado.StatusCode);
    var dados = await resultado.Content.ReadAsStringAsync();
    Console.WriteLine(dados);
}
catch (Exception e)
{
    Console.WriteLine("Falha:");
    Console.WriteLine(e.Message);
}
