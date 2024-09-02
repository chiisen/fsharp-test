// For more information see https://aka.ms/fsharp-console-apps
let square x = x * x
let numbers = [1 .. 10]
let squares = List.map square numbers
printfn "N^2 = %A" squares


printfn "Press any key to continue..."
System.Console.ReadKey() |> ignore 