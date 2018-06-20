namespace ReproLib

module Say =
    open Newtonsoft.Json
    type SayStuff = {
        name : string
        stuff : string        
    }

    let hello name =
        let sayStuff =
            {
                name = "Nat"
                stuff = "whaddup"
            }
        printfn "Hello %s" (Newtonsoft.Json.JsonConvert.SerializeObject sayStuff)