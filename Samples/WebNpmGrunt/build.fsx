#r @"FakeLib.dll"
open Fake
open Fake.NpmHelper

Target "InstallSilent" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = InstallSilent Standard
              })
   )

Target "Install" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = Install Standard
              })
   )

Target "RunSilent" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = RunSilent "test"
              })
   )

Target "Run" (fun _ ->
       Npm (fun p ->
              { p with
                  Command = Run "test"
              })
   )

RunTargetOrDefault "InstallSilent"