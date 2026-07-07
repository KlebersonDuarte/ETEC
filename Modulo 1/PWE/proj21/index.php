<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form id="CadAlunos" action="" method="">
  <fieldset>
    <legend>Cadastro</legend>

    <label for="Matricula">Matrícula</label>
    <input type="number" name="Matricula" id="Matricula"><br>

    <label for="Aluno">Aluno</label>
    <input type="text" name="Aluno" id="Aluno"><br>

    <label for="Nota1">Nota1</label>
    <input type="number" name="Nota1" id="Nota1" step="0.01"><br>

    <label for="Nota2">Nota2</label>
    <input type="number" name="Nota2" id="Nota2" step="0.01"><br>

    <label for="Nota3">Nota3</label>
    <input type="number" name="Nota3" id="Nota3" step="0.01"><br><br>

    <input type="button" value="Calcular" onclick="fCalcular()">
    <input type="button" value="Gravar" onclick="fGravar()">
  </fieldset>
</form>

<br><br><br><br>

<div id="MsgRetorno">
  <!-- aqui ficará o retorno -->
</div>
<script src="js/aluno.js"></script>
</body>
</html>