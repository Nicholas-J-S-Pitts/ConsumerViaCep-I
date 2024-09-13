using static System.Console;

WriteLine("Digite o seu CEP: ");
var cep= ReadLine();

WriteLine("Realizando aquisição na API... ");
var enderecoUrl = $@"https://viacep.com.br/ws/{cep}/json/";
var cliente = new HttpClient();
try {
    HttpResponseMessage? resposta = await cliente.GetAsync(enderecoUrl);
    resposta.EnsureSuccessStatusCode();
    string respostaApiString = await resposta.Content.ReadAsStringAsync();
    WriteLine(respostaApiString);
} 
catch (SystemException) 
{
    WriteLine("Erro da Api: " + e);
}