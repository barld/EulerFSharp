module Problem49
    
    let makeListFromInt x =
        Seq.unfold (fun state -> if state > 0 then Some(state%10, state/10) else None) x
        |> List.ofSeq
        |> List.rev

    let isPermutation a b =
        let aList = makeListFromInt a |> List.sort
        let bList = makeListFromInt b |> List.sort
        aList = bList

    let rec calcAnswer list =
        match list with
        | [] -> ""
        | head::body ->
            let filter j = isPermutation head j && list |> List.exists ((=)(j + j-head)) && isPermutation j (j + j-head)
            if body |> List.exists filter then
                let j = body |> List.find filter
                (string(head) + string(j) + string(j + j-head))
            else 
                calcAnswer body

    let priemsBetween1000And10000 =
        Priems.priemsBelow 10000
        |> List.filter ((<) 1000)

    //filter other answer        
    let answer = calcAnswer (priemsBetween1000And10000 |> List.filter (fun x -> x <> 1487))
