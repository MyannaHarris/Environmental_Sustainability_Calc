(* 
 Kristina Spring
 Myanna Harris
 
 Environmental Sustainability Text UI
 Calculates how environmentally sustainable a 
 person's lifestyle is
 *)

open System

type finalScore = class
  val Score : int32

  new (score) as this =
    {Score = score}
    then
      printfn ""
      printfn "Your environmental sustainability score is: %.2f %%\n"
        this.final

  member x.final =
    (float (44-x.Score)) / 44.0 * 100.0
end

module printModule =
  let printOptions (listOp : string[]) =
    for i = 0 to listOp.Length - 1 do
      Console.WriteLine("{0} : {1}",i, listOp.[i])

module inputModule =
  let getInput () : int32 =
    match System.Console.ReadLine() |> System.Int32.TryParse with
    | true, n -> n
    | false, _ -> -1

  let passFunc f x y = f x y

let main() =

  Console.WriteLine("")
  Console.WriteLine("Environmental Sustainability Calculator")
  Console.WriteLine("")

  let mutable score = 0

  let mutable test = 0
  let mutable answer = 0

  while (test = 0) do
    Console.WriteLine("Do you recycle?")
    let strings = [| "Everything possible"; "Some"; "No" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- inputModule.passFunc (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("Do you compost?")
    let strings = [| "Everything possible"; "Some"; "No" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How much do you use your heater during the cold months?")
    let strings = [| "Never use it"; "Seldom, not every day"; "Less than 2 hours a day";
                     "2-4 hours a day"; "More than 5 hours a day" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How much do you use your A/C during the warm months?")
    let strings = [| "Don't have A/C or Never use it"; "Seldom, not every day";
                     "Less than 2 hours a day";
                     "2-4 hours a day"; "More than 5 hours a day" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How many feet of grass/plants do you water weekly?")
    let strings = [| "Less than 2 sq ft"; "3-100 sq ft"; "101-1400 sq ft";
                     "1400-600 sq ft"; "More than 2600 sq ft" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How many other people do you live with?")
    let strings = [| "5 or more other people"; "Four other people";
                     "Three other people"; "Two other people";
                     "One other person"; "None" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("What is your place of living like?")
    let strings = [| "Apartment/dorm"; "Duplex or something similar";
                     "Small house"; "Medium sized house"; "Large house" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How much of your food is locally grown?")
    let strings = [| "All locally grown food"; "Mostly locally grown food";
                     "Half locally grown food"; "Some locally grown food";
                     "No locally grown food" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How many servings of meat do you eat per week?")
    let strings = [| "None, Vegetarian"; "1-7"; "8-14"; "15-20"; 
                     "More than 20" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("What is your mpg?")
    let strings = [| "More than 45"; "36-45"; "26-35"; "15-25";
                     "Less than 15" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How many miles per week do you commute?")
    let strings = [| "Less than 20"; "20-50 miles"; "51-100 miles";
                     "101-200 miles"; "More than 200 miles" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  test <- 0
  while (test = 0) do
    Console.WriteLine("How do you get to work/school?")
    let strings = [| "Walk/bike"; "Public transportation";
                     "Carpool in car/truck"; "Drive car/truck" |]
    printModule.printOptions(strings)

    answer <- inputModule.getInput()
    if (answer <> -1 && answer >= 0 && answer < strings.Length) then
      test <- 1

    printfn ""

  score <- (fun x y -> x + y) score answer

  let fScore = new finalScore(score)
  ()

main()
