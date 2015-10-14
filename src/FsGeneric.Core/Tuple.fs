[<AutoOpen>]
module FsGeneric.Tuple

//------------------------------------------
// Pull Tuple member [0-10] from any tuple
//------------------------------------------
module TypeMaps =
    type First = First with
        static member inline (?<-)(_,_,(x,_):'a*'b) = x
        static member inline (?<-)(_,_,(x,_,_):'a*'b*'c) = x
        static member inline (?<-)(_,_,(x,_,_,_):'a*'b*'c*'d) = x
        static member inline (?<-)(_,_,(x,_,_,_,_):'a*'b*'c*'d*'e) = x
        static member inline (?<-)(_,_,(x,_,_,_,_,_):'a*'b*'c*'d*'e*'f) = x
        static member inline (?<-)(_,_,(x,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g) = x
        static member inline (?<-)(_,_,(x,_,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(x,_,_,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(x,_,_,_,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type  Second = Second with
        static member inline (?<-)(_,_,(_,x):'a*'b) = x
        static member inline (?<-)(_,_,(_,x,_):'a*'b*'c) = x
        static member inline (?<-)(_,_,(_,x,_,_):'a*'b*'c*'d) = x
        static member inline (?<-)(_,_,(_,x,_,_,_):'a*'b*'c*'d*'e) = x
        static member inline (?<-)(_,_,(_,x,_,_,_,_):'a*'b*'c*'d*'e*'f) = x
        static member inline (?<-)(_,_,(_,x,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g) = x
        static member inline (?<-)(_,_,(_,x,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(_,x,_,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,x,_,_,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type  Third = Third with 
        static member inline (?<-)(_,_,(_,_,x):'a*'b*'c) = x
        static member inline (?<-)(_,_,(_,_,x,_):'a*'b*'c*'d) = x
        static member inline (?<-)(_,_,(_,_,x,_,_):'a*'b*'c*'d*'e) = x
        static member inline (?<-)(_,_,(_,_,x,_,_,_):'a*'b*'c*'d*'e*'f) = x
        static member inline (?<-)(_,_,(_,_,x,_,_,_,_):'a*'b*'c*'d*'e*'f*'g) = x
        static member inline (?<-)(_,_,(_,_,x,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(_,_,x,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,_,x,_,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type  Fourth = Fourth with 
        static member inline (?<-)(_,_,(_,_,_,x):'a*'b*'c*'d) = x
        static member inline (?<-)(_,_,(_,_,_,x,_):'a*'b*'c*'d*'e) = x
        static member inline (?<-)(_,_,(_,_,_,x,_,_):'a*'b*'c*'d*'e*'f) = x
        static member inline (?<-)(_,_,(_,_,_,x,_,_,_):'a*'b*'c*'d*'e*'f*'g) = x
        static member inline (?<-)(_,_,(_,_,_,x,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(_,_,_,x,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,_,_,x,_,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type   Fifth = Fifth with 
        static member inline (?<-)(_,_,(_,_,_,_,x):'a*'b*'c*'d*'e) = x
        static member inline (?<-)(_,_,(_,_,_,_,x,_):'a*'b*'c*'d*'e*'f) = x
        static member inline (?<-)(_,_,(_,_,_,_,x,_,_):'a*'b*'c*'d*'e*'f*'g) = x
        static member inline (?<-)(_,_,(_,_,_,_,x,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(_,_,_,_,x,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,_,_,_,x,_,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x
    
    type  Sixth = Sixth with 
        static member inline (?<-)(_,_,(_,_,_,_,_,x):'a*'b*'c*'d*'e*'f) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,x,_):'a*'b*'c*'d*'e*'f*'g) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,x,_,_):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,x,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,x,_,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type  Seventh = Seventh with 
        static member inline (?<-)(_,_,(_,_,_,_,_,_,x):'a*'b*'c*'d*'e*'f*'g) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,_,x,_):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,_,x,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,_,x,_,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type  Eighth = Eighth with 
        static member inline (?<-)(_,_,(_,_,_,_,_,_,_,x):'a*'b*'c*'d*'e*'f*'g*'h) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,_,_,x,_):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,_,_,x,_,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type  Ninth = Ninth with 
        static member inline (?<-)(_,_,(_,_,_,_,_,_,_,_,x):'a*'b*'c*'d*'e*'f*'g*'h*'i) = x
        static member inline (?<-)(_,_,(_,_,_,_,_,_,_,_,x,_):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

    type  Tenth = Tenth with 
        static member inline (?<-)(_,_,(_,_,_,_,_,_,_,_,_,x):'a*'b*'c*'d*'e*'f*'g*'h*'i*'j) = x

open TypeMaps

let inline first   x = (?<-) First   () x 
let inline second  x = (?<-) Second  () x 
let inline third   x = (?<-) Third   () x 
let inline fourth  x = (?<-) Fourth  () x 
let inline fifth   x = (?<-) Fifth   () x 
let inline sixth   x = (?<-) Sixth   () x 
let inline seventh x = (?<-) Seventh () x 
let inline eigth   x = (?<-) Eighth  () x 
let inline ninth   x = (?<-) Ninth   () x 
let inline tenth   x = (?<-) Tenth   () x 

/// Active Patterns For Matching against tuples
module Patterns =

    let inline (|Match1st|_|)  x tuple = let elm = first   tuple in if elm = x then Some elm else None
    let inline (|Match2nd|_|)  x tuple = let elm = second  tuple in if elm = x then Some elm else None
    let inline (|Match3rd|_|)  x tuple = let elm = third   tuple in if elm = x then Some elm else None
    let inline (|Match4th|_|)  x tuple = let elm = fourth  tuple in if elm = x then Some elm else None
    let inline (|Match5th|_|)  x tuple = let elm = fifth   tuple in if elm = x then Some elm else None
    let inline (|Match6th|_|)  x tuple = let elm = sixth   tuple in if elm = x then Some elm else None
    let inline (|Match7th|_|)  x tuple = let elm = seventh tuple in if elm = x then Some elm else None
    let inline (|Match8th|_|)  x tuple = let elm = eigth   tuple in if elm = x then Some elm else None
    let inline (|Match9th|_|)  x tuple = let elm = ninth   tuple in if elm = x then Some elm else None
    let inline (|Match10th|_|) x tuple = let elm = tenth   tuple in if elm = x then Some elm else None



type REKT = { Data : int }

let xform (rcd:REKT) b =  { rcd with Data = rcd.Data }

type REKT with
    member self.Xform b = xform self b

    


//type Flattener = Flattener with
//    static member inline (?<-) (_,_,(x1,(x2,x3))            ) = (x1,x2,x3)
//    static member inline (?<-) (_,_,((x1,x2),x3)            ) = (x1,x2,x3)
//    static member inline (?<-) (_,_,((x1,x2),x3,x4)         ) = (x1,x2,x3,x4)
//    static member inline (?<-) (_,_,(x1,(x2,x3),x4)         ) = (x1,x2,x3,x4)
//    static member inline (?<-) (_,_,(x1,x2,(x3,x4))         ) = (x1,x2,x3,x4)
//    static member inline (?<-) (_,_,(((x1,x2),x3),x4)       ) = (x1,x2,x3,x4)
//    static member inline (?<-) (_,_,(x1,((x2,x3),x4))       ) = (x1,x2,x3,x4)
//    static member inline (?<-) (_,_,(x1,(x2,(x3,x4)))       ) = (x1,x2,x3,x4)
//    static member inline (?<-) (_,_,((x1,x2),(x3,x4))       ) = (x1,x2,x3,x4)
//    static member inline (?<-) (_,_,((x1,x2),x3,x4,x5)      ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,(x2,x3),x4,x5)      ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,x2,(x3,x4),x5)      ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,x2,x3,(x4,x5))      ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,x2,x3),x4,x5)      ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,(x2,x3,x4),x5)      ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,x2,(x3,x4,x5))      ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,x2,x3),(x4,x5))    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,x2),(x3,x4,x5))    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,(x2,x3),(x4,x5))    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,x2),x3,(x4,x5))    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,x2),(x3,x4),x5)    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(((x1,x2,x3),x4),x5)    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,(x2,(x3,x4,x5)))    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(((x1,x2),x3),x4,x5)    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,(x2,x3)),x4,x5)    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,((x2,x3),x4),x5)    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,(x2,(x3,x4)),x5)    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,x2,((x3,x4),x5))    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,x2,(x3,(x4,x5)))    ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(((x1,x2),x3),(x4,x5))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,(x2,x3)),(x4,x5))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,x2),((x3,x4),x5))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,x2),(x3,(x4,x5)))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((((x1,x2),x3),x4),x5)  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(((x1,(x2,x3)),x4),x5)  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,((x2,x3),x4)),x5)  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,(x2,(x3,x4))),x5)  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,(x2,((x3,x4),x5)))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(x1,(x2,(x3,(x4,x5))))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((((x1,x2),x3,x4),x5))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(((x1,(x2,x3),x4),x5))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,(((x1,x2,(x3,x4)),x5))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,((x2,x3),x4,x5)))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,(x2,(x3,x4),x5)))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,(x2,x3,(x4,x5))))  ) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((((x1,x2),(x3,x4)),x5))) = (x1,x2,x3,x4,x5)
//    static member inline (?<-) (_,_,((x1,((x2,x3),(x4,x5))))) = (x1,x2,x3,x4,x5)
//
//let inline flatten tuple = (?<-) Flattener () tuple



//let rec flatr tuple 
