using AppJogoDaForca.Libs.Text;
using AppJogoDaForca.Models;
using AppJogoDaForca.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppJogoDaForca;

public partial class NewPage1 : ContentPage
{
    private Palavras _palavras;
    private int _erros;
    public NewPage1()
    {
        InitializeComponent();

        ResetGamer();
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        button.IsEnabled = false;
        System.String charButton = button.Text;

        var positions = _palavras.Text.GetIndexOf(charButton);

        if (positions.Count == 0)
        {
            AddErro(button);
            return;
        }

        AddCharWord(button, charButton, positions);

        Winner();
    }
    #region Handler Success
    private void AddCharWord(Button button, string charButton, List<int> positions)
    {
        button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Success"] as Style;
        foreach (int position in positions)
        {
            LabelText.Text = LabelText.Text.Remove(position, 1).Insert(position, charButton);
        }
    }
    private async void Winner()
    {
        if (!LabelText.Text.Contains("-"))
        {
            await DisplayAlert("Parabéns", "Vócê Ganhou", "Jogar de novo!");
            ResetGamer();
        }
    }
    #endregion
    #region Handler Fail
    private void AddErro(Button button)
    {
        _erros++;
        ImageUrl.Source = ImageSource.FromFile($"forca{_erros + 1}.png");
        button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Fail"] as Style;

        GamerOver();
    }
    private async void GamerOver()
    {
        if (_erros == 6)
        {
            await DisplayAlert("Perdeu", "Vócê foi enforcado", "Jogar de novo!");
            ResetGamer();
        }
    }
    #endregion
    #region Reset Gamer
    private void ResetGamer()
    {
        NewWord();
        ResetErros();
        ResetColorKeyBoard();
    }
    private void NewWord()
    {
        var repository = new PalavrasRepository();
        _palavras = repository.GetWordRandom();

        LabelTips.Text = _palavras.Tips;
        LabelText.Text = new string('-', _palavras.Text.Length);
    }
    private void ResetErros()
    {
        _erros = 0;
        ImageUrl.Source = ImageSource.FromFile("forca1.png");
    }
    private void ResetColorKeyBoard()
    {
        ResetButtons((HorizontalStackLayout)KeyBoard.Children[0]);
        ResetButtons((HorizontalStackLayout)KeyBoard.Children[1]);
        ResetButtons((HorizontalStackLayout)KeyBoard.Children[2]);
    }
    private void ResetButtons(HorizontalStackLayout horizontal)
    {
        foreach (Button button in horizontal.Children)
        {
            button.IsEnabled = true;
            button.Style = null;
        }
    }
    #endregion
    private void Button_ClickedResetGamer(object sender, EventArgs e)
    {
        ResetGamer();
    }
}