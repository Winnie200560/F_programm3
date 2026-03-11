// Задача №3
// Вывести список файлов, имя которых начинается с заданного символа, в указанном каталоге.

open System
open System.IO

[<EntryPoint>]
let main args = 

    printf "Введите путь к каталогу: "
    let way = Console.ReadLine()

    printf "Введите начальный символ файла: "
    let symbol = Console.ReadLine().[0]

    if Directory.Exists(way) then

        for file in Directory.EnumerateFiles(way) do
            let name = Path.GetFileName(file) // Извлечение имени файла

            if name.StartsWith(string symbol) then
                printfn "%s" name

    else
        printfn "Каталог не найден"

    0
