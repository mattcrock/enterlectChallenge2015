namespace Matt.SpaceInvaders

module BotBasic =

    open System.Diagnostics
    open System
    open System.IO

    type ShipCommand =
        Nothing = 0 
        | MoveLeft = 1
        | MoveRight = 2 
        | Shoot = 3 
        | BuildAlienFactory = 4 
        | BuildMissileController = 5 
        | BuildSheild = 6

    let Log message =
        printfn "[BOT]\t%s" message

    let SaveShipCommand shipCommand =
        let fileName = Path.Combine("", "")

        try
            use file = new StreamWriter(fileName)
            file.WriteLine (shipCommand.ToString())
            printfn "Ship Command: %s" shipCommand
        with
        | _ as e -> 
            printfn "Unable to wtrite to command file: %s" e.Message
            let trace = new StackTrace(e)
            let traceStr = trace.ToString()
            printfn "Stacktrace: %s" traceStr

    let GetRandomShipCommand =
        let random = new Random()
        let possibleShipCommands = Enum.GetValues(typeof<ShipCommand>)
        let choice =  (possibleShipCommands.GetValue(random.Next(0,possibleShipCommands.Length)).ToString())
        Enum.GetName(typeof<ShipCommand>, choice)

    let LoadMap =
        let fileName = Path.Combine("", "")
        try
            use file = new StreamReader(fileName)
            file.ReadToEnd()
        with
        | _ as e -> 
            printfn "Unable to wtrite to command file: %s" e.Message
            let trace = new StackTrace(e)
            let traceStr = trace.ToString()
            printfn "Stacktrace: %s" traceStr
            "Failed to load map!"
