namespace ProjectEuler.Problems

module Problem_5 =

    let rec isMultiple (list : list<int>, value : int) : bool =
        if list.IsEmpty then true 
        elif ( value % List.max list ) = 0 then isMultiple ( list.Tail , value )
        else false

    let rec multiple (list : list<int> , max : int , value : int) =
        if isMultiple( list, value ) then 
            value
        else multiple (list , max , value + max )               

    let calculate ( min , max) =
        // sort list reverse, for check biggest number first
        let list = [min .. max] |> List.sortBy (~-)
        multiple ( list.Tail , List.max list , List.max list  )

    let test =
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        calculate ( 1 , 10 ) = 2520
    
    let run =
        calculate ( 1 , 20 )

    let info =
        printf "http://projecteuler.net/problem=5\r\n"
        printf "Smallest multiple \r\n"
        printf "Solved on 13.02.2013 \r\n"