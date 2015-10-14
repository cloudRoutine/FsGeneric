module FsGeneric.Properties


let inline getLength     x   = (^a:(member Length:     'b) x)
let inline getLongLength x   = (^a:(member LongLength: 'b) x)
let inline getWidth      x   = (^a:(member Width:      'b) x)
let inline getHeight     x   = (^a:(member Height:     'b) x)
let inline getCount      x   = (^a:(member Count:      'b) x)
let inline getName       x   = (^a:(member Name :      'b) x)



let inline setLength     x elm = (^a:(member set_Length:     'b->unit) x, elm); x
let inline setLongLength x elm = (^a:(member set_LongLength: 'b->unit) x, elm); x
let inline setWidth      x elm = (^a:(member set_Width:      'b->unit) x, elm); x
let inline setHeight     x elm = (^a:(member set_Height:     'b->unit) x, elm); x
let inline setCount      x elm = (^a:(member set_Count:      'b->unit) x, elm); x
let inline setName       x elm = (^a:(member set_Name :      'b->unit) x, elm); x


// The effectful generic property sets return unit and are not useful for pipelining
module Effectful =

    let inline setLength     x elm = (^a:(member set_Length:     'b->unit) x, elm)
    let inline setLongLength x elm = (^a:(member set_LongLength: 'b->unit) x, elm)
    let inline setWidth      x elm = (^a:(member set_Width:      'b->unit) x, elm)
    let inline setHeight     x elm = (^a:(member set_Height:     'b->unit) x, elm)
    let inline setCount      x elm = (^a:(member set_Count:      'b->unit) x, elm)
    let inline setName       x elm = (^a:(member set_Name :      'b->unit) x, elm)


