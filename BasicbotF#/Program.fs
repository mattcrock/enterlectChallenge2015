open System.IO
open System


let printUsage =
    printfn "C# BasicBot usage: BasicBot.exe <outputFilename>"
    printfn ""
    printfn "\toutputPath\tThe output folder where the match runner will output map and state files and look for the move file."


let runBot (args:string[]) =
    
    let mutable result = None

    if args.Length <> 1 then
        printUsage
        Environment.Exit(1)
        result
    
    let outputPath = args.GetValue 0
    if Directory.Exists outputPath then
        printUsage
        printfn ""
        printfn "Error: Output folder \%s\" does not exist." outputPath
    result <- (Some "")
    result
    
    


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let result = runBot argv
    0 // return an integer exit code

