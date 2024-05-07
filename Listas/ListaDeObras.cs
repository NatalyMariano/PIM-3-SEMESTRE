// Item.cs
public class Item
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Imagem { get; set; }
    public string Descricao { get; set; }
    public List<string> Perguntas { get; set; }

    public Item(int id, string nome, string imagem, string descricao, List<string> perguntas)
    {
        Id = id;
        Nome = nome;
        Imagem = imagem;
        Descricao = descricao;
        Perguntas = perguntas;
    }
}


public class ListaDeObras
{
    public List<Item> CriarListaDeObras()
    {
        var listaDeItens = new List<Item>();
        listaDeItens.Add(new Item(1, "obra 1", "id3.png", "A expressão Lorem ipsum em design gráfico e editoração é um texto padrão em latim utilizado na produção gráfica para preencher os espaços de texto em publicações para testar e ajustar aspectos visuais antes de utilizar conteúdo real. Também é utilizado em catálogos tipográficos, para demonstrar textos e títulos escritos com as fontes. da obra 2", new List<string> { "Em uma escala de 0 a 5, o quanto você ficou satisfeito com a experiência geral da obra?", "Em uma escala de 0 a 5, como você percebeu a capacidade das obras em capturar a imaginação e despertar a curiosidade sobre a exploração espacial?","Em uma escala de 0 a 5, o quanto você recomendaria esta obra a outras pessoas?"}));
        listaDeItens.Add(new Item(2, "obra 2", "id4.png", "A expressão Lorem ipsum em design gráfico e editoração é um texto padrão em latim utilizado na produção gráfica para preencher os espaços de texto em publicações para testar e ajustar aspectos visuais antes de utilizar conteúdo real. Também é utilizado em catálogos tipográficos, para demonstrar textos e títulos escritos com as fontes. da obra 3", new List<string> { "Em uma escala de 0 a 5, o quanto você ficou satisfeito com a experiência geral da obra?", "Em uma escala de 0 a 5, como você percebeu a capacidade das obras em capturar a imaginação e despertar a curiosidade sobre a exploração espacial?","Em uma escala de 0 a 5, o quanto você recomendaria esta obra a outras pessoas?"}));
        listaDeItens.Add(new Item(3, "obra 3", "id1.png", "A expressão Lorem ipsum em design gráfico e editoração é um texto padrão em latim utilizado na produção gráfica para preencher os espaços de texto em publicações para testar e ajustar aspectos visuais antes de utilizar conteúdo real. Também é utilizado em catálogos tipográficos, para demonstrar textos e títulos escritos cssssssssssom as fontes.", new List<string> { "Em uma escala de 0 a 5, o quanto você ficou satisfeito com a experiência geral da obra?", "Em uma escala de 0 a 5, como você percebeu a capacidade das obras em capturar a imaginação e despertar a curiosidade sobre a exploração espacial?", "Em uma escala de 0 a 5, o quanto você recomendaria esta obra a outras pessoas?" }));
        return listaDeItens;
    }
}