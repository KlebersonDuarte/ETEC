<!DOCTYPE html>
<html lang="en">
<head>
    <title></title>
    <meta charset="UTF-8">
</head>
<body>
<?php

session_start();
include "conexao.php";
if($_SESSION ['controleResp'] == 'Localizado')
{
    echo "Ddos do Contato:<br><br>";
    echo "Nome: <BR> " . $_SESSION['nomeContato'];
    echo "Fone: <BR> " . $_SESSION['foneContato'];
    echo "Email: <BR> " . $_SESSION['emailContato'];
    echo "Assunto: <BR> " . $_SESSION['assuntoContato'];
    echo "Mensagem: <BR> " . $_SESSION['msgContato'];
    echo "Resposta: <BR> " . $_SESSION['respContato'];
    echo "Cadastro localizado com sucesso:" . '<br>'.'<br>';
}
else if($_SESSION['controleResp'] == 'respondido')
{
    echo "Resposta gravada com sucesso:<br><br>";
}
else if($_SESSION['controleResp'] == 'enviado')
{
    echo "Resposta enviada com sucesso:<br><br>";
}

    //Carrega a tabela
    $Matriz = $conexao->prepare("select * FROM TB_FALECONOSCO");

    echo "Contatos realizados no site:<br><br>";
    $Matriz->execute();

    echo "<table border=1>";

    while ($Linha = $Matriz->fetch(PDO::FETCH_OBJ))
    {
        $idContato = $Linha->ID_CONTATO;
        $nomeContato = $Linha->NOME_CONTATO;
        $foneContato = $Linha->FONE_CONTATO;
        $emailContato = $Linha->EMAIL_CONTATO;
        $assuntoContato = $Linha->ASSUNTO_CONTATO;
        $msgContato = $Linha->MSG_CONTATO;
        $respContato = $Linha->RESP_CONTATO;

        echo "<tr>";
        echo "<td>" . $idContato ." </td>";
        echo "<td>" . $nomeContato ." </td>";
        echo "<td>" . $foneContato ." </td>";
        echo "<td>" . $emailContato ." </td>";
        echo "<td>" . $assuntoContato ." </td>";
        echo "<td>" . $msgContato ." </td>";
        echo "<td>" . $respContato ." </td>";
        echo "<tr>";
    }

    echo "</table>";

if(isset($_REQUEST['valor']) and ($_REQUEST['valor'] == 'enviar'))
{
    if($_POST['id_contato'] != "")
    {
        $_SESSION['IdContato'] = $_POST['id_contato'];
    }

    if($_POST['resp_contato'] != "")
    {
        $_SESSION['RespContato'] = $_POST['resp_contato'];
    }

    if($_POST['Botao'] == "Alterar")
    {
        header('location:AlterarContato.php');
    }

    if($_POST['Botao'] == "Enviar")
    {
        header('location:ResponderContato.php');
    }

    if($_POST['Botao'] == "Localizar")
    {
        header('location:LocalizarContato.php');
    }
}
else
{
    ?>
    <form name="form1" action="FormFaleConoscoAdm.php?valor=enviar" method="POST">
    Id: <br>
    <input class="input" type="text" id="Codigo" placeholder="Preencher ID" name="id_contato">
    Mensagem de Resposta:<BR>
    <textarea name="resp_contato" placeholder="Preencher a Resposta" rows="8" cols="40" ></textarea><br><p>

    <input name="Botao" type="submit" value="Alterar">
    <input name="Botao" type="submit" value="Enviar">
    <input name="Botao" type="submit" value="Localizar"><br><p>

    </p>
    </form>
    </body>
    </html>

    <?php 
}
?>
</html>