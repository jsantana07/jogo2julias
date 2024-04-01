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


}

