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
        imagem.Source=atual.GetNomeDaFoto()
        AtualizaBarra();
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
    void trocadoisanimal(object sender, EventArgs args)
    {
        if (atual == gatinha)
            atual = girafinha;
        else if (atual == girafinha)
            atual = macaquinho;
        else if (atual == macaquinho)
            atual = gatinha;


        imagem.Source=atual.GetNomeDaFoto();
    }

        void AtualizaBarra()
        {
            progressoalegria.Progress=atual.GetFelicidade();
            progressofome.Progress=atual.GetFome();
            progressosono.Progress=atual.GetSono();
        }
        void  smilefacefoiclicado(object sender, EventArgs args)
  {
        atual.SetFelicidade(atual.GetFelicidade()+0,1);
        AtualizaBarra();
  }

    
 }
    


            