module FsGeneric.Collections

(*

type G = G with
    static member inline (?<-) (_,arr: 'a [] ,fn)     = Array. fn arr    
    static member inline (?<-) (_,ls: 'a list,fn)     = List . fn ls
    static member inline (?<-) (_,sqs: 'a seq,fn)     = Seq  . fn sqs 

*)

// the typemaps are in a nested module so that users can open the parent module to
// gain access to all of the generic function that they want to use without
// this large number of typemaps polluting their autocomplete lists
module TypeMaps =
    open System.Collections
    open System.Collections.Generic
    

    type GAppend = GAppend with
        static member inline (?<-) (_,ar1:'a []  ,ar2)          = Array.append ar1 ar2   
        static member inline (?<-) (_,ls1:'a list,ls2)          = List.append  ls1 ls2
        static member inline (?<-) (_,sq1:'a seq ,sq2)          = Seq.append   sq1 sq2

    type GChoose = GChoose with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.choose fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .choose fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .choose fn sq 

    type GCollect = GCollect with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.collect fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List.collect  fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq.collect   fn sq 

    type GCompareWith = GCompareWith with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.compareWith fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List.compareWith  fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq.compareWith   fn sq 

    type GConcat = GConcat with
        static member inline (?<-) (_,_,ar:'a []   seq)         = Array.concat ar  
        static member inline (?<-) (_,_,ls:'a list seq)         = List .concat ls 
        static member inline (?<-) (_,_,sq:'a seq  seq)         = Seq  .concat sq 

    type GContains = GContains with
        static member inline (?<-) (_,ar:'a []  ,elm)           = Array.contains elm ar    
        static member inline (?<-) (_,ls:'a list,elm)           = List .contains elm ls
        static member inline (?<-) (_,sq:'a seq ,elm)           = Seq  .contains elm sq 

    type GCountBy = GCountBy with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.countBy fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .countBy fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .countBy fn sq 

    type GDistinct = GDistinct with
        static member inline (?<-) (_,_,ar:'a []  )             = Array.distinct ar    
        static member inline (?<-) (_,_,ls:'a list)             = List .distinct ls
        static member inline (?<-) (_,_,sq:'a seq )             = Seq  .distinct sq 

    type GDistinctBy = GDistinctBy with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.distinctBy fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .distinctBy fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .distinctBy fn sq 

    type GExists = GExists with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.exists fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .exists fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .exists fn sq 

    type GExists2 = GExists2 with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.exists2 fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .exists2 fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .exists2 fn sq 

    type GFilter = GFilter with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.filter fn ar
        static member inline (?<-) (_,ls:'a list,fn)            = List.filter  fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq.filter   fn sq 
        static member inline (?<-) (_,st:'a Set ,fn)            = Set.filter   fn st
        static member inline (?<-) (_,mp:Map<'a,'b>,fn)         = Map.filter   fn mp

    type GFind = GFind with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.find fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .find fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .find fn sq 
    
    type GFindBack = GFindBack with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.findBack fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .findBack fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .findBack fn sq 

    type GFindIndex = GFindIndex with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.findIndex fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .findIndex fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .findIndex fn sq 
    
    type GFindIndexBack = GFindIndexBack with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.findIndexBack fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .findIndexBack fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .findIndexBack fn sq 

    type GFold = GFold with
        static member inline (?<-) (_,ar:'a []  ,(sd,fn))       = Array.fold fn sd ar    
        static member inline (?<-) (_,ls:'a list,(sd,fn))       = List .fold fn sd ls
        static member inline (?<-) (_,sq:'a seq ,(sd,fn))       = Seq  .fold fn sd sq 
        static member inline (?<-) (_,xs:'a Set ,(sd,fn))       = Set  .fold fn sd xs 

    type GFold2 = GFold2 with
        static member inline (?<-) (_,ar:'a []  ,(sd,fn))       = Array.fold fn sd ar    
        static member inline (?<-) (_,ls:'a list,(sd,fn))       = List .fold fn sd ls
        static member inline (?<-) (_,sq:'a seq ,(sd,fn))       = Seq  .fold fn sd sq 

    type GFoldBack = GFoldBack with
        static member inline (?<-) (_,ar:'a []  ,(sd,fn))       = Array.fold fn sd ar    
        static member inline (?<-) (_,ls:'a list,(sd,fn))       = List .fold fn sd ls
        static member inline (?<-) (_,sq:'a seq ,(sd,fn))       = Seq  .fold fn sd sq 

    type GFoldBack2 = GFoldBack2 with
        static member inline (?<-) (_,ar:'a []  ,(sd,fn))       = Array.fold fn sd ar    
        static member inline (?<-) (_,ls:'a list,(sd,fn))       = List .fold fn sd ls
        static member inline (?<-) (_,sq:'a seq ,(sd,fn))       = Seq  .fold fn sd sq 

    type GForall = GForall with
        static member inline (?<-) (_,ar:'a []  ,fn)            = Array.forall fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List .forall fn ls
        static member inline (?<-) (_,sq:'a seq ,fn)            = Seq  .forall fn sq 

    type GForall2 = GForall2 with
        static member inline (?<-) (_,ar1:'a []  ,(ar2,fn))     = Array.forall2 fn ar1 ar2    
        static member inline (?<-) (_,ls1:'a list,(ls2,fn))     = List .forall2 fn ls1 ls2
        static member inline (?<-) (_,sq1:'a seq ,(sq2,fn))     = Seq  .forall2 fn sq1 sq2 

    type GIter = GIter with
        static member inline (?<-) (_,ar:'a [],fn)              = Array.iter fn ar
        static member inline (?<-) (_,ls:'a list,fn)            = List.iter  fn ls
        static member inline (?<-) (_,sq:'a seq,fn)             = Seq.iter   fn sq 
        static member inline (?<-) (_,st:'a Set,fn)             = Set.iter   fn st
        static member inline (?<-) (_,mp:Map<'a,'b>,fn)         = Map.iter   fn mp
        static member inline (?<-) (_,x:'x,fn)                  = (^x:(member Iter:('a->unit)->unit)x,fn)


    type GIter2 = GIter2 with
        static member inline (?<-) (_,ar1:'a []  ,(ar2,fn))     = Array.iter2 fn ar1 ar2
        static member inline (?<-) (_,ls1:'a list,(ls2,fn))     = List .iter2 fn ls1 ls2
        static member inline (?<-) (_,sq1:'a seq ,(sq2,fn))     = Seq  .iter2 fn sq1 sq2 

    type GIteri = GIteri with
        static member inline (?<-) (_,ar:'a [] ,fn)             = Array.iteri fn ar    
        static member inline (?<-) (_,ls:'a list,fn)            = List.iteri  fn ls
        static member inline (?<-) (_,sq:'a seq,fn)             = Seq.iteri   fn sq 
        static member inline (?<-) (_,x:'x,fn)                  = (^x:(member Iter:(int->'a->unit)->unit)x,fn)

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

 open TypeMaps



let inline append   xs     ys     = (?<-) GAppend  xs   ys
let inline collect  mapfn  xs     = (?<-) GCollect xs   mapfn
let inline filter   pred   xs     = (?<-) GFilter  xs   pred
let inline iter     iterfn xs     = (?<-) GIter    xs   iterfn
let inline iteri    iterfn xs     = (?<-) GIteri   xs   iterfn
let inline map      mapfn  xs     = (?<-) GMap     xs   mapfn
let inline map2     mapfn  xs ys  = (?<-) GMap2    xs   (ys,mapfn)
let inline rev      xs            = (?<-) GRev     xs   