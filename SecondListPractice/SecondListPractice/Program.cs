List<string> coffes = new List<string>();

for (int i = 5; i > 0; i--)
{
    Console.WriteLine($"\n{i} adet kahve ismi giriniz.\n");
    string coffee = Console.ReadLine().ToLower().Trim();
    coffes.Add( coffee );

}

Console.WriteLine("\nGirmiş olduğunu kahve isimleri : \n");
foreach (var item in coffes)

{
    Console.WriteLine($"\n{item}\n");
}