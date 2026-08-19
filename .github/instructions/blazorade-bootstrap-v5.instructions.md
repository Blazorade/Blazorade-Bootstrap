---
applyTo: "src/v5/Blazorade.Bootstrap/**"
---
# Blazorade Bootstrap v5

`Blazorade.Bootstrap` is the new Blazorade component library for Bootstrap 5.

## Project boundary

- Treat `Blazorade.Bootstrap.Components` as the legacy library. It targets an older Bootstrap generation and must not be modernized, migrated, or changed as part of work on this library unless explicitly requested.
- Keep the new library independently maintainable from the legacy library. Do not introduce dependencies from `Blazorade.Bootstrap` to `Blazorade.Bootstrap.Components`.
- New components, APIs, CSS classes, JavaScript interop, and documentation references in this project must target Bootstrap 5 behavior and conventions.
- Do not copy legacy implementation details merely for consistency. Reuse an approach only after verifying that it is compatible with Bootstrap 5.
- Preserve the public API and implementation choices of this library as a separate version line; compatibility with the legacy library is not an implicit requirement.

## Coding style and component scope

- Follow the established coding style, naming conventions, component structure, and implementation patterns of `Blazorade.Bootstrap.Components` where they are compatible with Bootstrap 5.
- Use relevant legacy components as implementation references for handling component behavior, lifecycle, parameters, rendering, and JavaScript interop. Pay particular attention to components whose `.razor` files are paired with substantial `.razor.cs` code-behind files.
- Include only components and APIs that are relevant to Bootstrap 5. Do not reproduce legacy components solely to achieve feature parity.
- When a legacy pattern conflicts with Bootstrap 5 behavior, retain the coding style where practical but implement the Bootstrap 5 behavior instead.

## Usability and defaults

- Every component must work with sensible defaults when used without parameters whenever the component can reasonably determine those defaults.
- Do not make client applications provide values for parameters that are only technically required by Bootstrap markup or CSS. Select a sensible default instead.
- The `Color` parameter must have a component-appropriate default whenever it has not been set. For example, `Alert` defaults to `NamedColor.Primary`; different components may intentionally choose different default colours.
- Parameters, child components, and templates must remain available for progressively customizing the simple default usage.
- Prefer an API that makes the simplest useful markup short, discoverable through IntelliSense, and free of unnecessary configuration.

## Blazorade design principles

- Write less markup by encapsulating Bootstrap's required structure and boilerplate.
- Have less to remember by exposing sensible component parameters, enums, and templates instead of requiring raw Bootstrap details.
- Rely on IntelliSense and auto-complete through descriptive names and strongly typed options.
- Write no JavaScript in client applications for functionality the component library can provide through its APIs. JavaScript interop belongs inside the library when Bootstrap requires it.

For background and the original explanations, see the [Blazorade Bootstrap Design Principles](https://github.com/Blazorade/Blazorade-Bootstrap/wiki/Design-Principles).

## Documentation

- New documentation for this library belongs under `docs/`.
- Treat `docs/` as source documentation, not as a restored copy of the removed legacy static site.
- Do not add generated static-site output or framework deployment artifacts to `docs/` unless explicitly requested.

## Showroom

- Every component added to `Blazorade.Bootstrap` must also be added to the v5 component showroom under `src/v5/Blazorade.Bootstrap.Showroom/`.
- Whenever an existing component is modified, the corresponding v5 showroom page must be updated to properly reflect those modifications.
