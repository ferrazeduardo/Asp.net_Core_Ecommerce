const sections = document.querySelectorAll('section');

var somaTotal = 0;
var subtotal = 0;

sections.forEach( section => {

    somaTotal =  parseFloat(section.innerHTML.replace(',','.')) + parseFloat(somaTotal) ;   

    document.getElementById('total').textContent = somaTotal.toString().replace('.',',');
});


const myChange = new Event('myChange');

document.addEventListener('change',event=>{
  EventTarget.prototype.dispatchEvent.call(event.target,myChange)
});

const inputs = document.querySelectorAll('input');

inputs.forEach(input => {

  input.addEventListener('myChange',event=>{

    let valor = parseFloat(document.querySelector('.'+event.target.id).innerHTML.replace(',','.')).toFixed(2) * parseInt(document.getElementById(event.target.id).value);
    
    document.getElementsByName(event.target.id)[0].textContent = valor.toString().replace('.',',');

    subtotal = subtotal + parseFloat(document.getElementsByName(event.target.id)[0].innerHTML.replace(',','.'));

    console.log(subtotal);
  })
});