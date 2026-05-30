# CarbonBlazor Component API Reference (AI)

This index is intended for AI coding agents so they can use CarbonBlazor components without reading every source file.

Legend:
- Required params are enforced with `[EditorRequired]`.
- Slot means a `RenderFragment` parameter.
- Most components also support `Class` and `AdditionalAttributes` when listed.

## Shared Enums
- `CbTheme`: `White`, `G10`, `G90`, `G100`, `Teal`
- `CbLayerLevel`: `One`, `Two`, `Three`
- `CbSize`: `Small`, `Medium`, `Large`
- `CbButtonVariant`: `Primary`, `Secondary`, `Tertiary`, `Ghost`, `Danger`, `DangerTertiary`
- `CbNotificationKind`: `Info`, `Success`, `Warning`, `Error`
- `CbTagKind`: `Gray`, `Blue`, `Green`, `Red`, `Purple`, `Teal`
- `CbTileKind`: `Default`, `Clickable`, `Selectable`
- `CbModalSize`: `ExtraSmall`, `Small`, `Medium`, `Large`
- `CbProgressStatus`: `Incomplete`, `Current`, `Complete`, `Invalid`
- `CbIconName`: icon enum in `Enums.cs`

## Actions

### `CbButton`
- Params: `Variant`, `Size`, `Disabled`, `Type`, `Icon`, `OnClick`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbButtonSet`
- Params: `Label`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbIconButton`
- Params: `Label`, `Icon`, `ChildContent`, `Type`, `Size`, `Disabled`, `OnClick`, `Class`, `AdditionalAttributes`
- Required: `Label`
- Slots: `ChildContent`

### `CbMenuButton`
- Params: `Label`, `Variant`, `Disabled`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (typically `CbMenuItem` children)

### `CbMenuItem`
- Params: `Disabled`, `OnClick`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbOverflowMenu`
- Params: `Label`, `Icon`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (typically menu items)

## Content

### `CbCodeSnippet`
- Params: `Code`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbContainedList`
- Params: `Title`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (typically `CbContainedListItem`)

### `CbContainedListItem`
- Params: `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbLink`
- Params: `Href`, `Target`, `Rel`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbList`
- Params: `Ordered`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbTile`
- Params: `Interactive`, `Kind`, `Selected`, `SelectedChanged`, `OnClick`, `Disabled`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

## Data

### `CbDataTable<TItem>`
- Params: `Title`, `Items`, `Columns`, `Selectable`, `SelectedItemsChanged`, `Toolbar`, `Class`, `AdditionalAttributes`
- Required: none (but `Items` and `Columns` are required for meaningful output)
- Slots: `Toolbar`

### `CbPagination`
- Params: `Label`, `TotalItems`, `Page`, `PageChanged`, `PageSize`, `PageSizeChanged`, `PageSizeOptions`, `Class`, `AdditionalAttributes`
- Required: none (set `TotalItems` for usable pagination)
- Slots: none

### `CbStructuredList`
- Params: `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbStructuredListCell`
- Params: `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbStructuredListRow`
- Params: `Header`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbTreeView`
- Params: `Label`, `Nodes`, `Id`, `Class`, `AdditionalAttributes`
- Required: none (set `Nodes` for useful rendering)
- Slots: none

### `CbTreeViewNode`
- Params: `Node`
- Required: `Node`
- Slots: none
- Note: internal recursive node renderer; typically you use `CbTreeView`.

### Data Helper Types
- `CbDataTableColumn<TItem>` (`CarbonBlazor/Components/Data/CbDataTableColumn.cs`)
- `CbTreeNode` (`CarbonBlazor/Components/Data/CbTreeNode.cs`)

## Feedback

### `CbInlineLoading`
- Params: `Text`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: none

### `CbLoading`
- Params: `Label`, `Overlay`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: none

### `CbNotification`
- Params: `Kind`, `Title`, `Subtitle`, `Closable`, `Closeable`, `OnClose`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`
- Note: both `Closable` and `Closeable` are present for compatibility.

### `CbProgressBar`
- Params: `Label`, `Value`, `Min`, `Max`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: none

### `CbProgressIndicator`
- Params: `Label`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (typically `CbProgressStep`)

### `CbProgressStep`
- Params: `Label`, `Status`
- Required: none
- Slots: none

### `CbTag`
- Params: `Kind`, `Dismissible`, `DismissLabel`, `OnDismiss`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

## Forms

### `CbCheckbox`
- Params: `Value`, `ValueChanged`, `Disabled`, `Invalid`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (label text)

### `CbDropdown`
- Params: `Label`, `Value`, `ValueChanged`, `Items`, `HelperText`, `Disabled`, `Invalid`, `Class`, `ChildContent`
- Required: none
- Slots: `ChildContent` (optional extra options/content)

