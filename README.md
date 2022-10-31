# GymnasieArbete_Elev_Placeringar

Vägledning för att koda i Frontend (mycket copy paste): https://mudblazor.com/docs/overview

Huvudsakligen kommer du använda dig av MudPaper och MudText. Har gjort ett exempel i TestPage.razor.
För att skriva C# syntax utan för @code{} i TestPage.razor måste du skriva ett snabel-a och sen koden.
Exempel finns återigen i TestPage.razor.

Vill du registrera en ny Service måste du
1. Lägga till servicen i Program med hjälp av AddHttpClient, kopiera koden som redan finns och matcha service klasserna.
2. I din service klass lägger du till en private readonly HttpClient _httpClient.
3. I din service klass lägger du till en constructor som tar emot en HttpClient, och ger _httpClient det värdet.(public KlassNamn(HttpClient httpClient){ _httpClient = httpClient })
4. I din .razor component lägger du till [Inject] public IServiceNamn ServiceNamn { get; set; }
