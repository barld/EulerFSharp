module Priems

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