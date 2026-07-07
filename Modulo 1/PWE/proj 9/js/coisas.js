function atualizarRelogio() {
    const agora = new Date(); // Obtém a data e hora atuais
    const horas = String(agora.getHours()).padStart(2, '0');
    const minutos = String(agora.getMinutes()).padStart(2, '0');
    const segundos = String(agora.getSeconds()).padStart(2, '0');

    const horarioFormatado = `${horas}:${minutos}:${segundos}`;
    document.getElementById('relogio').textContent = horarioFormatado; // Exibe a hora formatada
    setInterval(atualizarRelogio, 1000); // Chama a função a cada 1000ms (1 segundo)
    atualizarRelogio(); // Chama a função uma vez para evitar o atraso inicial
   
}


