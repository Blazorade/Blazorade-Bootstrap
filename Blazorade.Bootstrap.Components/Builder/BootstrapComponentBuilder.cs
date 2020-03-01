using Blazorade.Core.Components.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Builder
{

    /// <summary>
    /// Defines features that can be added to all or most elements in Bootstrap.
    /// </summary>
    public interface IComponentFeatures : IComponentBuilder
    {

        /// <summary>
        /// Returns the builder instance.
        /// </summary>
        IComponentBuilder Builder();

        #region Background

        /// <summary>
        /// Sets the background color of the element to the given colour.
        /// </summary>
        IComponentFeatures Background(NamedColor color);

        /// <summary>
        /// Adds the given CSS color as a background style for the component.
        /// </summary>
        /// <param name="color">Any value that can be set on the <c>background-color</c> CSS style.</param>
        /// <returns></returns>
        IComponentFeatures Background(string color);

        /// <summary>
        /// Sets the background of the element to transparent.
        /// </summary>
        IComponentFeatures BackgroundTransparent();

        #endregion

        #region Border

        /// <summary>
        /// Sets a default border on all sides of the component.
        /// </summary>
        IComponentFeatures Border();

        /// <summary>
        /// Adds a border to the top.
        /// </summary>
        IComponentFeatures BorderTop();

        /// <summary>
        /// Adds a border to the right.
        /// </summary>
        IComponentFeatures BorderRight();

        /// <summary>
        /// Adds a border at the bottom.
        /// </summary>
        IComponentFeatures BorderBottom();

        /// <summary>
        /// Adds a border to the left.
        /// </summary>
        IComponentFeatures BorderLeft();

        /// <summary>
        /// Removes all borders.
        /// </summary>
        IComponentFeatures Border0();

        /// <summary>
        /// Removes the top border.
        /// </summary>
        IComponentFeatures Border0Top();

        /// <summary>
        /// Removes the right border.
        /// </summary>
        IComponentFeatures Border0Right();

        /// <summary>
        /// Removes the bottom border.
        /// </summary>
        IComponentFeatures Border0Bottom();

        /// <summary>
        /// Removes the left border.
        /// </summary>
        IComponentFeatures Border0Left();

        /// <summary>
        /// Specifies the colour of the border.
        /// </summary>
        IComponentFeatures Border(NamedColor color);

        #endregion

        #region Display

        /// <summary>
        /// Display: none
        /// </summary>
        IComponentBreakpointModifiers DisplayNone();

        /// <summary>
        /// Display: inline
        /// </summary>
        IComponentBreakpointModifiers DisplayInline();

        /// <summary>
        /// Display: inline-block
        /// </summary>
        IComponentBreakpointModifiers DisplayInlineBlock();

        /// <summary>
        /// Display: block
        /// </summary>
        IComponentBreakpointModifiers DisplayBlock();

        /// <summary>
        /// Display: table
        /// </summary>
        IComponentBreakpointModifiers DisplayTable();

        /// <summary>
        /// Display: table-cell
        /// </summary>
        IComponentBreakpointModifiers DisplayTableCell();

        /// <summary>
        /// Display: table-row
        /// </summary>
        IComponentBreakpointModifiers DisplayTableRow();

        /// <summary>
        /// Display: flex
        /// </summary>
        IComponentBreakpointModifiers DisplayFlex();

        /// <summary>
        /// Display: inline-flex
        /// </summary>
        IComponentBreakpointModifiers DisplayInlineFlex();

        #endregion

        #region Height

        /// <summary>
        /// Sets the height of the component to auto.
        /// </summary>
        IComponentFeatures HeightAuto();

        /// <summary>
        /// Sets the height of the component to 25%.
        /// </summary>
        IComponentFeatures Height25();

        /// <summary>
        /// Sets the height of the component to 50%.
        /// </summary>
        IComponentFeatures Height50();

        /// <summary>
        /// Sets the height of the component to 75%.
        /// </summary>
        IComponentFeatures Height75();

        /// <summary>
        /// Sets the height of the component to 100%.
        /// </summary>
        IComponentFeatures Height100();

        #endregion

        #region Margin

        /// <summary>
        /// Sets the margin on all sizes of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointModifiers Margin(int size);

        /// <summary>
        /// Sets the top margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointModifiers MarginTop(int size);

        /// <summary>
        /// Sets the right margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointModifiers MarginRight(int size);

        /// <summary>
        /// Sets the bottom margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointModifiers MarginBottom(int size);

        /// <summary>
        /// Sets the left margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointModifiers MarginLeft(int size);

        /// <summary>
        /// Sets the left and right margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointModifiers MarginX(int size);

        /// <summary>
        /// Sets the top and bottom margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        IComponentBreakpointModifiers MarginY(int size);

        #endregion

        #region Padding

        /// <summary>
        /// Sets the padding on all sides of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointModifiers Padding(int size);

        /// <summary>
        /// Sets the top padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointModifiers PaddingTop(int size);

        /// <summary>
        /// Sets the right padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointModifiers PaddingRight(int size);

        /// <summary>
        /// Sets the bottom padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointModifiers PaddingBottom(int size);

        /// <summary>
        /// Sets the left padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointModifiers PaddingLeft(int size);

        /// <summary>
        /// Sets the left and right padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointModifiers PaddingX(int size);

        /// <summary>
        /// Sets the top and bottom padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        IComponentBreakpointModifiers PaddingY(int size);

        #endregion

        #region Text

        /// <summary>
        /// Sets the text colour to the given colour.
        /// </summary>
        IComponentFeatures Text(NamedColor color);

        /// <summary>
        /// Sets the text colour to the body text colour.
        /// </summary>
        IComponentFeatures TextBody();

        /// <summary>
        /// Sets the text colour to a muted colour.
        /// </summary>
        IComponentFeatures TextMuted();

        #endregion

        #region Width

        /// <summary>
        /// Sets the width of the component to auto.
        /// </summary>
        IComponentFeatures WidthAuto();

        /// <summary>
        /// Sets the width of the component to 25%.
        /// </summary>
        IComponentFeatures Width25();

        /// <summary>
        /// Sets the width of the component to 50%.
        /// </summary>
        IComponentFeatures Width50();

        /// <summary>
        /// Sets the width of the component to 75%.
        /// </summary>
        IComponentFeatures Width75();

        /// <summary>
        /// Sets the width of the component to 100%.
        /// </summary>
        IComponentFeatures Width100();

        #endregion

    }

    /// <summary>
    /// Breakpoint modifiers for components.
    /// </summary>
    public interface IComponentBreakpointModifiers : IComponentFeatures, IResponsiveBreakpointModifiers<IComponentFeatures>
    {
    }

    /// <summary>
    /// A builder class that can be used to create features supported by most or all HTML elements in Bootstrap.
    /// </summary>
    public class BootstrapComponentBuilder : ComponentBuilder, IComponentFeatures, IComponentBreakpointModifiers
    {

        /// <summary>
        /// Creates an instance of the builder.
        /// </summary>
        public BootstrapComponentBuilder() { }

        /// <summary>
        /// Creates an instance of the builder from the given builder.
        /// </summary>
        /// <param name="builder">The builder to start the new instance from.</param>
        public BootstrapComponentBuilder(IComponentBuilder builder) : base(builder) { }



        /// <summary>
        /// Returns the current builder instance.
        /// </summary>
        public IComponentBuilder Builder()
        {
            return this;
        }


        #region Background

        /// <summary>
        /// Sets the background color of the element to the given colour.
        /// </summary>
        public IComponentFeatures Background(NamedColor color)
        {
            this.AddPendingClass($"bg-{color.ToString().Hyphenate().ToLower()}");
            return this;
        }

        /// <summary>
        /// Adds the given CSS color as a background style for the component.
        /// </summary>
        /// <param name="color">Any value that can be set on the <c>background-color</c> CSS style.</param>
        /// <returns></returns>
        public IComponentFeatures Background(string color)
        {
            this.AddAttribute("background-color", color);
            return this;
        }

        /// <summary>
        /// Sets the background of the element to transparent.
        /// </summary>
        public IComponentFeatures BackgroundTransparent()
        {
            this.AddPendingClass("bg-transparent");
            return this;
        }

        #endregion

        #region Border

        /// <summary>
        /// Sets a default border on all sides of the component.
        /// </summary>
        public IComponentFeatures Border()
        {
            this.AddPendingClass("border");
            return this;
        }

        /// <summary>
        /// Adds a border to the top.
        /// </summary>
        public IComponentFeatures BorderTop()
        {
            this.AddPendingClass("border-top");
            return this;
        }

        /// <summary>
        /// Adds a border to the right.
        /// </summary>
        public IComponentFeatures BorderRight()
        {
            this.AddPendingClass("border-right");
            return this;
        }

        /// <summary>
        /// Adds a border at the bottom.
        /// </summary>
        public IComponentFeatures BorderBottom()
        {
            this.AddPendingClass("border-bottom");
            return this;
        }

        /// <summary>
        /// Adds a border to the left.
        /// </summary>
        public IComponentFeatures BorderLeft()
        {
            this.AddPendingClass("border-left");
            return this;
        }

        /// <summary>
        /// Removes all borders.
        /// </summary>
        public IComponentFeatures Border0()
        {
            this.AddPendingClass("border-0");
            return this;
        }

        /// <summary>
        /// Removes the top border.
        /// </summary>
        public IComponentFeatures Border0Top()
        {
            this.AddPendingClass("border-top-0");
            return this;
        }

        /// <summary>
        /// Removes the right border.
        /// </summary>
        public IComponentFeatures Border0Right()
        {
            this.AddPendingClass("border-right-0");
            return this;
        }

        /// <summary>
        /// Removes the bottom border.
        /// </summary>
        public IComponentFeatures Border0Bottom()
        {
            this.AddPendingClass("border-bottom-0");
            return this;
        }

        /// <summary>
        /// Removes the left border.
        /// </summary>
        public IComponentFeatures Border0Left()
        {
            this.AddPendingClass("border-left-0");
            return this;
        }

        /// <summary>
        /// Specifies the colour of the border.
        /// </summary>
        public IComponentFeatures Border(NamedColor color)
        {
            this.AddPendingClass($"border-{color.ToString().Hyphenate().ToLower()}");
            return this;
        }

        #endregion

        #region Display

        /// <summary>
        /// Display: none
        /// </summary>
        public IComponentBreakpointModifiers DisplayNone()
        {
            this.AddPendingClass("d-{0}-none");
            return this;
        }

        /// <summary>
        /// Display: inline
        /// </summary>
        public IComponentBreakpointModifiers DisplayInline()
        {
            this.AddPendingClass("d-{0}-inline");
            return this;
        }

        /// <summary>
        /// Display: inline-block
        /// </summary>
        public IComponentBreakpointModifiers DisplayInlineBlock()
        {
            this.AddPendingClass("d-{0}-inline-block");
            return this;
        }

        /// <summary>
        /// Display: block
        /// </summary>
        public IComponentBreakpointModifiers DisplayBlock()
        {
            this.AddPendingClass("d-{0}-block");
            return this;
        }

        /// <summary>
        /// Display: table
        /// </summary>
        public IComponentBreakpointModifiers DisplayTable()
        {
            this.AddPendingClass("d-{0}-table");
            return this;
        }

        /// <summary>
        /// Display: table-cell
        /// </summary>
        public IComponentBreakpointModifiers DisplayTableCell()
        {
            this.AddPendingClass("d-{0}-table-cell");
            return this;
        }

        /// <summary>
        /// Display: table-row
        /// </summary>
        public IComponentBreakpointModifiers DisplayTableRow()
        {
            this.AddPendingClass("d-{0}-table-row");
            return this;
        }

        /// <summary>
        /// Display: flex
        /// </summary>
        public IComponentBreakpointModifiers DisplayFlex()
        {
            this.AddPendingClass("d-{0}-flex");
            return this;
        }

        /// <summary>
        /// Display: inline-flex
        /// </summary>
        public IComponentBreakpointModifiers DisplayInlineFlex()
        {
            this.AddPendingClass("d-{0}-inline-flex");
            return this;
        }

        #endregion

        #region Height

        /// <summary>
        /// Sets the height of the component to auto.
        /// </summary>
        public IComponentFeatures HeightAuto()
        {
            this.AddPendingClass("h-auto");
            return this;
        }

        /// <summary>
        /// Sets the height of the component to 25%.
        /// </summary>
        public IComponentFeatures Height25()
        {
            this.AddPendingClass("h-25");
            return this;
        }

        /// <summary>
        /// Sets the height of the component to 50%.
        /// </summary>
        public IComponentFeatures Height50()
        {
            this.AddPendingClass("h-50");
            return this;
        }

        /// <summary>
        /// Sets the height of the component to 75%.
        /// </summary>
        public IComponentFeatures Height75()
        {
            this.AddPendingClass("h-75");
            return this;
        }

        /// <summary>
        /// Sets the height of the component to 100%.
        /// </summary>
        public IComponentFeatures Height100()
        {
            this.AddPendingClass("h-100");
            return this;
        }

        #endregion

        #region Margin

        /// <summary>
        /// Sets the margin on all sizes of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        public IComponentBreakpointModifiers Margin(int size)
        {
            this.AddPendingClass($"m-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the top margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        public IComponentBreakpointModifiers MarginTop(int size)
        {
            this.AddPendingClass($"mt-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the right margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        public IComponentBreakpointModifiers MarginRight(int size)
        {
            this.AddPendingClass($"mr-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the bottom margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        public IComponentBreakpointModifiers MarginBottom(int size)
        {
            this.AddPendingClass($"mb-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the left margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        public IComponentBreakpointModifiers MarginLeft(int size)
        {
            this.AddPendingClass($"ml-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the left and right margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        public IComponentBreakpointModifiers MarginX(int size)
        {
            this.AddPendingClass($"mx-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the top and bottom margin of the component.
        /// </summary>
        /// <param name="size">The size of the margin.</param>
        public IComponentBreakpointModifiers MarginY(int size)
        {
            this.AddPendingClass($"my-{{0}}-{size}");
            return this;
        }

        #endregion

        #region Padding

        /// <summary>
        /// Sets the padding on all sides of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        public IComponentBreakpointModifiers Padding(int size)
        {
            this.AddPendingClass($"p-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the top padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        public IComponentBreakpointModifiers PaddingTop(int size)
        {
            this.AddPendingClass($"pp-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the right padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        public IComponentBreakpointModifiers PaddingRight(int size)
        {
            this.AddPendingClass($"pr-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the bottom padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        public IComponentBreakpointModifiers PaddingBottom(int size)
        {
            this.AddPendingClass($"pb-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the left padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        public IComponentBreakpointModifiers PaddingLeft(int size)
        {
            this.AddPendingClass($"pl-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the left and right padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        public IComponentBreakpointModifiers PaddingX(int size)
        {
            this.AddPendingClass($"px-{{0}}-{size}");
            return this;
        }

        /// <summary>
        /// Sets the top and bottom padding of the component.
        /// </summary>
        /// <param name="size">The size of padding.</param>
        public IComponentBreakpointModifiers PaddingY(int size)
        {
            this.AddPendingClass($"py-{{0}}-{size}");
            return this;
        }

        #endregion

        #region Text

        /// <summary>
        /// Sets the text colour to the given colour.
        /// </summary>
        public IComponentFeatures Text(NamedColor color)
        {
            this.AddPendingClass($"text-{color.ToString().Hyphenate().ToLower()}");
            return this;
        }

        /// <summary>
        /// Sets the text colour to the body text colour.
        /// </summary>
        public IComponentFeatures TextBody()
        {
            this.AddPendingClass("text-body");
            return this;
        }

        /// <summary>
        /// Sets the text colour to a muted colour.
        /// </summary>
        public IComponentFeatures TextMuted()
        {
            this.AddPendingClass("text-muted");
            return this;
        }

        #endregion

        #region Width

        /// <summary>
        /// Sets the width of the component to auto.
        /// </summary>
        public IComponentFeatures WidthAuto()
        {
            this.AddPendingClass("w-auto");
            return this;
        }

        /// <summary>
        /// Sets the width of the component to 25%.
        /// </summary>
        public IComponentFeatures Width25()
        {
            this.AddPendingClass("w-25");
            return this;
        }

        /// <summary>
        /// Sets the width of the component to 50%.
        /// </summary>
        public IComponentFeatures Width50()
        {
            this.AddPendingClass("w-50");
            return this;
        }

        /// <summary>
        /// Sets the width of the component to 75%.
        /// </summary>
        public IComponentFeatures Width75()
        {
            this.AddPendingClass("w-75");
            return this;
        }

        /// <summary>
        /// Sets the width of the component to 100%.
        /// </summary>
        public IComponentFeatures Width100()
        {
            this.AddPendingClass("w-100");
            return this;
        }

        #endregion

        #region Breakpoint modifiers

        IComponentFeatures IResponsiveBreakpointModifiers<IComponentFeatures>.OnAll()
        {
            this.FlushPendingClasses();
            return this;
        }

        IComponentFeatures IResponsiveBreakpointModifiers<IComponentFeatures>.OnSm()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.SM);
            return this;
        }

        IComponentFeatures IResponsiveBreakpointModifiers<IComponentFeatures>.OnMd()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.MD);
            return this;
        }

        IComponentFeatures IResponsiveBreakpointModifiers<IComponentFeatures>.OnLg()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.LG);
            return this;
        }

        IComponentFeatures IResponsiveBreakpointModifiers<IComponentFeatures>.OnXl()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.XL);
            return this;
        }

        #endregion




        /// <summary>
        /// Builds all classes contained in the builder, and returns them.
        /// </summary>
        /// <returns></returns>
        public override IReadOnlyCollection<string> BuildClasses()
        {
            this.FlushPendingClasses();
            return base.BuildClasses();
        }



        private List<string> PendingClasses = new List<string>();

        /// <summary>
        /// Adds a class to the collection of pending classes.
        /// </summary>
        /// <param name="cls">The class to add to the pending list.</param>
        /// <remarks>
        /// A pending class is stored in a collection waiting for a responsive breakpoint modified is called,
        /// or the classes are built. A class needs to specify a placeholder for the responsive breakpoint
        /// identifier in order for it to successfully be processed for a particular breakpoint. The placeholder
        /// is always <c>{0}</c>, for instance <c>col-{0}-6</c>.
        /// </remarks>
        protected virtual void AddPendingClass(string cls)
        {
            if (!string.IsNullOrEmpty(cls) && !this.PendingClasses.Contains(cls))
            {
                this.PendingClasses.Add(cls);
            }
        }

        /// <summary>
        /// Processes all pending classes using the given breakpoint and stores them in the underlying builder.
        /// </summary>
        /// <param name="breakpoint">The responsive breakpoint to use when processing pending classes.</param>
        protected virtual void FlushPendingClasses(ResponsiveBreakpoint? breakpoint = null)
        {
            foreach(var c in this.PendingClasses)
            {
                var cls = string.Format(c, breakpoint?.ToString()?.ToLower()).Replace("--", "-");
                if (cls.EndsWith("-")) cls = cls[0..^1];

                this.AddClasses(cls);
            }

            this.PendingClasses.Clear();
        }

    }

}
