namespace ProjectEuler.Problems

open System.IO 

module Problem_25 =
    let digitCount (x : bigint, digits : int) = 
        x.ToString().Length = digits 

    let fibonacci maxDigits = Seq.unfold (fun state ->
            if ( digitCount (snd state, maxDigits) ) then None   
            else 
                Some(bigint.Add(fst state, snd state), (snd state, bigint.Add(fst state , snd state)))) (1I,1I)          
   
    let calculate max =    
                 
        let t = fibonacci max 
        // todo: modify fibonacci to start with 0 and get 1 and 1 as first digits
        let newt = Seq.append [| 1I; 1I |] t

        Seq.length newt

    let run =
        calculate 1000

    let test =
        // 144 first first term with 3 digits
        let r = calculate 3 
        r = 12

    let info =
        printf "http://projecteuler.net/problem=25\r\n"
        printf "1000-digit Fibonacci number \r\n"
        printf "Solved on 12.02.2013 \r\n"

