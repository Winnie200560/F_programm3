// Задача 2
// Найти сумму тех элементов списка, которые начинаются на заданную цифру.

open System

// Функция для нахождения первой цифры числа
let rec firstDigit (n : int) : int =
    let x = abs n
    if x < 10 then
        x
    else 
        firstDigit (x / 10)

// Фунция ввода списка
let inputSeq (n : int) : seq<int> = 
    seq {
    for i in 1..n do
        printf "Введите число: "
        let input = Console.ReadLine()

        match Int32.TryParse(input) with
        | (true, num) ->
                yield num
        | (false, _) ->
                printfn "Ошибка! Введён символ или буква."
                yield 0
    }

[<EntryPoint>]
let main args = 
    printf "Введите количество чисел в списке: "
    let n = Console.ReadLine()

    match Int32.TryParse(n) with
    | (true, num) ->
        if num <= 0 then 
            printfn "Ошибка! Количество должно быть положительным числом!"
        else
            let numbers = inputSeq num

            printfn "Введите цифру (0-9): "
            let digit = int(Console.ReadLine())
            let result = 
                Seq.fold 
                    (fun sum x -> 
                        if firstDigit x = digit then 
                            sum + x 
                        else 
                            sum) 
                    0 numbers
            printfn "Сумма элементов, начинающихся на %d = %d" digit result

    | (false, _) ->
                printfn "Ошибка! Введён символ или буква."

    0
