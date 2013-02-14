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
        fibonacci max |> fun x -> Seq.append [| 1I; 1I |] x |> Seq.length 

    let test =
        // 144 first first term with 3 digits, 12 Position -> 1 1 2 3 5 8 13 21 34 55 89 144
        calculate 3 = 12       

    let run =
        calculate 1000

    let info =
        printf "http://projecteuler.net/problem=25\r\n"
        printf "1000-digit Fibonacci number \r\n"
        printf "Solved on 12.02.2013 \r\n"

