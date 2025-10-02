open System    
[<EntryPoint>]
let main argv =
    printfn "Hello world F#\n"
    
    
    printf "Enter your name: \n"
    let name:string = Console.ReadLine()
    printfn "Hello, %s!" name
        
          
    0 // return an integer exit code