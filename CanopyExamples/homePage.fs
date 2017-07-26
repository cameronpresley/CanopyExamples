module homePage
open canopy
open runner

let all () =

    once (fun _ -> 
        url "http://blog.thesoftwarementor.com"
    )

    "When I'm on the home page, I should see the Speaking Schedule button" &&& fun _ ->
        let speakingSchedule = elementWithText "li" "SPEAKING SCHEDULE"
        speakingSchedule.Displayed === true

    "When I'm on the home page, I should see the Presentations button" &&& fun _ ->
        let presentations = elementWithText "li" "PRESENTATIONS"
        presentations.Displayed === true

    "When I'm on the home page, I should see 5 articles" &&& fun _ ->
       let articles = element "#primary" |> elementWithin "#main" |> elementsWithin "article"
       articles |> List.length |> (===) 5

    "When I'm on the home page, I should have the option to see older posts" &&& fun _ ->
        let olderPosts = elementWithText "button" "Older posts"
        olderPosts.Displayed === true