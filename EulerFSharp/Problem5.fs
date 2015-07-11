module Problem5
    let rec filter n s =
        match n with
        | x when x < 2 -> s
        | _ -> s |> Seq.filter (fun x -> x % n = 0) |> filter (n-1)
        
    let answer =
        Seq.unfold (fun x -> Some(x, x+20)) 20
        |> filter 19
        |> Seq.head

