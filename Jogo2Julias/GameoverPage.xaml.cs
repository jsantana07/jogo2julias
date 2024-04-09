namespace Jogo2Julias;

public partial class GameoverPage : ContentPage
{

    public GameoverPage()
    {

        	InitializeComponent();
    }
private void BotaoRecomecarClicado(object sender, EventArgs args)
 {
      Application.Current.MainPage = new MainPage();
  }
  }