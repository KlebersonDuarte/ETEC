<!doctype html>
<html lang="en">

<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>Login</title>
</head>

<body>
  <form action="Login.php?login=enviando" method="post">
    <label for="Email">Email::</label>
    <input type="email" name="Email" placeholder="Digite seu email" /><br />

    <label for="Senha">Senha:</label>
    <input type="password" name="Senha" placeholder="Digite sua senha" /><br /><br>

    <input type="submit" name="Logar" value="Logar" /><br />
    <input type="submit" value="Cadastrar" name="Cadastrar" /><br />
    <input type="submit" value="Esqueci a senha" name="Esqueci"> <br>
    <input type="reset" value="Limpar" />
  </form>
</body>

</html>

<?php

/*Verifica se o form enviou algo*/
if (isset($_REQUEST['login']) && ($_REQUEST['login'] == "enviando")) {
  session_start();

  /*Verifica se o botão 'Logar' foi clicado*/
  if (isset($_POST['Logar']) && isset($_POST['Logar']) == 'Logar') {

    $email = $_POST['Email'];
    $senha = $_POST['Senha'];


    if(empty($email) || empty($senha)){
       echo "<script> alert('Preencha todos os campos')</script>";
       return;
    }
    try {


      include 'conexao.php';

      $Comando = $conexao->prepare("SELECT * FROM tb_usuario WHERE EMAIL_USUARIO = :email AND SENHA_USUARIO = :senha");
      $Comando->bindParam(':email', $email);
      $Comando->bindParam(':senha', $senha);

      if ($Comando->execute()) {

        if ($Comando->rowCount() > 0) {

          $email = null;
          $senha = null;
          

          $usuario = $Comando->fetch();

          $_SESSION['id_usuario'] = $usuario['ID_USUARIO'];
          echo "ID salvo: " . $_SESSION['id_usuario'];

          $Comando = $conexao->prepare("SELECT NOME_PEDIDO FROM tb_pedido WHERE ID_USUARIO = ?");

          $ID = $usuario["ID_USUARIO"];

          $Comando->bindParam(1, $ID);
          if ($Comando->execute()) {
            if ($Comando->rowCount() > 0) {

              $dados = $Comando->fetch();

              $_SESSION['nomeL'] = $dados['NOME_PEDIDO'];
              $_SESSION['cpfL'] = $usuario['CPF_USUARIO'];
              $_SESSION['emailL'] = $usuario['EMAIL_USUARIO'];
              $_SESSION['id_usuario'] = $ID;
              $_SESSION['conf'] = 1;
              $_SESSION['senhaL'] = $usuario['SENHA_USUARIO'];

              header("Location:SESSION_CADASTRO.php");
              exit();
            }
          }
        } else {
          echo "<script> alert('Não encotramos nenhum usuário')</script>";
        }
      }
    } catch (PDOException $erro) { {
        echo "Falha do sistema";
        //echo "Erro " . $erro->getMessage();
      }
    }
  } 
    /*Verifica se o botão 'Cadastrar' foi clicado*/
  else if (isset($_POST['Cadastrar']) == 'Cadastrar') {
    $_SESSION['conf'] = 0;
    echo ("<meta http-equiv='refresh'content=0;'SESSION_CADASTRO.php'>");
  }  /*Verifica se o botão 'Esqueci a senha' foi clicado*/
   else if (isset($_POST['Esqueci']) == 'Esqueci a senha') {
    $_SESSION['conf'] = 0;
    echo ("<meta http-equiv='refresh'content=0;'EsqueceuSenha.php'>");
  }
}

//  var_dump($cadastro);
// Visualiza a classe com seus objetos adquiridos

// Executa a função que vai permitir para fazer a inserção
?>