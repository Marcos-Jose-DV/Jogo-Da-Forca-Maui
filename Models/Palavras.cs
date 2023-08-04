

namespace AppJogoDaForca.Models;

public class Palavras
{
    public Palavras(string tips, string text)
    {
        Tips = tips;
        Text = text;
    }

    public string Tips { get; set; } = string.Empty;

    private string _text;

    public string Text
    {
        get => _text;
        set => _text = value?.ToUpper();
    }
}
