﻿namespace task4;

public class Country
{


    string _name;
    string _capital;
    int _population;
    string _officialLanguage;



public Country( string name, string capital, int population, string officialLanguage)
{

    _name = name;
    _capital = capital;
    _population = population;
    _officialLanguage = officialLanguage;

}
    public void SetCapital(string capital)
    {
        if(capital==_capital)
        {
            System.Console.WriteLine(true);
        }
    }
public string GetCapital() 
{
    return _capital;
}   
public void SetPopulation(int population)
{
    _population =population;
}

public int GetPopulation()

{
    return _population;
}

public void SetOfficialLanguage(string language)
{
_officialLanguage= language;

}
public string GetOfficialLanguage()

{
    return _officialLanguage;
}
}
