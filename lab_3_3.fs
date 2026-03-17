// Задача №3
// Вывести список файлов, имя которых начинается с заданного символа, в указанном каталоге.

open System
open System.IO

let inputDirectory () =
    printf "Введите путь к каталогу: "
    Console.ReadLine()

let inputSymbol () =
    printf "Введите начальный символ файла: "
    Console.ReadLine().[0]

let processFiles way symbol =
    if Directory.Exists(way) then
        Directory.EnumerateFiles(way)
        |> Seq.map Path.GetFileName
        |> Seq.filter (fun name -> name.[0] = symbol)
        |> Seq.iter (printfn "%s")
    else
        printfn "Каталог не найден"

[<EntryPoint>]
let main args = 
    let way = inputDirectory()
    let symbol = inputSymbol()
    
    processFiles way symbol
    0
