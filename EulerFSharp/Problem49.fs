module Problem49
    let priemsBelow n =
        let mutable priemlist = [2]
        for i in [3..2..n] do
            let check =
                priemlist
                |> List.filter (fun x -> x <= int(sqrt (float i)))
                |> List.exists (fun x -> i % x = 0)
            if not check then
                priemlist <- i::priemlist
        priemlist |> List.rev

    let makeListFromInt x =
        let mutable xc = x
        let mutable rtw = []
        while xc > 0 do
            rtw <- (xc%10)::rtw
            xc <- xc/10
        rtw

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
        priemsBelow 10000
        |> List.filter ((<) 1000)

    //filter other answer        
    let answer = calcAnswer (priemsBetween1000And10000 |> List.filter (fun x -> x <> 1487))
