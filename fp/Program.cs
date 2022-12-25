Console.Clear();

Console.WriteLine("Введите значения массива. Разные элементы отделите друг от друга пробелом:");
string s = Console.ReadLine();
string[] st = s.Split(' ');
string[] newS = DefinitionLength(st);
Console.WriteLine("Элементы с тремя и меньше символами: ");
Console.WriteLine(String.Join(" ", newS));

string[] DefinitionLength(string[] s){
    string[] newStr = new string[s.Length];
    int j = 0;
    for (int i = 0; i < s.Length; i++){
        if (s[i].Length <= 3){
            newStr[j] = s[i];
            j++;
        }
    }
    return newStr;
}