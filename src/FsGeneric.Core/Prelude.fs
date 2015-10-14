[<AutoOpen>]
module FsGeneric.Prelude

module TypeMaps =

    type Currier = Currier with
        static member inline (?<-) (_,_,fn) = fun a b                         -> fn (a,b)
        static member inline (?<-) (_,_,fn) = fun a b c                       -> fn (a,b,c)
        static member inline (?<-) (_,_,fn) = fun a b c d                     -> fn (a,b,c,d)
        static member inline (?<-) (_,_,fn) = fun a b c d e                   -> fn (a,b,c,d,e)
        static member inline (?<-) (_,_,fn) = fun a b c d e f                 -> fn (a,b,c,d,e,f)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g               -> fn (a,b,c,d,e,f,g)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h             -> fn (a,b,c,d,e,f,g,h)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i           -> fn (a,b,c,d,e,f,g,h,i)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j         -> fn (a,b,c,d,e,f,g,h,i,j)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k       -> fn (a,b,c,d,e,f,g,h,i,j,k)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k l     -> fn (a,b,c,d,e,f,g,h,i,j,k,l)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k l m   -> fn (a,b,c,d,e,f,g,h,i,j,k,l,m)
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k l m n -> fn (a,b,c,d,e,f,g,h,i,j,k,l,m,n)

    type RevCurrier = RevCurrier with
        static member inline (?<-) (_,_,fn) = fun a b                         -> fn (b,a                        )
        static member inline (?<-) (_,_,fn) = fun a b c                       -> fn (c,b,a                      )
        static member inline (?<-) (_,_,fn) = fun a b c d                     -> fn (d,c,b,a                    )
        static member inline (?<-) (_,_,fn) = fun a b c d e                   -> fn (e,d,c,b,a                  )
        static member inline (?<-) (_,_,fn) = fun a b c d e f                 -> fn (f,e,d,c,b,a                )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g               -> fn (g,f,e,d,c,b,a              )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h             -> fn (h,g,f,e,d,c,b,a            )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i           -> fn (i,h,g,f,e,d,c,b,a          )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j         -> fn (j,i,h,g,f,e,d,c,b,a        )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k       -> fn (k,j,i,h,g,f,e,d,c,b,a      )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k l     -> fn (l,k,j,i,h,g,f,e,d,c,b,a    )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k l m   -> fn (m,l,k,j,i,h,g,f,e,d,c,b,a  )
        static member inline (?<-) (_,_,fn) = fun a b c d e f g h i j k l m n -> fn (n,m,l,k,j,i,h,g,f,e,d,c,b,a)


open TypeMaps

/// Curry Prefix operator, take any function that takes a tupled arg of size 2-14 and convert it into
/// a function that takes the same number of args in the same order in curried form
let inline ( !| ) fn  = (?<-) Currier () fn

/// ReverseCurry Prefix operator, take any function that takes a tupled arg of size 2-14 and convert it into
/// a function that takes the same number of args in reverse order in curried form
let inline ( !|~) fn  = (?<-) RevCurrier () fn

/// Lambda Curry, take any function that takes a tupled arg of size 2-14 and convert it into
/// a function that takes the same number of args in the same order in curried form
let inline    λ   fn  = (?<-) Currier () fn