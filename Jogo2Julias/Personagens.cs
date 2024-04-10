namespace Jogo2Julias;
public class Personagens
{
protected double Fome;
protected double Sono;
protected double Felicidade; 
protected  string UrlDaFoto; 

protected string nomedafoto;
protected string nomedafotomorto;

protected bool morto;
public Personagens()

{

}
public string GetNomeDaFoto()
{
    if(morto)
        return nomedafotomorto;
    else
        return nomedafoto;
    
}

public void SetFome (double f)
{
    if (f>1)
    Fome=1;
    else if (f<=0)
    {
        morto=true;
        Fome=0;
    }
    else
    Fome=f;
}
public double GetFome()
{
    return Fome;
}

public void SetSono (double s)
{
    if (s>1)
    Sono=1;
    else if (s<=0)
    {
        morto=true;
        Sono=0;
    }
    else
    Sono=s;
}
public double GetSono()
{
    return Sono;
}

public void SetFelicidade (double f)
{
     if (f>1)
    Felicidade=1;
    else if (f<=0)
    {
        morto=true;
        Felicidade=0;
    }
    else
    Felicidade=f;
}
public double GetFelicidade()
{
    return Felicidade;
}
    public bool GetMorto()
    {
        return morto;
    }
}