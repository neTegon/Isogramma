using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {
        string [] parole = word.Split(' ','-');
        string app= String.Join("",parole).ToLower();
        for (int i = 0; i < app.Length; i++)
        {
            for (int j = i + 1; j < app.Length; j++)
            {
                if (app[i] ==  app[j])
                {
                    return false;
                }  
            }
        }
        return true;
    }

}
