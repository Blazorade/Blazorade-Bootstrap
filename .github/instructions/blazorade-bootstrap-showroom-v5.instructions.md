---
applyTo: "src/v5/{Blazorade.Bootstrap.Showroom,ServerDevAppv5}/**"
---
# Blazorade Bootstrap v5 showroom

The v5 showroom is both executable documentation and a reusable set of routable pages for applications that reference the showroom assembly.

## Showcase structure

- Every component showcase page must begin with the simplest useful parameter-free example whenever the component supports one. For example: `<Alert>This is the simplest possible alert.</Alert>`.
- Follow the simplest example with focused examples of the component's important defaults, parameters, child content, templates, events, and advanced behavior.
- Keep examples concrete and runnable. Do not add placeholder content or demonstrations that do not exercise a real component capability.
- Use the showcase to make the default API obvious: users should be able to copy the first example and get a useful result without additional configuration.

## Routing and navigation

- Component showcase pages must be routable with an `@page` directive and must remain usable when the showroom assembly is added to an application's router and endpoint discovery.
- Every routable showcase page must be linked from the plain HTML/Bootstrap `Components` dropdown in `ShowroomNavigation.razor`.
- List showroom components in alphabetical order in the `Components` dropdown and on any showroom home page component listing.
- Keep showroom navigation independent of the Blazorade components being showcased. Navigation must use ordinary HTML and Bootstrap markup rather than showcase components.

## Showroom home page

- Every component featured in the showroom must have a card on the hosting application's home page at `src/v5/ServerDevAppv5/Components/Pages/Home.razor`.
- Add home page cards in alphabetical order and link each card to the component's showroom page.
- Every home page card must use a dedicated generated image from `src/v5/ServerDevAppv5/wwwroot/images/` that visually represents the showcased component.
- Use meaningful accessible alternative text for every generated component image.

## Design principles

Showroom pages demonstrate the Blazorade principles: write less markup, have less to remember, rely on IntelliSense and auto-complete, and write no JavaScript unless the application explicitly chooses to use it. Prefer component APIs and C# event handlers over handwritten Bootstrap JavaScript.
