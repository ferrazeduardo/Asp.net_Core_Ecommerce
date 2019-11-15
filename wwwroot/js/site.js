// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



const stars = document.querySelectorAll('.star');
const myDOMContentLoaded = new Event('myDOMContentLoaded');

/*declara eventos */
document.addEventListener('DOMContentLoaded',event=>{
    EventTarget.prototype.dispatchEvent.call(event.target,myDOMContentLoaded)
});



// stars.forEach(star => {
//     star.addEventListener('load',event=>{
//         star.src = '../Imagem/fill-estrela.png'
//     });
// });

// window.addEventListener('load',event=>{
//     const stars = document.querySelectorAll('.star')

//     stars.forEach(star => {
//         star.src = '../Imagem/fill-estrela.png'
//     });
// })

document.addEventListener('DOMContentLoaded', function(){
    console.log("aqui");
})
