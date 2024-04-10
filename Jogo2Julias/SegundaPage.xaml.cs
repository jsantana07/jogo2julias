namespace Jogo2Julias;

public partial class SegundaPage : ContentPage
{
    Gatinha gatinha;
    Macaquinho macaquinho;
    Girafinha girafinha;

    Personagens atual;

    IDispatcherTimer timer;

    public SegundaPage()
	{
		InitializeComponent();
        gatinha = new Gatinha();
        macaquinho = new Macaquinho();
        girafinha = new Girafinha();

        atual = gatinha;
        imagem.Source=atual.GetNomeDaFoto();
        AtualizaBarra();
        timer=Application.Current.Dispatcher.CreateTimer();
        timer.Interval=TimeSpan.FromSeconds(3);
        timer.Tick+=(s,e)=>
         PassarTempo();
         timer.Start();
	}

    void TrocaAnimalDireita(object sender, EventArgs args)
    {
        if (atual == gatinha)
            atual = macaquinho;
        else if (atual == macaquinho)
            atual = girafinha;
        else if (atual == girafinha)
            atual = gatinha;

        TrocaAnimal();
    }
    void TrocaAnimalEsquerda(object sender, EventArgs args)
    {
        if (atual == gatinha)
            atual = girafinha;
        else if (atual == girafinha)
            atual = macaquinho;
        else if (atual == macaquinho)
            atual = gatinha;     

        TrocaAnimal();   
    }

    void TrocaAnimal()
    {
        imagem.Source=atual.GetNomeDaFoto();
        AtualizaBarra();


        if (atual.GetMorto())
        {
            botoes.IsVisible=false;
            barra.IsVisible=false;
        }
        else
        {
            botoes.IsVisible=true;         
            barra.IsVisible=true; 
        }
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
            gatinha.SetFelicidade(gatinha.GetFelicidade()-0.1);
            macaquinho.SetFelicidade(macaquinho.GetFelicidade()-0.1);
            girafinha.SetFelicidade(girafinha.GetFelicidade()-0.1);
            gatinha.SetFome(gatinha.GetFome()-0.1);
            macaquinho.SetFome(macaquinho.GetFome()-0.1);
            girafinha.SetFome(girafinha.GetFome()-0.1);
            gatinha.SetSono(gatinha.GetSono()-0.1);
            macaquinho.SetSono(macaquinho.GetSono()-0.1);
            girafinha.SetSono(girafinha.GetSono()-0.1);
            AtualizaBarra();
            if (estavaMorto != atual.GetMorto())
            {
                imagem.Source=atual.GetNomeDaFoto();
                botoes.IsVisible=false;
                barra.IsVisible=false;
                
                
            }

            
            if (gatinha.GetMorto()&&
                macaquinho.GetMorto()&&
                girafinha.GetMorto())
            {
                Application.Current.MainPage = new GameoverPage();
                timer.Stop();
            }
        }

   }  


            