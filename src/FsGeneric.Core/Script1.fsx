
type GMap = GMap with
    static member inline (?<-) (_,ar,fn)                    = Array.map   fn ar
    static member inline (?<-) (_,ar2d,fn)                  = Array2D.map fn ar2d
    static member inline (?<-) (_,ls,fn)                    = List.map    fn ls
    static member inline (?<-) (_,sq,fn)                    = Seq.map     fn sq 
    static member inline (?<-) (_,st,fn)                    = Set.map     fn st
    static member inline (?<-) (_,mp,fn)                    = Map.map     fn mp
    static member inline (?<-) (_,x:'x,fn)                  = (^x:(member Map:('a->'b)->'y) x,fn)

type GMap2 = GMap2 with
    static member inline (?<-) (_,ar1,(ar2,fn))             = Array.map2 fn ar1 ar2
    static member inline (?<-) (_,ls1,(ls2,fn))             = List.map2  fn ls1 ls2
    static member inline (?<-) (_,sq1,(sq2,fn))             = Seq.map2   fn sq1 sq2 
 
type GRev = GRev with
    static member inline (?<-) (_,_,arr: 'a [] )            = Array.rev arr    
    static member inline (?<-) (_,_,ls: 'a list)            = List .rev ls
    static member inline (?<-) (_,_,sqs: 'a seq)            = Seq  .rev sqs 




let inline map  mapfn  xs     = (?<-) GMap xs   mapfn
