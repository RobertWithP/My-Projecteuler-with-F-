namespace ProjectEuler.Problems

module Problem_16 =

    let digitsSum (result : bigint) =      
        result.ToString().ToCharArray() |> Seq.map (fun dir -> System.Int32.Parse(dir.ToString())) |> Seq.sum

    let calculate (basis : bigint, exponent : int) : int =                
        digitsSum (bigint.Pow( basis, exponent) )

    let run =
        // todo: no string to char and int converison
        calculate (2I, 1000)
        
    let test =
        // 2 15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
        calculate ( 2I, 15 ) = 26

    let info =
        printf "http://projecteuler.net/problem=16\r\n"
        printf "Power digit sum \r\n"
        printf "Solved on 12.02.2013 \r\n"