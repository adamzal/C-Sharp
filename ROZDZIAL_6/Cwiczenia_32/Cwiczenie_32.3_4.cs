using System;

public interface IWydajDzwiek
{
    void Graj();
}

public interface IWyswietlObraz
{
    void Wyswietl();
}

public interface IWyswietlObrazIWydajDzwiek:IWyswietlObraz,IWydajDzwiek
{ }
public class Telewizor:IWyswietlObrazIWydajDzwiek
{
    public void Graj() { }
    public void Wyswietl() { }
}
