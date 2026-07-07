function fSenha() {
    // Pegando os valores das senhas
    senha = document.getElementById('Senha').value;  // Pega o valor do campo de senha
    confirmar = document.getElementById('Confirmar').value;  // Pega o valor do campo de confirmação

    // Verifica se as senhas são iguais
    if (senha == confirmar) {
        // Se as senhas forem iguais, abre a nova página
        window.open("menu.html", "_blank");
    } else {
        // Se as senhas não forem iguais, mostra um alerta
        alert("Senhas não coincidem!");
    }
}
