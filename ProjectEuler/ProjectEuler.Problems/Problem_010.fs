namespace ProjectEuler.Problems

open System
open ProjectEuler.Algorithm

module Problem_10 =   

    let test =
        let t = Prime.SumPrimes ( 10 ) 
        t = 17I

    let run =
        //refactor c# -> under 50ms
//        let sw = System.Diagnostics.Stopwatch()
//        sw.Start()
        let result = Prime.SumPrimes ( 2000000 )    
//        sw.Stop()
//        printfn "%f" sw.Elapsed.TotalMilliseconds
    
        result

    let info =
        printf "http://projecteuler.net/problem=10\r\n"
        printf "Summation of primes \r\n"
        printf "Sieve from wikipedia: http://de.wikipedia.org/wiki/Sieb_des_Eratosthenes"
        printf "Solved on 29.07.2013 \r\n"