using System.Diagnostics;
using System.Net;
using System.Text.Json;

JsonSerializerOptions JoptionNoPreserve = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true
};

Console.WriteLine("Start");

using (var httpClient = new HttpClient { BaseAddress = new Uri("https://api-dev.duett.no") })
{
    Stopwatch timer = new Stopwatch();
    timer.Start();
    ConfigureClient(httpClient);

    var tokenSource = new CancellationTokenSource();
    var ct = tokenSource.Token;
    try
    {
        var res = await httpClient.GetAsync("/Report/v1/Bilag?RegnÅr=2019", HttpCompletionOption.ResponseHeadersRead, ct);
        res.EnsureSuccessStatusCode();
        var stream = await res.Content.ReadAsStreamAsync();
        var ae = JsonSerializer.DeserializeAsyncEnumerable<BilagModel>(stream, JoptionNoPreserve, ct);
        int c = 0;
        await foreach (var v in ae)
        {
            c++;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.Write($"VoucherLines {c} , voucherNumber:{v?.Bilag} , time elapsed:{timer.Elapsed}");

        }
        Console.WriteLine(" Done");
        Console.WriteLine("Press any key to exit the process...");
        Console.ReadKey();
        timer.Stop();
    }
    catch (Exception ex)
    {
        tokenSource.Cancel();
        Console.WriteLine("");
        Console.WriteLine(ex.ToString());
    }
}



void ConfigureClient(HttpClient httpClient)
{
    httpClient.DefaultRequestHeaders.Add("X-Api-Integration-Key", "b45a859a-3702-4259-a654-f985c6878975");
    httpClient.DefaultRequestHeaders.Add("X-Api-Client-Key", "dc27d992-ead4-4d80-95e0-95eed944f7c0");
    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
    httpClient.Timeout = TimeSpan.FromSeconds(120);
    httpClient.DefaultRequestVersion = HttpVersion.Version30;
    httpClient.MaxResponseContentBufferSize = int.MaxValue;
}

public partial class BilagModel
{
    public int Bilag { get; set; }
    public int BilagLinjenr { get; set; }
    public DateTime? Dato { get; set; }
    public string? Konto { get; set; }
    public string? Kontonavn { get; set; }
    public string? TypeKonto { get; set; }
    public decimal? BeløpBrutto { get; set; }
    public decimal? BeløpNetto { get; set; }
    public int Periode { get; set; }
    public int? Termin { get; set; }
    public string? RegnÅr { get; set; }
    public int? Ak { get; set; }
    public string? Aknavn { get; set; }
    public decimal? Aksats { get; set; }
    public decimal? Mengde1 { get; set; }
    public decimal? Mengde2 { get; set; }
    public int Art { get; set; }
    public string? ArtNavn { get; set; }
    public string? TypeArtNavn { get; set; }
    public string? Regnskapstype { get; set; }
    public int? SkjulesIbilagsreg { get; set; }
    public int? TilhørerBilagRef { get; set; }
    public string? Valutakode { get; set; }
    public decimal? Valutabeløp { get; set; }
    public string? Avdeling { get; set; }
    public string? Avdelingsnavn { get; set; }
    public string? Prosjekt { get; set; }
    public string? Prosjektnavn { get; set; }
    public string? Ansatt { get; set; }
    public string? Ansattnavn { get; set; }
    public string? Lotkode { get; set; }
    public string? RefNr { get; set; }
    public string? BrukerId { get; set; }
    public DateTime? Forfallsdato { get; set; }
    public string? Fritekst { get; set; }
    public string? Kid { get; set; }
    public int BilagRef { get; set; }
    public string? Bilagskilde { get; set; }
}