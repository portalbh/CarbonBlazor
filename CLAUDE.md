# CarbonBlazor Architecture Guide

## Project Layout

- `CarbonBlazor/` contains the Razor class library components, shared enums, internal helpers, and static assets shipped from `_content/CarbonBlazor/`.
- `CarbonBlazor.Demo/` is the Blazor WebAssembly demo used to exercise the package in a browser.
- `CarbonBlazor.Tests/` contains bUnit component tests.
- `CarbonBlazor/wwwroot/carbon-blazor.css` defines tokens, themes, component classes, and responsive rules.
- `CarbonBlazor/wwwroot/carbon-blazor.js` contains small interop helpers for focus management, scroll locking, roving focus, and outside-click handling.

## Component Pattern

Components generally follow the same shape:

1. Parameters define the public API.
2. `CssBuilder` composes the base class, state classes, and user-supplied `Class`.
3. Markup renders semantic HTML first, then ARIA attributes and data attributes as needed.
4. `AdditionalAttributes` are captured for pass-through attributes on the primary element.

Prefer native HTML controls before custom interaction logic. When a component needs JavaScript, import `./_content/CarbonBlazor/carbon-blazor.js` lazily and dispose the module when the component owns it.

## Adding Components

1. Add the component under the closest feature folder in `CarbonBlazor/Components/`.
2. Add shared enum values to `CarbonBlazor/Enums.cs` only when the choice is part of the public API.
3. Add CSS in `carbon-blazor.css` using existing token names before adding new tokens.
4. Add at least one bUnit test for semantics or interaction.
5. Add a demo example when the component is user-facing.

## Tokens And Themes

The white theme in `:root, .cb-theme[data-theme="white"]` defines the full token set. Other theme blocks override only token values that differ. Component CSS should consume tokens such as `--cb-layer`, `--cb-text-primary`, `--cb-interactive`, `--cb-support-error`, and spacing tokens instead of hardcoded colors.

## JavaScript Interop

The registered `CarbonBlazorJsModule` service from `AddCarbonBlazor()` provides a shared module loader for consumers. Components may still import the module directly when they need tight lifecycle control. Keep JS helpers small and framework-agnostic.

## Local Verification

Run:

```bash
dotnet restore CarbonBlazor.slnx
dotnet build CarbonBlazor.slnx
dotnet test CarbonBlazor.slnx
dotnet run --project CarbonBlazor.Demo
```

For interaction changes, verify keyboard navigation and focus states in the demo, especially modal focus trapping, tree view arrow keys, menu outside-click close, and invalid form states.
