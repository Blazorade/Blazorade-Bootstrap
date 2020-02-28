using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents a group of <see cref="Card"/> components.
    /// </summary>
    public partial class CardGroup
    {
        /// <summary>
        /// </summary>
        public CardGroup()
        {
            this.Type = CardGroupType.Group;
        }


        /// <summary>
        /// Specifies the type for the group.
        /// </summary>
        [Parameter]
        public CardGroupType Type { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            switch (this.Type)
            {
                case CardGroupType.Group:
                    this.AddClasses(ClassNames.CardGroups.Group);
                    break;

                case CardGroupType.Deck:
                    this.AddClasses(ClassNames.CardGroups.Deck);
                    break;

                case CardGroupType.Columns:
                    this.AddClasses(ClassNames.CardGroups.Columns);
                    break;
            }
            base.OnParametersSet();
        }
    }
}
