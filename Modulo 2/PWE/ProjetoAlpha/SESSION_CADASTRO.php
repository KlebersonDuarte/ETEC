<?php
header('Content-Type: text/html; charset=utf-8');
//Testando sessões em php

if(isset($_REQUEST['valor']) and ($_REQUEST['valor'] == 'enviado'))
{
    //Verifica se as senhas são iguais

if($_POST['senha_usuario'] != $_POST['confSenha_usuario']){

echo "<script> alert('Por favor insira senhas iguais')</script>";
echo ("<meta http-equiv='refresh'content=0;'SESSION_CADASTRO.php'>");
return;
}

    //Cria sessão se usuário tiver clicado no botão enviar do formulário
    session_start();
//Criar varíaveis de sessão que inicia junto com o formulário:
    if($_POST['nome_usuario'] == "" || $_POST ['cpf_usuario']  == "" || $_POST['email_usuario']  == "" || $_POST['senha_usuario'] == ""){
        
        echo "<script> alert('Preencha todos os campos!')</script>";
        echo ("<meta http-equiv='refresh'content=0;'SESSION_CADASTRO.php'>");
        return;
    }

    $_SESSION['nome'] = $_POST['nome_usuario'];
    $_SESSION['cpf'] = $_POST ['cpf_usuario'];
    $_SESSION['email'] = $_POST['email_usuario'];
    $_SESSION['senha'] = $_POST['senha_usuario'];
    
        //exibe link para a página 02:
            echo "<a href='SESSION_BANCO.php'> Continuar cadastrando! </a>";


}
else{
    session_start();
 //Se usuário ainda não clicou no botão de enviar,mostra o formulário na página:
?>

<form name = "form1" action="SESSION_CADASTRO.php?valor=enviado" method="post">
    <p>Digite seu Nome: <br> <input type="text" name = "nome_usuario"  value="<?php if (isset($_SESSION['conf']) and $_SESSION['conf'] == 1){
        echo $_SESSION['nomeL'];
    }?>"> <br>
    <p>Digite seu CPF: <br> <input type="text" placeholder="000.000.000-00" name="cpf_usuario" maxlength="14"  value="<?php if (isset($_SESSION['conf']) and $_SESSION['conf'] == 1){
        echo $_SESSION['cpfL'];
    }?>"><br>
    <p>Digite seu Email: <br> <input type="email" name= "email_usuario" value="<?php if (isset($_SESSION['conf']) and $_SESSION['conf'] == 1){
        echo $_SESSION['emailL'];
    }?>"><br>
    <p>Digite sua Senha: <br> <input type="password" name= "senha_usuario"  value="<?php if (isset($_SESSION['conf']) and $_SESSION['conf'] == 1){
        echo $_SESSION['senhaL'];
    }?>"><br>
    <p>Confirme sua Senha: <br> <input type="password" name = "confSenha_usuario"  value="<?php if (isset($_SESSION['conf']) and $_SESSION['conf'] == 1){
        echo $_SESSION['senhaL'];
    }?>"><br>
    <br>
    <input type="submit" value="Confirmar Dados">
    </p>
</form>

<?php
}

?>