namespace ProjectEuler.Problems

module Problem_1 =
    
    let isModulo x = x % 3 = 0 || x % 5 = 0

    let calculate(below:int) =        
        [1..below - 1] |> List.filter isModulo |> List.sum

    let run =
        calculate 1000

    let test =
        calculate(10) = 23

    let info =
        printf "http://projecteuler.net/problem=1\r\n"
        printf "Multiples of 3 and 5 \r\n"
        printf "Solved on 11.02.2013 \r\n"
