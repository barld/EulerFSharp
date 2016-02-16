module problem6
    
    let oneToHunderd = {1..100}
    let square x = x*x

    let sumOfSquares = oneToHunderd |> Seq.map square |> Seq.sum
    let SquareOfSum = oneToHunderd |> Seq.sum |> square

    let answer = SquareOfSum - sumOfSquares




