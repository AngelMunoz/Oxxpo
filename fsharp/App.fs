module App

open Oxpecker.Solid

[<SolidComponent>]
let Page () : HtmlElement =
    div () {
        header () {
            h1 () { "Welcome to Oxxpo" }

            nav () {
                ul () {
                    li () { a (href = "/") { "Home" } }
                    li () { a (href = "/contact") { "Contact" } }

                }
            }
        }

        main () {
            section () {
                h2 () { "Your next-gen productivity tool" }
                p () { "Oxxpo helps you organize, collaborate, and achieve more." }
                button (onClick = fun _ -> printfn "it fucking works") { "Get Started" }
            }

            section (id = "features") {
                h3 () { "Features" }

                ul () {
                    li () { "Fast and intuitive UI" }
                    li () { "Real-time collaboration" }
                    li () { "Customizable workflows" }
                }
            }
        }

        footer () { p () { "© 2025 Oxxpo. All rights reserved." } }
    }
