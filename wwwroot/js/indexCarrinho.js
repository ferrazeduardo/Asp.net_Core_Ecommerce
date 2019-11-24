const sections = document.querySelectorAll('section');

const calsubtotal = document.getElementById('calSubtotal');

const inputs = document.querySelectorAll('input');

const myChange = new Event('myChange');

var todas_linhas = [];

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

  $('.item').each(function(){
        
      var entidade_linha ={
          ProdutoId:$(this).children()[0].innerText,
          Nome:$(this).children()[1].innerText,
          Quantidade:$(this).children()[2].innerText,
          Preco:$(this).children()[4].innerText,
          CarrinhoId: document.getElementById('CarrinhoId').value
      };
      todas_linhas.push(entidade_linha);
  })

  console.log(todas_linhas);

  $("#btn-pedido").append(`<a class='btn btn-success' href='/Pedido/FinalizarCarrinho?Produtos='${todas_linhas}'>Pedido</a>`)
  //enviar_dados(todas_linhas);
  
})
