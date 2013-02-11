[<EntryPoint>]
let main argv = 
    
    let test (x:bool) = 
        if x = false then
            let s = Printf.TextWriterFormat<unit>("\r\nError with test!\r\n")
            printfn s
        else
            printfn "\r\nTest run successfully!\r\n"

    let showresult (result:string) =
        let s = Printf.TextWriterFormat<string -> unit>("Result:\r\n%s\r\n")
        printfn s result


    // change here problem
    let run =
        ProjectEuler.Problems.Problem_1.info
        let p = ProjectEuler.Problems.Problem_1.test       
        test (p)
            
        let result = ProjectEuler.Problems.Problem_1.run
        showresult (result.ToString())

    let read = System.Console.ReadLine()
    0 // return an integer exit code
