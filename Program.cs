string str1 = "Привет";
string str2 = "привет";
string str3 = "Привет, мир!";

// compare
Console.WriteLine(string.Compare(str1, str3));
//  0, если строки равны, res>0 если str1 > str2, res<0 если str1 < str2


// equals
Console.WriteLine(string.Equals(str1, str2));
// true false

// compareOrdinal
Console.WriteLine(string.CompareOrdinal(str1, str2));
// сравнение посимвольно

// indexOf
Console.WriteLine(str3.IndexOf("мир"));
// индекс первого вхождения подстроки

// сontains()
Console.WriteLine(str3.Contains("Привет"));
Console.WriteLine(str3.Contains("Здравствуй"));
// содержит ли строка подстроку true false

// == и !=
Console.WriteLine(str1 == str2);
Console.WriteLine(str1 != str2);
