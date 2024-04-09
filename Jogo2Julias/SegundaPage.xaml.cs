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
        AtualizaBarra();
        var timer=Application.Current.Dispatcher.CreateTimer();
        timer.Interval=TimeSpan.FromSeconds(10);
        timer.Tick+=(s,e)=>
         PassarTempo();
         timer.Start();
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
        AtualizaBarra();
        PassarTempo();
    }

        void AtualizaBarra()
        {
            progressoalegria.Progress=atual.GetFelicidade();
            progressofome.Progress=atual.GetFome();
            progressosono.Progress=atual.GetSono();
        }
        void  smilefacefoiclicado(object sender, EventArgs args)
  {
        atual.SetFelicidade(atual.GetFelicidade()+0.1);
        AtualizaBarra();
  }
  void  botaocomidafoiclicado(object sender, EventArgs args)
  {
        atual.SetFome(atual.GetFome()+0.1);
        AtualizaBarra();
  }
   void  botaosonofoiclicado(object sender, EventArgs args)
  {
        atual.SetSono(atual.GetSono()+0.1);
        AtualizaBarra();
  }
void PassarTempo()
{
    var estavaMorto=atual.GetMorto();
    atual.SetFelicidade(atual.GetFelicidade()-0.1);
     atual.SetFome(atual.GetFome()-0.1);
     atual.SetSono(atual.GetSono()-0.1);
     AtualizaBarra();
     if (estavaMorto != atual.GetMorto())
      imagem.Source=atual.GetNomeDaFoto();

    if (gatinha.GetMorto()&&
        macaquinho.GetMorto()&&
        girafinha.GetMorto())
         Application.Current.MainPage = new GameoverPage();
      
 }

   }  


            