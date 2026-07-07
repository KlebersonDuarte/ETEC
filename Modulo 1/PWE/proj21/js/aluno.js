async function fGravar() {
  const MsgRetorno = document.getElementById('MsgRetorno');
  const formAluno = document.getElementById('CadAlunos');
  const DadosForm = new FormData(formAluno);

  const dados = Object.fromEntries(DadosForm.entries());
  dados.acao = "gravar";

  try {
    const Retorno = await fetch('contrAluno.php', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(dados)
    });

    const Resultado = await Retorno.json();

    alert("Mensagem do Servidor: " + Resultado.msg);
    MsgRetorno.textContent = Resultado.msg;

  } catch (error) {
    console.error("Erro na gravação:", error);
  }
}

async function fCalcular() {
  const MsgRetorno = document.getElementById('MsgRetorno');
  const Nota1 = document.getElementById('Nota1').value;
  const Nota2 = document.getElementById('Nota2').value;
  const Nota3 = document.getElementById('Nota3').value;

  const dadosObjeto = { Nota1, Nota2, Nota3 };
  dadosObjeto.acao = "calcular";

  try {
    const Retorno = await fetch('contrAluno.php', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(dadosObjeto)
    });

    const Resultado = await Retorno.json();

    alert(`Média Aluno: ${Resultado.media}, Resultado Final: ${Resultado.Resultado}`);
    MsgRetorno.textContent = `Média: ${Resultado.media} - Resultado: ${Resultado.Resultado}`;

  } catch (error) {
    console.error("Erro no cálculo:", error);
  }
}
