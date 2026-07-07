<html>
<html lang="pt-br">

<meta charset="utf-8">
<head>
<title>Vericicador do CPF Integrado ao HTML! </title>
</head>

<form action="cpfIntegrado.php?valor=Verificar" method="post">
<body>
<p> Digite o CPF: <input type="text" name="cpf" placeholder="000.000.000-00">
<input type="submit" value="Verificar">
</p>
</form>

<?php
if(isset($_REQUEST['cpf']) and ($_REQUEST['valor'] == 'verificar'))
{
if (isset($_POST ["cpf"]))
{
$CPF = $_POST["cpf"];

$D11 = substr ($CPF,0,1)*11;
$D10 = substr ($CPF,1,1)*10;
$D9 = substr ($CPF,2,1)*9;
$D8 = substr ($CPF,4,1)*8;
$D7 = substr ($CPF,5,1)*7;
$D6 = substr ($CPF,6,1)*6;
$D5 = substr ($CPF,8,1)*5;
$D4 = substr ($CPF,9,1)*4;
$D3 = substr ($CPF, 10,1) * 3;
$D2 = substr ($CPF, 12,1) * 2;
$C1 = substr ($CPF,13,1);

$X=0;

$SOMA=($D11+$D10+$D9+$D8+$D7+$D6+$D5+$D4+$D3+$D2);
$RESTO = $SOMA % 11; //RESTO DA DIVISAO POR 11
$VER=11-$RESTO; // VERIFICADOR

if ($CPF == '000.000.000-00'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '111.111.111-11'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '222.222.222-22'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '333.333.333-33'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '444.444.444-44'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '555.555.555-55'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '666.666.666-66'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '777.777.777-77'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '888.888.888-88'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($CPF == '999.999.999-99'){ $X=1;
ECHO ('O CPF:'.$CPF.' os numeros digitados não são válidos!');}

if ($VER >= 10) $VER=0;

if ($C1 == $VER && $X != 1)
{
ECHO ('O CPF:'.$CPF.' é verdadeiro!');
}
else if ($X != 1)
{
ECHO ('O CPF:'.$CPF.' é falso!');
}
}
}
?>
</body>


</html>