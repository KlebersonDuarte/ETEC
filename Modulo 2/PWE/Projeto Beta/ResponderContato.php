<?php
session_start();

$nome = $_SESSION['nomeContato'];
$email = $_SESSION['emailContato'];
$telefone = $_SESSION['foneContato'];
$opcoes = $_SESSION['assuntoContato'];
$mensagem = $_SESSION['msgContato'];
$corpo = $_SESSION['respContato'];

echo ($nome);
$data_envio = date('d/m/Y');
$hora_envio = date('h:i:s');

include "SenhaEmail.php";
$para = $email;
$de = 'murilogcordeiro08@gmail.com';
$de_nome = 'Murilo';
$assunto = $opcoes;

require_once("phpmailer/class.phpmailer.php");

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
        $error = 'Mail error:' . $mail->ErrorInfo;
        return false;
    }
    else{
        $error = 'Mensagem enviada';
        return true;
    }
}

$Vai = "Nome: $nome\n\nEmail: $email\n\nTelefone: $telefone\n\nMensagem: $mensagem\n\nResposta: $corpo";

//Mesmo caso aqui em baixo devera estar o e-mail e o nome de quem ira responder
if(smtpmailer($email, $de, $de_nome, 'Resposta contato', $Vai)){
    
    echo ('Sucesso enviado, '); //Redireciona para uma pagina de obrigado
    $_SESSION['controleResp'] = "enviado";
    header('location:FormFaleConoscoAdm.php');
}
if(!empty($error)) echo $error;
    

   

?>