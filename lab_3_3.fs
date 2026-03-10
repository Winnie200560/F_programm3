// Задача №3
// Вывести список файлов, имя которых начинается с заданного символа, в указанном каталоге.
open System 
open System.IO// Библиотека для работы с файлами и папками 

[<EntryPoint>]
let main args = 
    printfn "Введите путь к каталогу: "
    let way = Console.ReadLine()

    printfn "Введите начальный символ файла: "
    let symbol = Console.ReadLine().[0]

    // Проверка на существование каталога
    if Directory.Exists(way) then 
        Directory.EnumerateFiles(way)
        |> Seq.map Path.GetFileName
        |> Seq.filter (fun name -> name.StartsWith(string symbol))
        |> Seq.iter (printfn "%s")
    else
        printfn "Каталог не найден"

    0
