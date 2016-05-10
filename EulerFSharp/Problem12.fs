module Problem12
    let countDivisors n =        
        [1..(n |> float |> sqrt |> int)] |> List.filter (fun i -> n%i=0) |> List.length |> ((*) 2)

    let answer =
        Seq.unfold (fun state -> Some(seq{1..state} |> Seq.sum, state+1)) 1 
        |> Seq.map (fun v -> v, countDivisors v) 
        |> Seq.find (fun (_,c) -> c >= 500) |> fst

