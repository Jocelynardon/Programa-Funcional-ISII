// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hola Mundito desde F#!"

    let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
    let stringList = [ "one"; "two"; "three" ]

    let num = 6
    let str = "F#"

    let doubleIt = fun n -> 2 * n

    let squareIt = fun n -> (n * n) - 6
    
    
    let funList = [ squareIt; doubleIt ]
    
    
    let BMICalculator = fun ht wt ->
                        (float wt / float (squareIt ht)) * 703.0
    
   
    let integerTuple = ( 1, -4 )
    let stringTuple = ( "one", "two", "three" )
    
    
    let mixedTuple = ( 1, "two", 3.3 )
    
    
    let funTuple = ( squareIt, BMICalculator )
    
    
    let moreMixedTuple = ( num, "two", 3.3, squareIt )

    let funAndArgTuple = (squareIt, num)
    
    System.Console.WriteLine((fst funAndArgTuple)(snd funAndArgTuple))

    let funAndArgTuple2 = ((fun n -> n * n), 7)
    
    System.Console.WriteLine((fst funAndArgTuple2)(snd funAndArgTuple2))
    
    System.Console.WriteLine(squareIt num)
    
    let repeatString = fun s -> s + s
    

    let greeting = "Hello"
    System.Console.WriteLine(repeatString greeting)

    let applyIt = fun op arg -> op arg
    
    System.Console.WriteLine(applyIt squareIt num)

    let applyIt2 op arg = op arg
    // The following line also displays 100.
    System.Console.WriteLine(applyIt2 squareIt num)

    let squareAll = List.map squareIt integerList
    
    printfn "%A" squareAll

    let evenOrNot = List.map (fun n -> n % 2 = 0) integerList

    printfn "%A" evenOrNot

    System.Console.WriteLine(doubleIt 3)
    System.Console.WriteLine(squareIt 4)

    let lowercase = str.ToLower()

    System.Console.WriteLine((fun n -> n % 2 = 1) 15)

    //Fibonacci

    0
