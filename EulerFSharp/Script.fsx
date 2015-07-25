
#load "Priems.fs"


let n = 600851475143L
let sqrtN = n |> double |> sqrt |> int

Priems.priemsBelow sqrtN
|> List.filter (fun x -> n % (int64 x) = 0L)
|> List.last