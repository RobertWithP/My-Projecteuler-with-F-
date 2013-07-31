namespace ProjectEuler.Algorithm

module Prime =

    module internal SieveOfEratosthenes =

        let multiple start max factor = Seq.unfold (fun state -> 
            if (state > max) then None 
            else Some(state, state + factor)) start   
        
        let sieve max = 
            let to_check = Array.create(max + 1) false
            let primes = Array.create(max + 1) 0I

            for i = 2 to max do            
                if  to_check.[i].Equals false then              
                    multiple (i * 2) max i |> Seq.iter (fun x -> to_check.[x] <- true)                   
                    primes.[i] <- bigint i

            primes // |> Array.filter (fun x -> x > 0I) 

    let SumPrimes max = 
        Array.sum ( SieveOfEratosthenes.sieve max )        
        