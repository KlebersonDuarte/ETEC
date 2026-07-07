<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="EsqueceuSenha.php?senha=enviar" method="post">
        <label for="Email">Email do usuário:</label><br>
        <input type="email" name="emailRec" placeholder="Digite o email do usuário"><br>
        <br>

        <input type="submit" name="Enviar" value="Enviar senha">
    </form>
</body>
</html>
<?php

/*Verifica se o form enviou algo*/
if(isset($_REQUEST['senha']) && ($_REQUEST['senha'] == "enviar")){

/*Verifica se o botão 'Enviar senha' foi clicado*/
if(isset($_POST['Enviar']) && isset($_POST['Enviar']) == 'Enviar senha'){

 session_start();

 /*Configurando o phpMailer*/
$emailRec = $_POST['emailRec'];

include "conexao.php";

include "SenhaEmail.php";

$de = 'murilogcordeiro08@gmail.com';
$de_nome = 'Murilo';


require_once("phpmailer/class.phpmailer.php");
if(!empty($error)){
     echo $error;
}

/* Buscando a senha */
$sql = "select SENHA_USUARIO from tb_usuario where EMAIL_USUARIO = ?";
$stmt = $conexao->prepare($sql);
$stmt->bindParam(1, $emailRec);
$stmt->execute();

/*Verificando se o email existe*/
if(!$stmt->rowCount() > 0){
      echo "Email inexistente";
  return;
}

$usuario = $stmt->fetch();

// Estas configurações smtp, são encontradas na internet do seu servidor para resposta
function smtpmailer($para, $de, $de_nome,$assunto, $corpo)
{
    global $error;
    $mail = new PHPMailer();
    $mail ->IsSMTP(); // Ativar SMTP
    $mail ->SMTPDebug = 0; // Debugar; 1 = erros e mensagens, 2 = mesagens apenas
    $mail ->SMTPAuth = true; // Autenticação ativada     
    $mail ->SMTPSecure = 'tls'; // Padrão de segurança
    $mail ->Host = 'smtp.gmail.com'; // SMTP utilizado
    $mail ->Port = 587; //A porta 587 deverá estar aberta em seu servidor
    $mail ->Username = USER;
    $mail ->Password = PWD;
    $mail ->SetFrom($de, $de_nome);
    $mail ->Subject = $assunto;
    $mail ->Body = $corpo;
    $mail ->AddAddress($para);

    if(!$mail->Send()){
       
        echo ('Email não encontrado.');
        return false;
    }
    else{
        $error = 'Mensagem enviada';
        return true;
    }
}

$senha = $usuario["SENHA_USUARIO"];
$Vai = "Senha: $senha"; 

//Mesmo caso aqui em baixo devera estar o e-mail e o nome de quem ira responder
if(smtpmailer($emailRec, $de, $de_nome, 'Resposta contato', $Vai)){
    
  echo ('Sucesso enviado, '); //Redireciona para uma pagina de obrigado
    $_SESSION['controleResp'] = "enviado";
    header('location:Login.php');
}


}
}



