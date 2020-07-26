namespace EmTech.ContentFileSystem
open System.IO;
module FileManagement =
    let currentDirectory = Directory.GetCurrentDirectory()
    let fileList directory = Directory.GetFiles(directory, "*.*")
    let fileListOfCurrentDirectory = fileList currentDirectory
    let logCurrentDirectory = for dir in fileListOfCurrentDirectory do
                                  printfn "%s" dir