namespace ProjectEuler.Problems

open System

module Problem_19 =
      
    let rec getNextSunday (from : DateTime) : DateTime =
         if from.DayOfWeek = DayOfWeek.Sunday then from
         else getNextSunday ( from.AddDays ( 1.0 ) )

    let isFirstInMonth (check : DateTime ) : int =
        if check.Day = 1 then 1 else 0

    let rec countSundays (actual : DateTime , till : DateTime) : int =
        if actual.CompareTo ( till ) = 1 then 0
        elif actual.CompareTo ( till ) = 0 then isFirstInMonth ( actual )
        else             
            countSundays (actual.AddDays ( 7.0 ), till ) + isFirstInMonth ( actual )

    let calculate (from : DateTime, till : DateTime) =                     
        let firstSunday = getNextSunday from

        countSundays ( firstSunday , till )

    let test =
        let starting = new DateTime (1911,1,1)
        let ending = new DateTime (1911,12,31);

        let t = calculate ( starting, ending )
        t = 2      

    let run =
        let starting = new DateTime (1901,1,1)
        let ending = new DateTime (2000,12,31);

        calculate ( starting, ending )

    let info =
        printf "http://projecteuler.net/problem=19\r\n"
        printf "Counting Sundays (sunday is 1 in month) \r\n"
        printf "Solved on 14.02.2013 \r\n"
