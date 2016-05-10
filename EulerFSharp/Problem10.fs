module Problem10
    let answer = 
        primeCS.Prime.GetPriemsBelowParallel(2000000) |> Seq.map int64 |> Seq.sum
