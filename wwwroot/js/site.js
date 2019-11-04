// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.addEventListener('load', (event) => {
    console.log(document.getElementById("quantidade_@produto.Produto.Nome").innerHTML);
    console.log(document.getElementById("valor_@produto.Produto.Nome").value);
});

window.addEventListener("click",event=>{
      let valor = parseFloat(document.getElementById("quantidade").value).toFixed(2) * 2;
      console.log(valor);
});

