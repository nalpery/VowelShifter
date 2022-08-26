Console.WriteLine("Bir metin giriniz:");
string str = Console.ReadLine();
string strnew = string.Empty;
List<char> vowel = new List<char> { };   
char[] consonant = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') 
    { 
        vowel.Add(str[i]);
        consonant[i] = '0';
        
    }
    else 
    { 
        consonant[i]=str[i]; 
        
    }
    
}int counter = 0;
for (int i = 0; i < str.Length; i++)
{
    if (consonant[i] != '0') { strnew += consonant[i].ToString(); }
    else
    {
        
        strnew += vowel[(vowel.Count-1+counter)%vowel.Count].ToString();
        counter++;

    }

}

Console.WriteLine($"{strnew}");
