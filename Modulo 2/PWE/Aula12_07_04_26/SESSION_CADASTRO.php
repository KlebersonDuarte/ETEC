<?php
header('Content-Type: text/html; charset=utf-8');
//Testando sessões em php

if(isset($_REQUEST['valor']) and ($_REQUEST['valor'] == 'enviado'))
{
        //Cria sessão se usuário tiver clicado no botão enviar do formulário

    session_start();
//Criar varíaveis de sessão que inicia junto com o formulário:

    $_SESSION['nome'] = $_POST['nome_usuario'];
    $_SESSION['cpf'] = $_POST ['cpf_usuario'];
        //exibe link para a página 02:
            echo "<a href='SESSION_BANCO.php'> Continuar cadastrando! </a>";


}
else{
        //Se usuário ainda não clicou no botão de enviar,mostra o formulário na página:
?>

<form name = "form1" action="SESSION_CADASTRO.php?valor=enviado" method="post">
    <p>Digite seu nome: <br> <input type="text" name = "nome_usuario"> <br>
    <p>Digite seu CPF: <br> <input type="text" placeholder="000.000.000-00" name="cpf_usuario" maxlength="14"><br>
    <br>
    <input type="submit" value="Enviar">
    </p>
</form>

<?php
}

?>