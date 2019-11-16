using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Client.Shared
{
    public partial class GenericList<TElement> : ComponentBase
    {
        [Parameter] 
        public List<TElement> Elements { get; set; }

        [Parameter] 
        public RenderFragment NullTemplate { get; set; }

        [Parameter] 
        public RenderFragment EmptyTemplate { get; set; }

        [Parameter] 
        public RenderFragment WithElementsTemplate { get; set; }

        [Parameter] 
        public RenderFragment<TElement> WithIndividualElementTemplate { get; set; }
    }
}
