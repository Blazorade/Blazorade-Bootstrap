using Blazorade.Core.Components.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Builder
{
    /// <summary>
    /// A component builder that is desined for the <see cref="Row"/> component to support the Bootstrap grid.
    /// </summary>
    public class RowBuilder : BootstrapComponentBuilder, IRowFeatures, IRowBreakpointModifiers
    {
        /// <summary>
        /// Creates an instance of the builder.
        /// </summary>
        public RowBuilder() : base() { }

        /// <summary>
        /// Creates an instance of the builder from the given builder.
        /// </summary>
        /// <param name="builder">The builder to start the new instance from.</param>
        public RowBuilder(IComponentBuilder builder) : base(builder) { }



        /// <summary>
        /// Aligns items on the row at the top of the row.
        /// </summary>
        public IRowBreakpointModifiers AlignItemsStart()
        {
            this.AddPendingClass("align-items-{0}-start");
            return this;
        }

        /// <summary>
        /// Aligns items on the row in the middle of the row, horizontally.
        /// </summary>
        public IRowBreakpointModifiers AlignItemsCenter()
        {
            this.AddPendingClass("align-items-{0}-center");
            return this;
        }

        /// <summary>
        /// Aligns items on the row at the bottom of the row.
        /// </summary>
        public IRowBreakpointModifiers AlignItemsEnd()
        {
            this.AddPendingClass("align-items-{0}-end");
            return this;
        }

        /// <summary>
        /// Aligns row content to the left of the row.
        /// </summary>
        public IRowBreakpointModifiers JustifyContentStart()
        {
            this.AddPendingClass("justify-content-{0}-start");
            return this;
        }

        /// <summary>
        /// Centers row content.
        /// </summary>
        public IRowBreakpointModifiers JustifyContentCenter()
        {
            this.AddPendingClass("justify-content-{0}-center");
            return this;
        }

        /// <summary>
        /// Aligns content to the right of the row.
        /// </summary>
        public IRowBreakpointModifiers JustifyContentEnd()
        {
            this.AddPendingClass("justify-content-{0}-end");
            return this;
        }

        /// <summary>
        /// Justifies content on the row by adding space around all content as needed.
        /// </summary>
        public IRowBreakpointModifiers JustifyContentAround()
        {
            this.AddPendingClass("justify-content-{0}-around");
            return this;
        }

        /// <summary>
        /// Justifies content on the row by adding space between content, but not before and after, as needed.
        /// </summary>
        public IRowBreakpointModifiers JustifyContentBetween()
        {
            this.AddPendingClass("justify-content-{0}-between");
            return this;
        }



        /// <summary>
        /// Removes gutters between columns on the row.
        /// </summary>
        public IRowFeatures NoGutters()
        {
            this.AddPendingClass("no-gutters");
            return this;
        }



        /// <summary>
        /// Specifies the component as a row.
        /// </summary>
        public IRowFeatures Row()
        {
            this.AddPendingClass("row");
            return this;
        }

        /// <summary>
        /// Specifies the number of columsn to allow on each row at each breakpoing.
        /// </summary>
        /// <param name="cols">The number of columns on each row.</param>
        public IRowBreakpointModifiers RowCols(int cols)
        {
            this.AddPendingClass($"row-cols-{{0}}-{cols}");
            return this;
        }



        #region Breakpoint modifiers

        IRowFeatures IResponsiveBreakpointModifiers<IRowFeatures>.OnAll()
        {
            this.FlushPendingClasses();
            return this;
        }

        IRowFeatures IResponsiveBreakpointModifiers<IRowFeatures>.OnSm()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.SM);
            return this;
        }

        IRowFeatures IResponsiveBreakpointModifiers<IRowFeatures>.OnMd()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.MD);
            return this;
        }

        IRowFeatures IResponsiveBreakpointModifiers<IRowFeatures>.OnLg()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.LG);
            return this;
        }

        IRowFeatures IResponsiveBreakpointModifiers<IRowFeatures>.OnXl()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.XL);
            return this;
        }

        #endregion

    }


    /// <summary>
    /// Features for <see cref="Row"/>.
    /// </summary>
    public interface IRowFeatures : IComponentFeatures
    {

        /// <summary>
        /// Aligns items on the row at the top of the row.
        /// </summary>
        IRowBreakpointModifiers AlignItemsStart();

        /// <summary>
        /// Aligns items on the row in the middle of the row, horizontally.
        /// </summary>
        IRowBreakpointModifiers AlignItemsCenter();

        /// <summary>
        /// Aligns items on the row at the bottom of the row.
        /// </summary>
        IRowBreakpointModifiers AlignItemsEnd();

        /// <summary>
        /// Aligns row content to the left of the row.
        /// </summary>
        IRowBreakpointModifiers JustifyContentStart();

        /// <summary>
        /// Centers row content.
        /// </summary>
        IRowBreakpointModifiers JustifyContentCenter();

        /// <summary>
        /// Aligns content to the right of the row.
        /// </summary>
        IRowBreakpointModifiers JustifyContentEnd();

        /// <summary>
        /// Justifies content on the row by adding space around all content as needed.
        /// </summary>
        IRowBreakpointModifiers JustifyContentAround();

        /// <summary>
        /// Justifies content on the row by adding space between content, but not before and after, as needed.
        /// </summary>
        IRowBreakpointModifiers JustifyContentBetween();

        /// <summary>
        /// Removes gutters between columns on the row.
        /// </summary>
        IRowFeatures NoGutters();

        /// <summary>
        /// Specifies the component as a row.
        /// </summary>
        IRowFeatures Row();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cols">The number of columns on each row.</param>
        /// <returns></returns>
        IRowBreakpointModifiers RowCols(int cols);

    }

    /// <summary>
    /// Breakpoint modifiers for <see cref="Row"/>.
    /// </summary>
    public interface IRowBreakpointModifiers : IRowFeatures, IResponsiveBreakpointModifiers<IRowFeatures> { }

}
