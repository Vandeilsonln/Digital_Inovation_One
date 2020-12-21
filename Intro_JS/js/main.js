function botao(){
    document.getElementById('clicou').innerHTML = 'Obrigado por clicar';
    
}

function redirecionar(){
    window.open('https://google.com.br')
}

function trocar(elemento){
    elemento.innerHTML = 'Despassa o mouse agora'
}

function voltar(elemento){
    elemento.innerHTML = 'Passe mais uma vez'
}

function load(){
    alert('página carregada')
}

function change(elemento){
    console.log(elemento.value)
}