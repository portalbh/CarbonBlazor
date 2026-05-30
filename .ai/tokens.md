# CarbonBlazor Design Tokens And Theme Mapping

This file maps the CarbonBlazor CSS custom properties used in `carbon-blazor.css` so AI agents can style custom content without violating Carbon theme behavior.

## Theme Model
- Base token set is declared in `:root, .cb-theme[data-theme="white"]`.
- Other themes override a subset of tokens.
- Theme enum values (`CbTheme`): `White`, `G10`, `G90`, `G100`, `Teal`.

## Base Tokens (White)

### Foundation Colors
- `--cb-background: #ffffff`
- `--cb-layer: #f4f4f4`
- `--cb-layer-accent: #e0e0e0`
- `--cb-layer-hover: #e8e8e8`
- `--cb-field: #f4f4f4`
- `--cb-field-hover: #e8e8e8`

### Text And Icon
- `--cb-text-primary: #161616`
- `--cb-text-secondary: #525252`
- `--cb-text-placeholder: #8d8d8d`
- `--cb-text-disabled: #8d8d8d`
- `--cb-text-on-color: #ffffff`
- `--cb-icon-primary: #161616`
- `--cb-icon-disabled: #c6c6c6`

### Border, Focus, Interactive
- `--cb-border-subtle: #e0e0e0`
- `--cb-border-strong: #8d8d8d`
- `--cb-border-disabled: #c6c6c6`
- `--cb-border-interactive: #0f62fe`
- `--cb-focus: #0f62fe`
- `--cb-interactive: #0f62fe`
- `--cb-text-link: #0f62fe`

### Button And Semantic Tokens
- `--cb-button-primary: #0f62fe`
- `--cb-button-primary-hover: #0050e6`
- `--cb-button-secondary: #393939`
- `--cb-button-secondary-hover: #4c4c4c`
- `--cb-button-disabled: #c6c6c6`
- `--cb-danger: #da1e28`
- `--cb-danger-hover: #ba1b23`
- `--cb-support-success: #24a148`
- `--cb-support-warning: #f1c21b`
- `--cb-support-error: #da1e28`
- `--cb-support-info: #0f62fe`
- `--cb-overlay: rgba(22, 22, 22, 0.5)`

### Spacing Scale
- `--cb-spacing-01: 0.125rem`
- `--cb-spacing-02: 0.25rem`
- `--cb-spacing-03: 0.5rem`
- `--cb-spacing-04: 0.75rem`
- `--cb-spacing-05: 1rem`
- `--cb-spacing-06: 1.5rem`
- `--cb-spacing-07: 2rem`
- `--cb-spacing-08: 2.5rem`
- `--cb-spacing-09: 3rem`
- `--cb-spacing-10: 4rem`
- `--cb-spacing-11: 5rem`
- `--cb-spacing-12: 6rem`

### Motion Tokens
- `--cb-motion-fast: 110ms cubic-bezier(0.2, 0, 0.38, 0.9)`
- `--cb-motion-moderate: 240ms cubic-bezier(0.4, 0, 0.2, 1)`
- `--cb-motion-slow: 400ms cubic-bezier(0.4, 0, 0.2, 1)`

## Theme Overrides

### G10 (`.cb-theme[data-theme="g10"]`)
Purpose: lighter gray app background with white content layers.

Overrides:
- `--cb-background: #f4f4f4`
- `--cb-layer: #ffffff`
- `--cb-layer-accent: #e0e0e0`
- `--cb-layer-hover: #e8e8e8`
- `--cb-field: #ffffff`

### G90 (`.cb-theme[data-theme="g90"]`)
Purpose: dark gray theme.

Overrides include:
- `color-scheme: dark`
- `--cb-background: #262626`
- `--cb-layer: #393939`
- `--cb-layer-accent: #525252`
- `--cb-layer-hover: #474747`
- `--cb-field: #393939`
- `--cb-field-hover: #474747`
- `--cb-text-primary: #f4f4f4`
- `--cb-text-secondary: #c6c6c6`
- `--cb-text-placeholder: #8d8d8d`
- `--cb-text-on-color: #ffffff`
- `--cb-icon-primary: #f4f4f4`
- `--cb-border-subtle: #525252`
- `--cb-border-strong: #8d8d8d`
- `--cb-border-interactive: #78a9ff`
- `--cb-focus: #ffffff`
- `--cb-interactive: #78a9ff`
- `--cb-text-link: #78a9ff`
- `--cb-button-primary: #0f62fe`
- `--cb-button-primary-hover: #0353e9`
- `--cb-overlay: rgba(0, 0, 0, 0.65)`

### G100 (`.cb-theme[data-theme="g100"]`)
Purpose: deepest dark theme.

Overrides include:
- `color-scheme: dark`
- `--cb-background: #161616`
- `--cb-layer: #262626`
- `--cb-layer-accent: #393939`
- `--cb-layer-hover: #333333`
- `--cb-field: #262626`
- `--cb-field-hover: #333333`
- `--cb-text-primary: #f4f4f4`
- `--cb-text-secondary: #c6c6c6`
- `--cb-text-placeholder: #8d8d8d`
- `--cb-icon-primary: #f4f4f4`
- `--cb-border-subtle: #393939`
- `--cb-border-strong: #6f6f6f`
- `--cb-border-interactive: #78a9ff`
- `--cb-focus: #ffffff`
- `--cb-interactive: #78a9ff`
- `--cb-text-link: #78a9ff`
- `--cb-button-primary: #0f62fe`
- `--cb-button-primary-hover: #0353e9`
- `--cb-overlay: rgba(0, 0, 0, 0.72)`

### Teal (`.cb-theme[data-theme="teal"]`)
Purpose: white-based theme with teal interactive accents.

Overrides:
- `color-scheme: light`
- `--cb-focus: #0d9488`
- `--cb-interactive: #0d9488`
- `--cb-text-link: #0d9488`
- `--cb-border-interactive: #0d9488`
- `--cb-button-primary: #0d9488`
- `--cb-button-primary-hover: #0f766e`
- `--cb-support-info: #0d9488`

## CSS Naming Conventions
- Prefix all CarbonBlazor utility/component classes with `cb-`.
- Use BEM-like element/modifier segments:
  - Element: `cb-header__nav`, `cb-side-nav__link`
  - Modifier: `cb-btn--primary`, `cb-side-nav--open`

Common classes:
- Theme and utility: `cb-theme`, `cb-layer`, `cb-scroll-lock`, `cb-sr-only`, `cb-focus-ring`
- Shell: `cb-header`, `cb-side-nav`, `cb-content`, `cb-breadcrumb`
- Actions/forms/data: `cb-btn`, `cb-icon-btn`, `cb-input`, `cb-select`, `cb-toggle`, `cb-data-table`, `cb-pagination`
- Overlays/feedback: `cb-modal`, `cb-popover`, `cb-tooltip`, `cb-notification`, `cb-tag`

## AI Styling Rules
- Always consume existing tokens (`var(--cb-...)`) for color, spacing, and motion.
- Never hardcode palette values in new demo styles unless the task explicitly asks for a new token.
- Preserve focus visibility (`:focus-visible`) and don’t disable outlines globally.
- Assume tokens may differ by theme; avoid contrast assumptions based only on White theme.
