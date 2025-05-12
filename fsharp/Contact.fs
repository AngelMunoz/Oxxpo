module Contact

open Oxpecker.Solid

[<SolidComponent>]
let Page() : HtmlElement = div() {
  header() {
    h1() { "Contact Oxxpo" }
    nav() { ul() { li() { a(href = "/") { "Home" } } } }
  }

  main() {
    section() {
      h2() { "Contact Us" }

      p() {
        "For inquiries, reach out to us at contact@oxxpo.com or use the form below."
      }

      form(
        onSubmit =
          fun e ->
            e.preventDefault()
            printfn "Form submitted"
      ) {
        label() { "Your Email:" }
        input(type' = "email", placeholder = "you@example.com")
        label() { "Message:" }
        textarea(placeholder = "Type your message here...")
        button(type' = "submit") { "Send" }
      }
    }
  }

  footer() { p() { "© 2025 Oxxpo. All rights reserved." } }
}
