using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public class ModalToggleButton : Button
    {
        public ModalToggleButton()
        {

        }

        [Parameter]
        public Modal Modal { get; set; }

        [Parameter]
        public ToggleAction Action { get; set; }


        
    }
}
