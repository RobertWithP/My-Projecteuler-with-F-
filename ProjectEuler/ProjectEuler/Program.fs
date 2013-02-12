[<EntryPoint>]
let main argv = 
    
    let test (x:bool) = 
        if x = false then
            let s = Printf.TextWriterFormat<unit>("\r\nTest FAILED!\r\n")
            printfn s
        else
            printfn "\r\nTest run successfully!\r\n"

    let showresult (result:string) =
        let s = Printf.TextWriterFormat<string -> unit>("Result:\r\n%s\r\n")
        printfn s result


    // change here problem
    let run =
        ProjectEuler.Problems.Problem_16.info 
        test (ProjectEuler.Problems.Problem_16.test)
            
        let result = ProjectEuler.Problems.Problem_16.run
        showresult (result.ToString())

    System.Console.ReadLine()
    0 // return an integer exit code
