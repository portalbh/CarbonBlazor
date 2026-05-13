using Bunit;
using CarbonBlazor.Components.Actions;
using CarbonBlazor.Components.Data;
using CarbonBlazor.Components.Feedback;
using CarbonBlazor.Components.Forms;
using CarbonBlazor.Components.Foundations;
using CarbonBlazor.Components.Overlays;
using CarbonBlazor.Components.Structure;

namespace CarbonBlazor.Tests;

public sealed class ComponentTests : BunitContext
{
    [Fact]
    public void ThemeProvider_RendersThemeTokenAttribute()
    {
        var cut = Render<CbThemeProvider>(parameters => parameters
            .Add(p => p.Theme, CbTheme.G100)
            .AddChildContent("content"));

        Assert.Equal("g100", cut.Find(".cb-theme").GetAttribute("data-theme"));
    }

    [Fact]
    public void Button_RendersVariantAndDisabledState()
    {
        var cut = Render<CbButton>(parameters => parameters
            .Add(p => p.Variant, CbButtonVariant.Secondary)
            .Add(p => p.Disabled, true)
            .AddChildContent("Save"));

        var button = cut.Find("button");
        Assert.Contains("cb-btn--secondary", button.GetAttribute("class"));
        Assert.True(button.HasAttribute("disabled"));
    }

    [Fact]
    public void TextInput_RaisesBindableValueChange()
    {
        string? value = null;
        var cut = Render<CbTextInput>(parameters => parameters
            .Add(p => p.Label, "Name")
            .Add(p => p.ValueChanged, changed => value = changed));

        cut.Find("input").Input("Ada");

        Assert.Equal("Ada", value);
        Assert.Equal("Name", cut.Find("label").TextContent);
    }

    [Fact]
    public void AccordionItem_TogglesExpandedState()
    {
        var cut = Render<CbAccordionItem>(parameters => parameters
            .Add(p => p.Title, "Details")
            .AddChildContent("Hidden content"));

        var button = cut.Find("button");
        Assert.Equal("false", button.GetAttribute("aria-expanded"));

        button.Click();

        Assert.Equal("true", cut.Find("button").GetAttribute("aria-expanded"));
        Assert.Contains("Hidden content", cut.Markup);
    }

    [Fact]
    public void Tabs_ClickingTab_SelectsPanelAndAriaState()
    {
        var tabs = new[]
        {
            new CbTabItem { Label = "Usage", Content = builder => builder.AddContent(0, "Usage panel") },
            new CbTabItem { Label = "Code", Content = builder => builder.AddContent(0, "Code panel") }
        };

        var cut = Render<CbTabs>(parameters => parameters.Add(p => p.Items, tabs));
        cut.FindAll("[role=tab]")[1].Click();

        Assert.Equal("true", cut.FindAll("[role=tab]")[1].GetAttribute("aria-selected"));
        Assert.Contains("Code panel", cut.Markup);
    }

    [Fact]
    public void Notification_UsesAlertRoleForErrors()
    {
        var cut = Render<CbNotification>(parameters => parameters
            .Add(p => p.Kind, CbNotificationKind.Error)
            .Add(p => p.Title, "Failed"));

        Assert.Equal("alert", cut.Find(".cb-notification").GetAttribute("role"));
        Assert.Equal("assertive", cut.Find(".cb-notification").GetAttribute("aria-live"));
    }

    [Fact]
    public void Modal_RendersDialogSemanticsWhenOpen()
    {
        JSInterop.Mode = JSRuntimeMode.Loose;
        var cut = Render<CbModal>(parameters => parameters
            .Add(p => p.Open, true)
            .Add(p => p.Title, "Confirm")
            .AddChildContent("Confirm body"));

        var dialog = cut.Find("[role=dialog]");
        Assert.Equal("true", dialog.GetAttribute("aria-modal"));
        Assert.Contains("Confirm body", cut.Markup);
    }

    [Fact]
    public void DataTable_RendersRowsAndSortableHeader()
    {
        var people = new[]
        {
            new Person("Grace", "Compiler"),
            new Person("Ada", "Analyst")
        };
        var columns = new[]
        {
            new CbDataTableColumn<Person> { Header = "Name", Text = item => item.Name, SortKey = item => item.Name },
            new CbDataTableColumn<Person> { Header = "Role", Text = item => item.Role }
        };

        var cut = Render<CbDataTable<Person>>(parameters => parameters
            .Add(p => p.Items, people)
            .Add(p => p.Columns, columns)
            .Add(p => p.Title, "People"));

        cut.Find(".cb-data-table__sort").Click();

        Assert.Contains("People", cut.Markup);
        Assert.Contains("Ada", cut.Find("tbody tr:first-child").TextContent);
    }

    [Fact]
    public void Pagination_NextButtonRaisesPageChanged()
    {
        var page = 1;
        var cut = Render<CbPagination>(parameters => parameters
            .Add(p => p.TotalItems, 30)
            .Add(p => p.Page, page)
            .Add(p => p.PageChanged, value => page = value));

        cut.Find("button[aria-label='Next page']").Click();

        Assert.Equal(2, page);
    }

    private sealed record Person(string Name, string Role);
}
