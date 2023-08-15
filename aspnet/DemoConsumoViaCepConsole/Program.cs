try
{
    Console.WriteLine("ConsultarV1:");
    var resultado = await ViaCepConsumidor.ConsultarV1("01001000");
    Console.WriteLine(resultado.IsSuccessStatusCode);
    Console.WriteLine(resultado.StatusCode);
    var dados = await resultado.Content.ReadAsStringAsync();
    Console.WriteLine(dados);

    Console.WriteLine("ConsultarV2:");
    var resultadoV2 = await ViaCepConsumidor.ConsultarV2("01001000");
    Console.WriteLine(resultadoV2);

    Console.WriteLine("ConsultarV3:");
    var resultadoV3 = await ViaCepConsumidor.ConsultarV3("01001000");
    if (resultadoV3 != null) {
        Console.WriteLine(resultadoV3.Cep);
        Console.WriteLine(resultadoV3.Uf);
    }
}
catch (Exception e)
{
    Console.WriteLine("Falha:");
    Console.WriteLine(e.Message);
}
