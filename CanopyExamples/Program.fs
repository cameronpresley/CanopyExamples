open canopy

[<EntryPoint>]
let main _ =
  configuration.wipSleep <- 0.2
  configuration.compareTimeout <- 10.0
  configuration.elementTimeout <- 10.0
  configuration.pageTimeout <- 10.0
  configuration.failFast := true


  start chrome
  resize (1400, 900)

  homePage.all()

  run()

  printfn "Press [enter] to quit"
  System.Console.ReadKey() |> ignore
  quit()

  canopy.runner.failedCount