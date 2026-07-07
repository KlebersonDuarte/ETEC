<!DOCTYPE html>
<html>
<head>
	<title></title>
	<meta charset="utf-8">
</head>
<body>
<?php 

session_start();
echo "Dados do Usuário Administrativo:<br>";

$Nome = $_SESSION['nomeAdm'];
$Usuario = $_SESSION['emailAdm'];


if ($_SESSION ['controleAdm'] == 'alterado' )
{
	echo "Cadastro atualizado com sucesso:". '<br>'.'<br>';
}
else
{
	echo "Preencha o campo desejado para ser alterado:". '<br>'.'<br>';
}

if(isset($_REQUEST['valor']) and ($_REQUEST['valor'] == 'enviado'))
{
    $Botao = $_POST ["Botao"]; 

    if ($Botao =="Alterar")
    {
        include "AlteradoAdm.php";   
    }
    if ($Botao =="Gerenciar")
    {
        $_SESSION['controleResp'] = "gerenciar";
        header('location:FormFaleConoscoAdm.php'); 
    }
}
else 
{
    ?> 
    <form name="form1" action="FormAlterarAdm.php?valor=enviado" method="POST">
        Nome: <br>
        <input class="input" type="text" id ="nome_cadastro" placeholder="Preencher Nome" name="nome_cadastro" value="<?php echo htmlspecialchars($Nome);?>"><BR><P>
        
        Usuário:(Email) <br>
        <input class="input" type="text" placeholder="Preencher E-mail" name="usuario_cadastro" name="usuario_cadastro" value="<?php echo htmlspecialchars($Usuario);?>"><BR><p>
        
        Senha:<br>
        <input class="input" type="password" placeholder="Preencher Senha" name="senha_cadastro" maxlength="8" required><BR><p>
        
        Confirmar Senha:<br>
        <input class="input" type="password" placeholder="Preencher Senha" name="senha_confirma" maxlength="8" required><BR><p>
 
        <input name="Botao" type="submit" value="Alterar">
        <input name="Botao" type="submit" value="Gerenciar"><br><p>

        </p>
        </form>
    </body>
   <?php 
}
?>