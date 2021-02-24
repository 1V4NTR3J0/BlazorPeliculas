using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {

        [Inject] ServicioSingleton singleton { get; set; }
        [Inject] ServicioTransient transient { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }

        //IJSObjectReference modulo;

        private int currentCount = 0;
        static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            //modulo = await JS.InvokeAsync<IJSObjectReference>("import", "./js/CounterJS.js");
            //await modulo.InvokeVoidAsync("mostrarAlerta", "Hola mundo");

            currentCount++;
            singleton.Valor = currentCount;
            transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNet");
        }

        protected async Task IncrementCountJS()
        {
            await JS.InvokeVoidAsync("pruebaNetInstancia", DotNetObjectReference.Create(this));
        }
        [JSInvokable]
        public static Task<int> OntenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
