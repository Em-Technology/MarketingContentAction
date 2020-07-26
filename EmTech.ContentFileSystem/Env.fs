module EmTech.ContentFileSystem.Env
open System
    let environmentVariables = Environment.GetEnvironmentVariables()
    let printEnvFor key = printfn "Env: %s => %s" key (Environment.GetEnvironmentVariable(key))
    let printVariablesAndValues = for k in environmentVariables.Keys do
                                     printEnvFor (k.ToString())
