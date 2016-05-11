
#load "Priems.fs"


let n = 600851475143L
let sqrtN = n |> double |> sqrt |> int

Priems.priemsBelow sqrtN
|> List.filter (fun x -> n % (int64 x) = 0L)
|> List.last

#load "Scripts/load-project-debug.fsx"

#time
Problem13.answer
#time

Problem9.answer


#time
primeCS.Prime.GetPriemsBelowParallel(2000000) |> Seq.map int64 |> Seq.sum
#time