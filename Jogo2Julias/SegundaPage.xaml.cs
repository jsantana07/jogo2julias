namespace Jogo2Julias;

public partial class SegundaPage : ContentPage
{
    Gatinha gatinha;
    Macaquinho macaquinho;
    Girafinha girafinha;

    Personagens atual;

    public SegundaPage()
	{
		InitializeComponent();
        gatinha = new Gatinha();
        macaquinho = new Macaquinho();
        girafinha = new Girafinha();

        atual = gatinha;
        imagem.Source=atual.GetNomeDaFoto();
	}

    void trocaanimal(object sender, EventArgs args)
    {
        if (atual == gatinha)
            atual = macaquinho;
        else if (atual == macaquinho)
            atual = girafinha;
        else if (atual == girafinha)
            atual = gatinha;


        imagem.Source=atual.GetNomeDaFoto();
    }
 }
    


            