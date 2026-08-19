---
applyTo: "Blazorade.Bootstrap/**"
---
# Blazorade Bootstrap v5

`Blazorade.Bootstrap` is the new Blazorade component library for Bootstrap 5.

## Project boundary

- Treat `Blazorade.Bootstrap.Components` as the legacy library. It targets an older Bootstrap generation and must not be modernized, migrated, or changed as part of work on this library unless explicitly requested.
- Keep the new library independently maintainable from the legacy library. Do not introduce dependencies from `Blazorade.Bootstrap` to `Blazorade.Bootstrap.Components`.
- New components, APIs, CSS classes, JavaScript interop, and documentation references in this project must target Bootstrap 5 behavior and conventions.
- Do not copy legacy implementation details merely for consistency. Reuse an approach only after verifying that it is compatible with Bootstrap 5.
- Preserve the public API and implementation choices of this library as a separate version line; compatibility with the legacy library is not an implicit requirement.

## Documentation

- New documentation for this library belongs under `docs/`.
- Treat `docs/` as source documentation, not as a restored copy of the removed legacy static site.
- Do not add generated static-site output or framework deployment artifacts to `docs/` unless explicitly requested.
