namespace ProjectEuler.Problems

module Problem_2 =
    let isEven x = x % 2 = 0 

    // thanx to msdn http://msdn.microsoft.com/en-us/library/vstudio/ee340363(v=vs.110).aspx
    let fibonacci max = Seq.unfold (fun state ->
            if (fst state + snd state >= max) then None
            else 
                Some(fst state + snd state, (snd state, fst state + snd state))) (1,1)          
   
    let calculate max =           
        fibonacci max |> Seq.filter isEven |> Seq.sum

    let run =
        calculate 4000000

    let test =
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 -> sum even is 44
        calculate 100 = 44

    let info =
        printf "http://projecteuler.net/problem=2\r\n"
        printf "Even Fibonacci numbers \r\n"
        printf "Solved on 11.02.2013 \r\n"


