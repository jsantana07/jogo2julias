namespace Jogo2Julias;
public class Personagens
{
protected double Fome;
protected double Sono;
protected double Felicidade; 
protected  string UrlDaFoto; 

protected string nomedafoto;
public Personagens()

{

}
public string GetNomeDaFoto()
{
    return nomedafoto;
}

public void SetFome (double f)
{
    Fome=f;
}
public double GetFome()
{
    return Fome;
}

public void SetSono (double s)
{
    Sono=s;
}
public double GetSono()
{
    return Sono;
}

public void SetFelicidade (double f)
{
    Felicidade=f;
}
public double GetFelicidade()
{
    return Felicidade;
}

}