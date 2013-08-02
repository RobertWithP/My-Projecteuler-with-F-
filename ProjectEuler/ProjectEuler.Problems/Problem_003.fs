namespace ProjectEuler.Problems

open ProjectEuler.Algorithm

module Problem_3 =
    
    let rec prime_factor i max =
        if i >= max then i
        else
            if ((max % i) = 0I) then 
                prime_factor i (max / i)
            else        
                prime_factor (i + 1I) max 

    let largest_prime_factor max=
        prime_factor 2I max

    let test =
        // extra test with 93 -> 31 
        (largest_prime_factor 93I = 31I) && (largest_prime_factor 13195I = 29I)

    let run =
        largest_prime_factor 600851475143I                  

    let info =
        printf "http://projecteuler.net/problem=3\r\n"
        printf "Largest prime factor \r\n"
        printf "Solved on 02.08.2013 \r\n"


