let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 which is correct

//However, if you try to do the same with a tuple
let mutable tuple = (10,20)

let swapTuple tuple = 
    let (x,y) = tuple
    (y,x) // Return the new tuple

let swappedTuple = swapTuple tuple
printfn "%A" swappedTuple //This will now correctly print (20, 10)
printfn "%A" tuple //This will print (10,20), as expected.