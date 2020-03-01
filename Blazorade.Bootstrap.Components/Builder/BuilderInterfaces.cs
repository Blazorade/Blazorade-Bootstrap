using Blazorade.Core.Components.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Builder
{

    /// <summary>
    /// The interface for a builder implementation that is use to build classes to support generic Bootstrap features that apply to all elements.
    /// </summary>
    public interface IComponentFeatureBuilder : IClassBuilder
    {


        /// <summary>
        /// Sets the background color of the element to the given colour.
        /// </summary>
        IComponentFeatureBuilder Background(NamedColor color);

        /// <summary>
        /// Sets the background of the element to transparent.
        /// </summary>
        IComponentFeatureBuilder BackgroundTransparent();



        /// <summary>
        /// Specifies a border with the given value.
        /// </summary>
        /// <param name="value">The border value. If not specified, adds a border on all sides.</param>
        IComponentFeatureBuilder Border(string value = null);

        /// <summary>
        /// Adds a border to the top.
        /// </summary>
        IComponentFeatureBuilder BorderTop();

        /// <summary>
        /// Adds a border to the right.
        /// </summary>
        IComponentFeatureBuilder BorderRight();

        /// <summary>
        /// Adds a border at the bottom.
        /// </summary>
        IComponentFeatureBuilder BorderBottom();

        /// <summary>
        /// Adds a border to the left.
        /// </summary>
        IComponentFeatureBuilder BorderLeft();

        /// <summary>
        /// Removes all borders.
        /// </summary>
        IComponentFeatureBuilder Border0();

        /// <summary>
        /// Removes the top border.
        /// </summary>
        IComponentFeatureBuilder Border0Top();

        /// <summary>
        /// Removes the right border.
        /// </summary>
        IComponentFeatureBuilder Border0Right();

        /// <summary>
        /// Removes the bottom border.
        /// </summary>
        IComponentFeatureBuilder Border0Bottom();

        /// <summary>
        /// Removes the left border.
        /// </summary>
        IComponentFeatureBuilder Border0Left();

        /// <summary>
        /// Specifies the colour of the border.
        /// </summary>
        IComponentFeatureBuilder Border(NamedColor color);



        /// <summary>
        /// Sets the display to the given value.
        /// </summary>
        IComponentBreakpointBuilder Display(string value);

        /// <summary>
        /// Display: none
        /// </summary>
        IComponentBreakpointBuilder DisplayNone();

        /// <summary>
        /// Display: inline
        /// </summary>
        IComponentBreakpointBuilder DisplayInline();

        /// <summary>
        /// Display: inline-block
        /// </summary>
        IComponentBreakpointBuilder DisplayInlineBlock();

        /// <summary>
        /// Display: block
        /// </summary>
        IComponentBreakpointBuilder DisplayBlock();

        /// <summary>
        /// Display: table
        /// </summary>
        IComponentBreakpointBuilder DisplayTable();

        /// <summary>
        /// Display: table-cell
        /// </summary>
        IComponentBreakpointBuilder DisplayTableCell();

        /// <summary>
        /// Display: table-row
        /// </summary>
        IComponentBreakpointBuilder DisplayTableRow();

        /// <summary>
        /// Display: flex
        /// </summary>
        IComponentBreakpointBuilder DisplayFlex();

        /// <summary>
        /// Display: inline-flex
        /// </summary>
        IComponentBreakpointBuilder DisplayInlineFlex();



        /// <summary>
        /// Sets the height of the component to auto.
        /// </summary>
        IComponentFeatureBuilder HeightAuto();

        /// <summary>
        /// Sets the height of the component to 25%.
        /// </summary>
        IComponentFeatureBuilder Height25();

        /// <summary>
        /// Sets the height of the component to 50%.
        /// </summary>
        IComponentFeatureBuilder Height50();

        /// <summary>
        /// Sets the height of the component to 75%.
        /// </summary>
        IComponentFeatureBuilder Height75();

        /// <summary>
        /// Sets the height of the component to 100%.
        /// </summary>
        IComponentFeatureBuilder Height100();



        /// <summary>
        /// Sets the margin on all sizes of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointBuilder Margin(int size);

        /// <summary>
        /// Sets the top margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointBuilder MarginTop(int size);

        /// <summary>
        /// Sets the right margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointBuilder MarginRight(int size);

        /// <summary>
        /// Sets the bottom margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointBuilder MarginBottom(int size);

        /// <summary>
        /// Sets the left margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointBuilder MarginLeft(int size);

        /// <summary>
        /// Sets the left and right margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointBuilder MarginX(int size);

        /// <summary>
        /// Sets the top and bottom margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointBuilder MarginY(int size);



        /// <summary>
        /// Sets the padding on all sides of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointBuilder Padding(int size);

        /// <summary>
        /// Sets the top padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointBuilder PaddingTop(int size);

        /// <summary>
        /// Sets the right padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointBuilder PaddingRight(int size);

        /// <summary>
        /// Sets the bottom padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointBuilder PaddingBottom(int size);

        /// <summary>
        /// Sets the left padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointBuilder PaddingLeft(int size);

        /// <summary>
        /// Sets the left and right padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointBuilder PaddingX(int size);

        /// <summary>
        /// Sets the top and bottom padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointBuilder PaddingY(int size);



        /// <summary>
        /// Sets the text colour to the given colour.
        /// </summary>
        IComponentFeatureBuilder Text(NamedColor color);

        /// <summary>
        /// Sets the text colour to the body text colour.
        /// </summary>
        IComponentFeatureBuilder TextBody();

        /// <summary>
        /// Sets the text colour to a muted colour.
        /// </summary>
        IComponentFeatureBuilder TextMuted();



        /// <summary>
        /// Sets the width of the component to auto.
        /// </summary>
        IComponentFeatureBuilder WidthAuto();

        /// <summary>
        /// Sets the width of the component to 25%.
        /// </summary>
        IComponentFeatureBuilder Width25();

        /// <summary>
        /// Sets the width of the component to 50%.
        /// </summary>
        IComponentFeatureBuilder Width50();

        /// <summary>
        /// Sets the width of the component to 75%.
        /// </summary>
        IComponentFeatureBuilder Width75();

        /// <summary>
        /// Sets the width of the component to 100%.
        /// </summary>
        IComponentFeatureBuilder Width100();

    }

    /// <summary>
    /// </summary>
    public interface IComponentBreakpointBuilder : IComponentFeatureBuilder, IResponsiveBreakpointBuilder<IComponentFeatureBuilder>
    {

    }

    /// <summary>
    /// </summary>
    public interface IGridColFeatureBuilder : IComponentFeatureBuilder, IClassBuilder
    {

        /// <summary>
        /// Vertically aligns the column at the beginning (top).
        /// </summary>
        IGridColBreakpointBuilder AlignStart();

        /// <summary>
        /// Vertically aligns the column at the center.
        /// </summary>
        IGridColBreakpointBuilder AlignCenter();

        /// <summary>
        /// Vertically aligns the column at the end (bottom).
        /// </summary>
        IGridColBreakpointBuilder AlignEnd();

        /// <summary>
        /// Creates an equal width, auto-layout column.
        /// </summary>
        IGridColBreakpointBuilder Col();

        /// <summary>
        /// Creates a column spanning the given amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to span.</param>
        IGridColBreakpointBuilder Col(int cols);

        /// <summary>
        /// Defines that the column is automatically sized based on its contents.
        /// </summary>
        IGridColBreakpointBuilder ColAuto();

        /// <summary>
        /// Moves a column to the right by the specified amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to move to the right.</param>
        IGridColBreakpointBuilder Offset(int cols);

        /// <summary>
        /// Visually orders the column using the given order.
        /// </summary>
        /// <param name="order">The numeric order to give the column.</param>
        IGridColBreakpointBuilder Order(int order);

        /// <summary>
        /// Visually orders the column as the first.
        /// </summary>
        IGridColBreakpointBuilder OrderFirst();

        /// <summary>
        /// Visually orders the column as the last column.
        /// </summary>
        IGridColBreakpointBuilder OrderLast();

    }

    /// <summary>
    /// </summary>
    public interface IGridColBreakpointBuilder : IGridColFeatureBuilder, IResponsiveBreakpointBuilder<IGridColFeatureBuilder>
    {
    }

    /// <summary>
    /// Defines the interface for a builder that supports responsive breakpoints.
    /// </summary>
    /// <typeparam name="TReturn">The type returned by the methods defined on the interface.</typeparam>
    public interface IResponsiveBreakpointBuilder<TReturn>
    {

        /// <summary>
        /// Configures an item to be applied on all responsive breakpoints.
        /// </summary>
        TReturn OnAll();

        /// <summary>
        /// Configures an item to be applied to the SM responsive breakpoint and above.
        /// </summary>
        TReturn OnSm();

        /// <summary>
        /// Configures an item to be applied to the MD responsive breakpoint and above.
        /// </summary>
        TReturn OnMd();

        /// <summary>
        /// Configures an item to be applied to the LG responsive breakpoint and above.
        /// </summary>
        TReturn OnLg();

        /// <summary>
        /// Configures an item to be applied to the XL responsive breakpoint and above.
        /// </summary>
        TReturn OnXl();

    }
}
