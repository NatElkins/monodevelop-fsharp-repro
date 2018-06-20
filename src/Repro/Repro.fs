module Repro

[<EntryPoint>]
let main argv =
    ReproLib.Say.hello "Nat"
    printfn "%A" argv
    0 // return an integer exit code
