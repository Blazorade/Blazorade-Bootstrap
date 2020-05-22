using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The Pagination component allows you to supply a set of links and display a bootstrap pagination bar on the screen.
    /// </summary>
    public partial class Pagination
    {
        /// <summary>
        /// </summary>
        public Pagination()
        {
            this.HighlightCurrent = true;

            this.ShowNavigation = true;

            this.NextPageLinkText = ">>";
            this.PreviousPageLinkText = "<<";
        }



        /// <summary>
        /// Fired when the <see cref="CurrentPage"/> parameter has changed.
        /// </summary>
        [Parameter]
        public EventCallback<Pagination> OnCurrentPageChanged { get; set; }

        /// <summary>
        /// The zero-based index of the currently selected page.
        /// </summary>
        [Parameter]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Set the size of the pagination component. Defaults to <see cref="PaginationSize.Normal"/>.
        /// </summary>
        [Parameter]
        public PaginationSize? Size { get; set; }

        /// <summary>
        /// The number of pages to show.
        /// </summary>
        [Parameter]
        public int PageCount { get; set; }

        /// <summary>
        /// Specifies whether to highlight the currently selected page.
        /// </summary>
        [Parameter]
        public bool HighlightCurrent { get; set; }

        /// <summary>
        /// Specifies whether to show the Next and Previous navigation controls.
        /// </summary>
        [Parameter]
        public bool ShowNavigation { get; set; }

        /// <summary>
        /// The template that allows you to customize how the next page link is rendered.
        /// </summary>
        [Parameter]
        public RenderFragment NextPageLinkTemplate { get; set; }

        /// <summary>
        /// The text to show in the next page link.
        /// </summary>
        [Parameter]
        public string NextPageLinkText { get; set; }

        /// <summary>
        /// The template that allows you to customize how a page item link is rendered. The context parameter passed to
        /// the template is the zero-based index of the page item to render.
        /// </summary>
        [Parameter]
        public RenderFragment<int> PageItemLinkTemplate { get; set; }

        /// <summary>
        /// The template that allows you to customize how the previous page link is rendered.
        /// </summary>
        [Parameter]
        public RenderFragment PreviousPageLinkTemplate { get; set; }

        /// <summary>
        /// The text to show in the previous page link.
        /// </summary>
        [Parameter]
        public string PreviousPageLinkText { get; set; }



        /// <summary>
        /// Navigates to the given page.
        /// </summary>
        /// <param name="pageIndex">The zero-based index of the page to navigate to.</param>
        public async Task NavigateToAsync(int pageIndex)
        {
            if(pageIndex >= 0 && pageIndex < this.PageCount)
            {
                if(this.CurrentPage != pageIndex)
                {
                    this.CurrentPage = pageIndex;
                    await this.OnCurrentPageChangedAsync();
                }
            }
            else
            {
                // Should never come here.
            }
        }

        /// <summary>
        /// Navigates to the next page.
        /// </summary>
        public async Task NextAsync()
        {
            if(this.CurrentPage < this.PageCount - 1)
            {
                this.CurrentPage++;
                await this.OnCurrentPageChangedAsync();
            }
            else
            {
                // This should not occur with the default setup, so if it happens, the developer has tweeked the control so maybe we need to log something.

            }
        }

        /// <summary>
        /// Navigates to the previous page.
        /// </summary>
        public async Task PreviousAsync()
        {
            if(this.CurrentPage > 0)
            {
                this.CurrentPage--;
                await this.OnCurrentPageChangedAsync();
            }
            else
            {
                // Again, this should not happen, so we might want to log something to the developer.
            }
        }



        protected IEnumerable<int> CreatePageIndexArray()
        {
            int ix = 0;

            while(ix < this.PageCount)
            {
                yield return ix;
                ix++;
            }

            yield break;
        }

        /// <summary>
        /// Fires the <see cref="OnCurrentPageChanged"/> event.
        /// </summary>
        protected virtual async Task OnCurrentPageChangedAsync()
        {
            await this.OnCurrentPageChanged.InvokeAsync(this);
        }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Paginations.Pagination);

            if(this.Size == PaginationSize.Large)
            {
                this.AddClasses(ClassNames.Paginations.Large);
            }
            else if (this.Size == PaginationSize.Small)
            {
                this.AddClasses(ClassNames.Paginations.Small);
            }

            base.OnParametersSet();
        }
        
    }

    /// <summary>
    /// Bootstrap Pagination sizes
    /// </summary>
    public enum PaginationSize
    {
        /// <summary>
        /// The "normal" size for a bootstrap Pagination element. This is the default.
        /// </summary>
        Normal,

        /// <summary>
        /// The "large" size for a bootstrap Pagination element.
        /// </summary>
        Large,

        /// <summary>
        /// The "small" size for a bootstrap Pagination element.
        /// </summary>
        Small
    }

}
