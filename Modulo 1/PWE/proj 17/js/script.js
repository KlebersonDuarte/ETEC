function fEnviar() {
  let tb = parseInt(document.getElementById("tabuada").value);
  let comeco = parseInt(document.getElementById("comeco").value);
  let fim = parseInt(document.getElementById("fim").value);

  let saida = "";

  if (isNaN(tb) || isNaN(comeco) || isNaN(fim)) {
    saida = "Por favor, preencha todos os campos.";
  } 
  else if (tb === 0) {
    saida = "O resultado é sempre zero!";
  } 
  else if (comeco > fim) {
    // loop decrescente
    for (let i = comeco; i >= fim; i--) {
      saida += `${tb} x ${i} = ${tb * i}<br>`;
    }
  } 
  else {
    // loop crescente
    for (let i = comeco; i <= fim; i++) {
      saida += `${tb} x ${i} = ${tb * i}<br>`;
    }
  }

  document.getElementById("resultado").innerHTML = saida;
}
