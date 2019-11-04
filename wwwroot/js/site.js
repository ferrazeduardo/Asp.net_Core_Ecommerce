// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*window.addEventListener('load', (event) => {
    console.log(document.getElementById("valor").innerHTML);
    console.log(document.getElementById("quantidade").val);
  });*/

/*window.addEventListener("click",event=>{
      let valor = parseFloat(document.getElementById("quantidade").value).toFixed(2) * 2;
      console.log(valor);
});*/

  document.querySelector('.quantidade').addEventListener("change",event=>{
    
       let valor =  parseFloat(document.getElementById('valor').innerHTML.replace(',','.')).toFixed(2) * parseInt(document.querySelector('.quantidade').value);
    
       console.log(valor);

       document.getElementById('valor').textContent = valor.toString().replace('.',',');
        
     
    })