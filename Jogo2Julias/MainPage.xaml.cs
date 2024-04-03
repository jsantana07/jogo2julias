namespace Jogo2Julias;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
		
	}

		void BotaoIniciarFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new SegundaPage();
  }
 private void BotaoSobreFoiClicado(object sender, EventArgs args)
  {
    frameSobre.IsVisible = true;
  }
  private void BotaoVoltarFoiClicado(object sender, EventArgs args)
  {
    frameSobre.IsVisible = false;
  }

}

