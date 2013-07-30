namespace ProjectEuler.Algorithm

module Prime =

    let multiple start max factor = Seq.unfold (fun state -> 
        if (state > max) then None 
        else Some(state, state + factor)) start   
        
    let sieve max = 
        let to_check = Array.create(max + 1) false

        let mutable value = 0L // refactor here

        for i = 2 to max do            
            if  to_check.[i].Equals false then              
                multiple (i * 2) max i |> Seq.iter (fun x -> to_check.[x] <- true)

        // sum all prime
        for i = 2 to max do
            if  to_check.[i].Equals false then
                value <- value + int64(i) 

        value