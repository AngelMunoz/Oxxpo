open Browser
open Oxpecker.Solid
open Oxpecker.Solid.Router



// HMR doesn't work in Root for some reason
[<SolidComponent>]
let Root() = Router() {
  Route(path = "/", component' = App.Page)
  Route(path = "/contact", component' = Contact.Page)
}

render(Root, document.getElementById "root")
