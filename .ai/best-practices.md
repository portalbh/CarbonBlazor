# CarbonBlazor AI Best Practices For Demo Pages

This guide defines how an AI agent should generate new pages in `CarbonBlazor.Demo`.

## 1) Standard Page Blueprint
Use this high-level structure for every page:

1. Add route at top, for example `@page "/login"`.
2. Start with one `h1` heading and a short descriptive paragraph.
3. Group content in sections/cards similar to existing demo pages.
4. Use CarbonBlazor components for all interactive UI.

If creating app-shell content, align with existing layout in `MainLayout.razor`:
- `CbThemeProvider`
- `CbHeader`
- `CbSideNav`
- `CbContent`

## 2) Required Project Wiring
- In `Program.cs` ensure:
  - `builder.Services.AddCarbonBlazor();`
- Import component namespaces in `_Imports.razor` or page file.

## 3) Form Patterns (Login/Signup/Profile)
For authentication or data-entry pages:

1. Use `CbTextInput` for email/user/password fields.
2. Use `CbCheckbox` for remember-me/consent options.
3. Use `CbButton` for primary submit action.
4. Use `CbNotification` for form-level success/error messages.
5. Show field-level validation via `Invalid` and `InvalidText`.

Example pattern:

```razor
@page "/login"

<h1>Sign in</h1>
<p>Use your workspace account to continue.</p>

<section class="cb-demo-card" aria-labelledby="login-title">
  <h2 id="login-title">Credentials</h2>

  <CbTextInput Label="Email" Type="email" @bind-Value="_email" />
  <CbTextInput Label="Password" Type="password" @bind-Value="_password" />
  <CbCheckbox @bind-Value="_rememberMe">Remember me</CbCheckbox>

  <CbButton Variant="CbButtonVariant.Primary" OnClick="SignIn">Sign in</CbButton>
</section>

@if (!string.IsNullOrWhiteSpace(_error))
{
  <CbNotification Kind="CbNotificationKind.Error" Title="Sign in failed" Subtitle="@_error" Closeable="true" />
}

@code {
  private string? _email;
  private string? _password;
  private bool _rememberMe;
  private string? _error;

  private Task SignIn()
  {
    _error = string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_password)
      ? "Email and password are required."
      : null;

    return Task.CompletedTask;
  }
}
```

## 4) Accessibility Rules
Always follow these rules when generating UI:

1. Provide meaningful labels for every form control.
2. Use semantic headings (`h1` then `h2` in order).
3. Prefer built-in component semantics over custom ARIA.
4. Preserve keyboard interaction patterns (tabs, menus, modals, tree view).
5. Keep visible focus indicators.
6. Use `CbIconButton.Label` and icon labels for icon-only controls.

## 5) Interaction Rules
- Bind state with `@bind-*` patterns when available.
- Use `EventCallback` handlers (`OnClick`, `OnDismiss`, `OnClose`) for explicit events.
- For dialogs/popovers/tooltips, use `CbModal`, `CbPopover`, `CbTooltip`, `CbToggletip` instead of custom JS.

## 6) Carbon Styling Rules
- Use existing `cb-` classes and token-based values from `var(--cb-...)`.
- Reuse spacing tokens (`--cb-spacing-*`) for margins/padding.
- Avoid hardcoded background/text colors.
- Ensure dark themes (`G90`, `G100`) remain readable.

## 7) Data Display Rules
- Use `CbDataTable` for tabular data.
- Use `CbPagination` for multi-page collections.
- Use `CbTreeView` for hierarchical data.
- Use `CbStructuredList` for lightweight row/column summaries.

## 8) Do Not Generate
- Raw HTML controls that duplicate existing components.
- CSS that resets global focus styles.
- Theme-specific hardcoding that breaks other `CbTheme` options.
- Non-Carbon class naming conventions.

## 9) Placement And Navigation In Demo
When adding a new demo page:

1. Add file under `CarbonBlazor.Demo/Pages`.
2. Add route (`@page`).
3. Add nav links in `MainLayout.razor` (`CbHeaderNavLink` and/or `CbSideNavLink`).
4. Keep page content consistent with the existing visual rhythm.
