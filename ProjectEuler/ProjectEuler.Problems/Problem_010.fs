namespace ProjectEuler.Problems

open System

module Problem_10 =   

    let multiple start max factor = Seq.unfold (fun state -> 
        if (state > max) then None 
        else Some(state, state + factor)) start   
        
    let sieve max = 
        let to_check = Array.create(max + 1) false

        let mutable value = 0L // refactor here

        for i = 2 to max do
            
            if  to_check.[i].Equals false then
                
                multiple (i * 2) max i |> Seq.iter (fun x -> to_check.[x] <- true)

                value <- value + int64(i) 

        value

    let test =
        let t = sieve ( 10 ) 
        t = 17L

    let run =

        //refactor c# -> under 50ms

        //let sw = System.Diagnostics.Stopwatch()
        //sw.Start()
        let result = sieve ( 2000000 )    
        //sw.Stop()
        //printfn "%f" sw.Elapsed.TotalMilliseconds
    
        result

    let info =
        printf "http://projecteuler.net/problem=10\r\n"
        printf "Summation of primes \r\n"
        printf "Sieve from wikipedia: http://de.wikipedia.org/wiki/Sieb_des_Eratosthenes"
        printf "Solved on 29.07.2013 \r\n"