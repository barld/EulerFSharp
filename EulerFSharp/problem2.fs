module problem2
    let answer =
        let fibSeq = 
            let even x = x%2=0 
            Seq.unfold (fun (a,b) -> Some( a+b, (b, a+b))) (1,2)
            |> Seq.takeWhile (fun x -> x < 4000000)
            |> Seq.filter even
        fibSeq |> Seq.sum
        
        
