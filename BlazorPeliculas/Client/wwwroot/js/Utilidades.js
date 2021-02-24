function pruebaPuntoNet() {
    DotNet.invokeMethodAsync("BlazorPeliculas.Client", "OntenerCurrentCount")
        .then(resultado => {
            console.log("conteo desde js " + resultado);
        });
}

function pruebaNetInstancia(dornetHelper) {
    dornetHelper.invokeMethodAsync("IncrementCount");
}