namespace ProjectEuler.Problems

open System.IO 

module Problem_13 =

    let readFile : List<bigint> = 
        File.ReadAllLines ( "Problem_013.txt" ) |> Array.toList |> List.map (fun x -> bigint.Parse ( x ) )
        
    let calculate =                
         readFile |> List.sum |> fun x -> x.ToString() |> fun s -> s.Substring (0, 10)

    let test =
        calculate.Length = 10

    let run =
        calculate

    let info =
        printf "http://projecteuler.net/problem=13\r\n"
        printf "Large sum \r\n"
        printf "Solved on 13.02.2013 \r\n"

