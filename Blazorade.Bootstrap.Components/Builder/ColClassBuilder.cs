using Blazorade.Core.Components.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Builder
{
    /// <summary>
    /// A class builder that is used to build classes for the <see cref="Col"/> component to support the Bootstrap grid system.
    /// </summary>
    public class ColClassBuilder : ComponentClassBuilder, IGridColFeatureBuilder, IGridColBreakpointBuilder, IResponsiveBreakpointBuilder<IGridColFeatureBuilder>, IClassBuilder
    {

        /// <summary>
        /// Vertically aligns the column at the beginning (top).
        /// </summary>
        public IGridColBreakpointBuilder AlignStart()
        {
            this.AddPendingFeature("align-self-{0}-start");
            return this;
        }

        /// <summary>
        /// Vertically aligns the column at the center.
        /// </summary>
        public IGridColBreakpointBuilder AlignCenter()
        {
            this.AddPendingFeature("align-self-{0}-center");
            return this;
        }

        /// <summary>
        /// Vertically aligns the column at the end (bottom).
        /// </summary>
        public IGridColBreakpointBuilder AlignEnd()
        {
            this.AddPendingFeature("align-self-{0}-end");
            return this;
        }

        /// <summary>
        /// Creates an equal width, auto-layout column.
        /// </summary>
        public IGridColBreakpointBuilder Col()
        {
            this.AddPendingFeature("col-{0}");
            return this;
        }

        /// <summary>
        /// Creates a column spanning the given amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to span.</param>
        public IGridColBreakpointBuilder Col(int cols)
        {
            this.AddPendingFeature($"col-{{0}}-{cols}");
            return this;
        }

        /// <summary>
        /// Defines that the column is automatically sized based on its contents.
        /// </summary>
        public IGridColBreakpointBuilder ColAuto()
        {
            this.AddPendingFeature("col-{0}-auto");
            return this;
        }

        /// <summary>
        /// Moves a column to the right by the specified amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to move to the right.</param>
        public IGridColBreakpointBuilder Offset(int cols)
        {
            this.AddPendingFeature($"offset-{{0}}-{cols}");
            return this;
        }

        /// <summary>
        /// Visually orders the column using the given order.
        /// </summary>
        /// <param name="order">The numeric order to give the column.</param>
        public IGridColBreakpointBuilder Order(int order)
        {
            this.AddPendingFeature($"order-{{0}}-{order}");
            return this;
        }

        /// <summary>
        /// Visually orders the column as the first.
        /// </summary>
        public IGridColBreakpointBuilder OrderFirst()
        {
            this.AddPendingFeature($"order-{{0}}-first");
            return this;
        }

        /// <summary>
        /// Visually orders the column as the last column.
        /// </summary>
        public IGridColBreakpointBuilder OrderLast()
        {
            this.AddPendingFeature($"order-{{0}}-last");
            return this;
        }

        /// <summary>
        /// Configures the preceeding column features to be applied on all responsive breakpoints.
        /// </summary>
        IGridColFeatureBuilder IResponsiveBreakpointBuilder<IGridColFeatureBuilder>.OnAll()
        {
            this.FlushPendingFeatures();
            return this;
        }

        /// <summary>
        /// Configures the preceeding column features to be applied on the LG breakpoint and up.
        /// </summary>
        IGridColFeatureBuilder IResponsiveBreakpointBuilder<IGridColFeatureBuilder>.OnLg()
        {
            this.FlushPendingFeatures(ResponsiveBreakpoint.LG);
            return this;
        }

        /// <summary>
        /// Configures the preceeding column features to be applied on the MF breakpoint and up.
        /// </summary>
        IGridColFeatureBuilder IResponsiveBreakpointBuilder<IGridColFeatureBuilder>.OnMd()
        {
            this.FlushPendingFeatures(ResponsiveBreakpoint.MD);
            return this;
        }

        /// <summary>
        /// Configures the preceeding column features to be applied on the SM breakpoint and up.
        /// </summary>
        IGridColFeatureBuilder IResponsiveBreakpointBuilder<IGridColFeatureBuilder>.OnSm()
        {
            this.FlushPendingFeatures(ResponsiveBreakpoint.SM);
            return this;
        }

        /// <summary>
        /// Configures the preceeding column features to be applied on the XL breakpoint only.
        /// </summary>
        IGridColFeatureBuilder IResponsiveBreakpointBuilder<IGridColFeatureBuilder>.OnXl()
        {
            this.FlushPendingFeatures(ResponsiveBreakpoint.XL);
            return this;
        }

    }

}