### `CbFileUploader`
- Params: `Label`, `HelperText`, `Accept`, `Multiple`, `Disabled`, `OnFilesSelected`
- Required: none
- Slots: none

### `CbMultiSelect`
- Params: `Label`, `SelectedValues`, `SelectedValuesChanged`, `Items`, `Size`, `HelperText`, `Disabled`, `Id`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (optional extra options)

### `CbNumberInput`
- Params: `Label`, `Value`, `ValueChanged`, `Placeholder`, `HelperText`, `InvalidText`, `Invalid`, `Disabled`, `ReadOnly`
- Required: none
- Slots: none

### `CbRadio`
- Params: `Value`, `Disabled`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`
- Note: designed for use inside `CbRadioGroup`.

### `CbRadioGroup`
- Params: `Legend`, `Name`, `Value`, `ValueChanged`, `HelperText`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (usually `CbRadio` elements)

### `CbSearch`
- Params: `Label`, `Value`, `ValueChanged`, `Placeholder`, `HelperText`, `Disabled`, `ReadOnly`
- Required: none
- Slots: none

### `CbSelect`
- Params: `Label`, `Value`, `ValueChanged`, `HelperText`, `Disabled`, `Invalid`, `Id`, `Class`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (option elements)

### `CbSlider`
- Params: `Label`, `Value`, `ValueChanged`, `Min`, `Max`, `Step`, `Disabled`, `Id`, `AdditionalAttributes`
- Required: none
- Slots: none

### `CbTextArea`
- Params: `Label`, `Value`, `ValueChanged`, `Rows`, `Placeholder`, `HelperText`, `InvalidText`, `Invalid`, `Disabled`, `ReadOnly`, `Id`, `Class`, `AdditionalAttributes`
- Required: `Label`
- Slots: none

### `CbTextInput`
- Params: `Label`, `Type`, `Value`, `ValueChanged`, `Placeholder`, `HelperText`, `InvalidText`, `Invalid`, `Disabled`, `ReadOnly`, `Id`, `Class`, `AdditionalAttributes`
- Required: `Label`
- Slots: none

### `CbToggle`
- Params: `Label`, `Value`, `ValueChanged`, `Disabled`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: none

## Foundations

### `CbIcon`
- Params: `Name`, `Size`, `Label`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: none

### `CbLayer`
- Params: `Level`, `Class`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbThemeProvider`
- Params: `Theme`, `Class`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`
- Note: this is the root wrapper for theme application.

## Overlays

### `CbModal`
- Params: `Open`, `OpenChanged`, `Title`, `Label`, `Size`, `ChildContent`, `Footer`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`, `Footer`

### `CbPopover`
- Params: `Trigger`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `Trigger`, `ChildContent`

### `CbToggletip`
- Params: `Label`, `ChildContent`, `Class`
- Required: none
- Slots: `ChildContent`

### `CbTooltip`
- Params: `Text`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

## Shell

### `CbBreadcrumb`
- Params: `Label`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent` (breadcrumb items)

### `CbBreadcrumbItem`
- Params: `Href`, `Current`, `ChildContent`
- Required: none
- Slots: `ChildContent`

### `CbContent`
- Params: `Id`, `WithSideNav`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbHeader`
- Params: `ProductName`, `Prefix`, `Href`, `MenuLabel`, `NavLabel`, `ShowMenuButton`, `SideNavOpen`, `SideNavOpenChanged`, `NavContent`, `Actions`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `NavContent`, `Actions`

### `CbHeaderNavLink`
- Params: `Href`, `Match`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbSideNav`
- Params: `Label`, `Open`, `OpenChanged`, `ShowOverlay`, `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbSideNavLink`
- Params: `Href`, `Icon`, `Match`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbSideNavSection`
- Params: `Title`, `ChildContent`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

## Structure

### `CbAccordion`
- Params: `ChildContent`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: `ChildContent`

### `CbAccordionItem`
- Params: `Title`, `Open`, `OpenChanged`, `Disabled`, `ChildContent`, `Class`
- Required: none
- Slots: `ChildContent`

### `CbTabs`
- Params: `Label`, `Items`, `SelectedIndex`, `SelectedIndexChanged`, `Class`, `AdditionalAttributes`
- Required: none
- Slots: none (tab content is supplied via `CbTabItem` collection)

### Tabs Helper Type
- `CbTabItem` is the item model used by `CbTabs` (defined in `CbTabs.razor`).

## AI Generation Checklist
Before finalizing generated code:
1. Use `CbThemeProvider` at page/layout root.
2. Prefer Carbon components over raw controls.
3. Include required parameters (`CbIconButton.Label`, `CbTextInput.Label`, `CbTextArea.Label`, `CbTreeViewNode.Node`).
4. Use enum values instead of custom strings where enums exist.
5. Keep slot content in the correct `RenderFragment` parameter.
