// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module Recursion.Main
open System
open System.IO
open System.Numerics
open System.Text

let rec map f = function     
    | [] -> [] 
    | x::xs -> f x::map f xs  

          

let map2 f l =
    let rec loop acc = function
        | [] -> List.rev acc
        | x::xs -> loop (f x::acc) xs
    loop [] l

let map3 f l =
    let rec loop cont = function
        | [] -> cont []
        | x::xs -> loop ( fun acc -> cont (f x::acc) ) xs
    loop id l




printfn "Pick a number (but not your nose) from 1-9:"
let response = Console.ReadLine()
printfn "You picked: %s" response
//let Console.WriteLine
let factorial n =
    let rec fact n acc =
        match n with
        | 0 -> acc
        | _ -> fact (n-1) (acc * n)
    fact n 1 |> ignore
    printfn "%s %i" 
   
     



[<EntryPoint>]
let main argv = 
    let x = 1
    let xs = 2
    let x = 1
    let xs = 2
    let greeting = "Greetings, fellow Nerd!" 
//    let fn = (factorial (n))       

    printfn "%s" greeting
//    printfn "factorial %i = %i"

    0 // return an integer exit code

