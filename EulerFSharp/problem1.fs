﻿module problem1
    let answer = 
        [3..999]
        |> List.filter(fun x -> x % 3 = 0 || x % 5 = 0)
        |> List.sum
