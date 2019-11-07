const sections = document.querySelectorAll('section');

const calsubtotal = document.getElementById('calSubtotal');

const inputs = document.querySelectorAll('input');

const myChange = new Event('myChange');

var somaTotal = 0;

/*pega o valor total inicial da compra*/
sections.forEach( section => {

    somaTotal =  parseFloat(section.innerHTML.replace(',','.')) + parseFloat(somaTotal) ;   

    document.getElementById('total').textContent = somaTotal.toString().replace('.',',');
});

/*declara eventos */
document.addEventListener('change',event=>{
  EventTarget.prototype.dispatchEvent.call(event.target,myChange)
});

/*faz o calculo do valor a ser paga por produto multiplicando pela quantidade */
inputs.forEach(input => {

  input.addEventListener('myChange',event=>{

    let valor = parseFloat(document.querySelector('.'+event.target.id).innerHTML.replace(',','.')).toFixed(2) * parseInt(document.getElementById(event.target.id).value);
    
    document.getElementsByName(event.target.id)[0].textContent = valor.toString().replace('.',',');

  })
});

calsubtotal.addEventListener('click',event=>{

  let elementos = document.getElementsByClassName('preco_subTotal');

  let soma=0;

  let valores = [];

  for (let i = 0; i < elementos.length; i++) {
    valores.push(elementos[i].innerHTML.replace(',','.'))
  }

  valores.map(valor =>{
    soma = parseFloat(soma) + parseFloat(valor);
  });

  document.getElementById('subtotal').textContent = soma.toString().replace('.',',');
  console.log(soma)
});