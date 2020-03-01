using Blazorade.Core.Components.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Builder
{

    /// <summary>
    /// Defines features supported by columns in a Bootstrap grid.
    /// </summary>
    public interface IColumnFeatures : IComponentFeatures
    {

        /// <summary>
        /// Vertically aligns the column at the beginning (top).
        /// </summary>
        IColumnBreakpointModifiers AlignStart();

        /// <summary>
        /// Vertically aligns the column at the center.
        /// </summary>
        IColumnBreakpointModifiers AlignCenter();

        /// <summary>
        /// Vertically aligns the column at the end (bottom).
        /// </summary>
        IColumnBreakpointModifiers AlignEnd();

        /// <summary>
        /// Creates an equal width, auto-layout column.
        /// </summary>
        IColumnBreakpointModifiers Col();

        /// <summary>
        /// Creates a column spanning the given amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to span.</param>
        IColumnBreakpointModifiers Col(int cols);

        /// <summary>
        /// Defines that the column is automatically sized based on its contents.
        /// </summary>
        IColumnBreakpointModifiers ColAuto();

        /// <summary>
        /// Moves a column to the right by the specified amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to move to the right.</param>
        IColumnBreakpointModifiers Offset(int cols);

        /// <summary>
        /// Visually orders the column using the given order.
        /// </summary>
        /// <param name="order">The numeric order to give the column.</param>
        IColumnBreakpointModifiers Order(int order);

        /// <summary>
        /// Visually orders the column as the first.
        /// </summary>
        IColumnBreakpointModifiers OrderFirst();

        /// <summary>
        /// Visually orders the column as the last column.
        /// </summary>
        IColumnBreakpointModifiers OrderLast();

    }

    public interface IColumnBreakpointModifiers : IColumnFeatures, IResponsiveBreakpointModifiers<IColumnFeatures>
    {

    }

    /// <summary>
    /// A builder implementation that is used to build features for the <see cref="Column"/> component.
    /// </summary>
    public class ColumnBuilder : BootstrapComponentBuilder, IColumnFeatures, IColumnBreakpointModifiers
    {
        /// <summary>
        /// Creates an instance of the builder.
        /// </summary>
        public ColumnBuilder(): base() { }

        /// <summary>
        /// Creates an instance of the builder from the given builder.
        /// </summary>
        /// <param name="builder">The builder to start the new instance from.</param>
        public ColumnBuilder(IComponentBuilder builder) : base(builder) { }



        /// <summary>
        /// Vertically aligns the column at the beginning (top).
        /// </summary>
        public IColumnBreakpointModifiers AlignStart()
        {
            this.AddPendingClass("align-self-{0}-start");
            return this;
        }

        /// <summary>
        /// Vertically aligns the column at the center.
        /// </summary>
        public IColumnBreakpointModifiers AlignCenter()
        {
            this.AddPendingClass("align-self-{0}-center");
            return this;
        }

        /// <summary>
        /// Vertically aligns the column at the end (bottom).
        /// </summary>
        public IColumnBreakpointModifiers AlignEnd()
        {
            this.AddPendingClass("align-self-{0}-end");
            return this;
        }

        /// <summary>
        /// Creates an equal width, auto-layout column.
        /// </summary>
        public IColumnBreakpointModifiers Col()
        {
            this.AddPendingClass("col-{0}");
            return this;
        }

        /// <summary>
        /// Creates a column spanning the given amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to span.</param>
        public IColumnBreakpointModifiers Col(int cols)
        {
            this.AddPendingClass($"col-{{0}}-{cols}");
            return this;
        }

        /// <summary>
        /// Defines that the column is automatically sized based on its contents.
        /// </summary>
        public IColumnBreakpointModifiers ColAuto()
        {
            this.AddPendingClass("col-{0}-auto");
            return this;
        }

        /// <summary>
        /// Moves a column to the right by the specified amount of columns.
        /// </summary>
        /// <param name="cols">The number of columns to move to the right.</param>
        public IColumnBreakpointModifiers Offset(int cols)
        {
            this.AddPendingClass($"offset-{{0}}-{cols}");
            return this;
        }

        #region Order

        /// <summary>
        /// Visually orders the column using the given order.
        /// </summary>
        /// <param name="order">The numeric order to give the column.</param>
        public IColumnBreakpointModifiers Order(int order)
        {
            this.AddPendingClass($"order-{{0}}-{order}");
            return this;
        }

        /// <summary>
        /// Visually orders the column as the first.
        /// </summary>
        public IColumnBreakpointModifiers OrderFirst()
        {
            this.AddPendingClass($"order-{{0}}-first");
            return this;
        }

        /// <summary>
        /// Visually orders the column as the last column.
        /// </summary>
        public IColumnBreakpointModifiers OrderLast()
        {
            this.AddPendingClass($"order-{{0}}-last");
            return this;
        }

        #endregion

        #region Breakpoint modifiers

        IColumnFeatures IResponsiveBreakpointModifiers<IColumnFeatures>.OnAll()
        {
            this.FlushPendingClasses();
            return this;
        }

        IColumnFeatures IResponsiveBreakpointModifiers<IColumnFeatures>.OnSm()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.SM);
            return this;
        }

        IColumnFeatures IResponsiveBreakpointModifiers<IColumnFeatures>.OnMd()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.MD);
            return this;
        }

        IColumnFeatures IResponsiveBreakpointModifiers<IColumnFeatures>.OnLg()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.LG);
            return this;
        }

        IColumnFeatures IResponsiveBreakpointModifiers<IColumnFeatures>.OnXl()
        {
            this.FlushPendingClasses(ResponsiveBreakpoint.XL);
            return this;
        }

        #endregion

    }
}
