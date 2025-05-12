import { printf, toConsole } from "./fable_modules/fable-library-js.5.0.0-alpha.13/String.js";

export function Page() {
    return <div>
        <header>
            <h1>
                Welcome to Oxxpo
            </h1>
            <nav>
                <ul>
                    <li>
                        <a href="/">
                            Home
                        </a>
                    </li>
                    <li>
                        <a href="/contact">
                            Contact
                        </a>
                    </li>
                </ul>
            </nav>
        </header>
        <main>
            <section>
                <h2>
                    Your next-gen productivity tool
                </h2>
                <p>
                    Oxxpo helps you organize, collaborate, and achieve more.
                </p>
                <button onClick={(_arg) => {
                        toConsole(printf("it fucking works"));
                    }}>
                    Get Started
                </button>
            </section>
            <section id="features">
                <h3>
                    Features
                </h3>
                <ul>
                    <li>
                        Fast and intuitive UI
                    </li>
                    <li>
                        Real-time collaboration
                    </li>
                    <li>
                        Customizable workflows
                    </li>
                </ul>
            </section>
        </main>
        <footer>
            <p>
                © 2025 Oxxpo. All rights reserved.
            </p>
        </footer>
    </div>;
}

//# sourceMappingURL=App.fs.jsx.map
