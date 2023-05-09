# isogramma
Questo programma, data una stringa, controlla se è un isogramma o no. 
### Codice

Ho creato una funzione nella quale, dopo aver splittato la stringa nello spazio e nel trattino e averla ricomposta, si utilizza un ciclo for annidato controlla se i vari caratteri sono uguali. Se sono uguali ritorna falso, altrimenti continua a scorrere la stringa fino alla fine del ciclo e ritorna vero.
```
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
```
