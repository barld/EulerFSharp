
module problem4

    let isPalinDromicNumber (n:int) =
        let rec toList n =
            match n with
            | 0 -> []
            | n -> n % 10 :: toList (n/10)

        let l = toList n
        let rl = l |> List.rev

        rl = l

    let numbers = [999..-1..100]
    let candidates = 
        numbers 
        |> List.map (fun n -> (numbers |> List.map (fun n2 -> n * n2)))
        |> List.fold (@) []
        |> List.filter isPalinDromicNumber

    let answer = candidates |> List.max