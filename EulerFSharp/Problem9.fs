module Problem9
    let isNatural (n:float) = n%1.=0.

    let answer =
        [for i in 1..499 do for j in i..500 -> i,j, i*i+j*j |> float |> sqrt |> int] 
        |> List.find (fun (a,b,c) -> a+b+c = 1000 && a*a+b*b |> float |> sqrt |> isNatural) 
        |> (fun (a,b,c)->a*b*c)
