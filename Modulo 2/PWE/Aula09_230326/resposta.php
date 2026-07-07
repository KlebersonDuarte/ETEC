<?php

$Frase = $_POST ["Frase"];
$tamanho = strlen($Frase);
echo ($tamanho. '<BR>');
// Resultado: exibe o número de caracteres

echo (strlen('abc'). '<BR>');



?>

<?php 
echo('-------------------'. '<BR>');

$Frase = $_POST["Frase"];
echo(strpos($Frase, 'a'). '<BR>');
//Lê a posição dp "a"
echo(strpos('Brasil é bom!', 'a'). '<BR>');
//Retorna: 2
echo(strpos('Brasil é bom  e grande!','a', 4). '<BR>');
// Retorna: 18
$offset = 0;
while(($offset = strpos('banana é bom ' , 'a', $offset+1))!=0)
{
    echo($offset. ',');
}
//Resultado: 1, 3, 5,
?>

<?php
echo( '<BR>' .'-------------------'. '<BR>');

$Frase = $_POST["Frase"];
echo (substr($Frase, 2). '<BR>');

echo (substr('A vida é boa', 2, 3). '<BR>');

echo (substr('A vida é boa', -2, 2). '<BR>');
?>

<?php
echo('-------------------'. '<BR>');

$Nome = $_POST ["Frase"];

echo (strtoupper($Nome). '<BR>');

echo (strtolower($Nome). '<BR>');

echo (ucfirst($Nome). '<BR>');

echo (chr(65). '<BR>');

echo (strrev($Nome). '<BR>');
?>