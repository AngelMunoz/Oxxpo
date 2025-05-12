import { Route, Router } from "@solidjs/router";
import { Page } from "./App.fs.jsx";
import { render } from "solid-js/web";

export function Root() {
    return <Router>
        <Route path="/"
            component={Page} />
    </Router>;
}

render(Root, document.getElementById("root"));

//# sourceMappingURL=Program.fs.jsx.map
