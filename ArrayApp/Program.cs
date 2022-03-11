var arr = Array.CreateInstance(typeof(int), 4); // int türünde 4 elemanlı dizi oluştur
arr.SetValue(23, 0); // 0. index 23 değeri
arr.SetValue(44, 1); // 1. index 44 değeri
arr.SetValue(61, 2); // 2. index 61 değeri
arr.SetValue(84, 3); // 3. index 84 değeri

Console.WriteLine(arr.GetValue(0));
Console.WriteLine(arr.GetValue(1));
Console.WriteLine(arr.GetValue(2));
Console.WriteLine(arr.GetValue(3));
//Console.WriteLine(arr.GetValue(5));  5. index var olmadığı için hata döner

try
{
    Console.WriteLine(arr.GetValue(5));
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}

var _arr = new DataStructures.Array.Array(1, 2, 3);
foreach (var item in _arr)
{
    Console.WriteLine(item);
}
Console.ReadKey();