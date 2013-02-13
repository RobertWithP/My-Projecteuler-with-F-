namespace ProjectEuler.Problems

module Problem_6 =

    let numberList numbers  =
        [1 .. numbers]

    let sumOfSquares numbers : int =
        numberList (numbers) |> List.map (fun x -> x * x) |> List.sum

    let squareOfSum numbers : int = 
        numberList (numbers) |> List.sum  |> fun x -> x * x        

    let calculate numbers = 
        squareOfSum ( numbers )  - sumOfSquares ( numbers )        

    let test =
        calculate ( 10 ) = 2640

    let run =
        // todo: no string to char and int converison
        calculate ( 100 )        

    let info =
        printf "http://projecteuler.net/problem=6\r\n"
        printf "Sum square difference \r\n"