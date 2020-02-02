using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardGroup
    {
        public CardGroup()
        {
            this.Type = CardGroupType.Group;
        }


        [Parameter]
        public CardGroupType Type { get; set; }


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
