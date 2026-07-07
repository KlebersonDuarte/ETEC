<?php
function calcularDobro ($x)
{
$dobro = $x * 2;
return $dobro;
}

$i = $_POST ["Numero"];

echo ("O dobro de $i é ". calcularDobro($i). "<br>");

echo ("O valor original de \$i é ".$i);

?>

<?php
echo "<br>";
 $meuValor = 'Brasil';
 echo($meuValor. '<br>'); // Resultado: Brasil

 include_once 'Aula_EX17_10032026.php';
 echo ($meuValor. '<br>'); //Resultado: Itália
 ?>

 <?php
echo ($_SERVER ['SERVER_ADDR']. "<br>");
//Resultado: ip do sevidor

echo ($_SERVER ['SERVER_NAME']. "<br>");
//Resultado: domilio do servidor

echo ($_SERVER ['HTTP_ACCEPT_ENCODING']. "<br>");
//Resultados: dados do sevidor
?>
