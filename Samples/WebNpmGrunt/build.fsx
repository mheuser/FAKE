#r @"FakeLib.dll"
open Fake
open Fake.NpmHelper


Target "Install" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = Install Standard
              })
   )

Target "Run" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = Run "test"
              })
   )

Target "RunSilent" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = Run "test"
              })
   )

Target "Test" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = Test
              })
   )

"Install"
  ==> "Test"

RunTargetOrDefault "Test"