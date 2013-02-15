namespace ProjectEuler.Problems

module Problem_17 =
      
    let c1to19 value : string =
        let words = ["One"; "Two"; "Three"; "Four"; "Five"; "Six"; "Seven"; "Eight"; "Nine"; "Ten"; "Eleven"; "Twelve"; "Thirteen"; "Fourteen"; "Fifteen"; "Sixteen"; "Seventeen"; "Eighteen"; "Nineteen"]
        words.Item (value - 1)

    let c20to99 value : string =
        let tens = ["Twenty"; "Thirty"; "Forty"; "Fifty"; "Sixty"; "Seventy"; "Eighty"; "Ninety"]
        let word = tens.Item ((value / 10) - 2)
        if value % 10 > 0 then 
            word + "-" + c1to19 ( value % 10 )            
        else word

    let c1to99 value : string =
        match value with
        | num when num < 20 -> c1to19 ( value )
        | _ -> c20to99 ( value )

    let c101to999 value : string =
        let hundred = c1to19 ( value / 100 )
        let word = hundred + " Hundred"

        if value % 100 = 0 then word
        else
            word + " and " + c1to99 ( value % 100 )

    let rec numberToWord value : string =
        match value with
        | 0 -> "Zero"
        | num when num < 100 -> c1to99 ( value )
        | num when num < 1000 -> c101to999 ( value )
        | 1000 -> "One Thousand"

    let numberToWordDigitsCount value : int =
        numberToWord ( value ) 
        |> fun x -> x.Replace (" ", "" ) 
        |> fun x -> x.Replace ("-", "" ) 
        |> String.length

    let calculate (from , till ) : int =                     
        [from .. till] |> List.map numberToWordDigitsCount |>List.sum

    let test =
        let t = calculate ( 115, 115 )
        t = 20      

    let run =
        calculate ( 1, 1000 )

    let info =
        printf "http://projecteuler.net/problem=17\r\n"
        printf "Number letter counts \r\n"
        printf "Solved on 15.02.2013 \r\n"