# isogramma
Questo programma, data una stringa, controlla se è un isogramma o no. 
### Codice

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
