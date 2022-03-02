open Library

[<EntryPoint>]
let main args =
    printfn "Nice command-line arguments! Here's what System.Text.Json has to say about them:"

    let value, json = getJson {| args=args; year=System.DateTime.Now.Year; foo="bar" |}
    
    // https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/plaintext-formatting
    printfn $"Input: %0A{value}" // Print width 0 results in a single line of text
    printfn $"Output: %s{json}"

    0 // return an integer exit code