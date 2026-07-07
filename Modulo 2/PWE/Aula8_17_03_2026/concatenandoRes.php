<?php
$Frase1 = $_POST['Frase1'];
$Frase2 = $_POST['Frase2']; 

//Escrevendo
$str = chr(240) . chr(159) . chr(144) . chr(152);
echo $str;
//chr(n) valor na tabela ascii
//bibliotexa https://www.php.net/manual/en/function.chr.php

$file = fopen('dados2.txt',"w"); //Abrir arquivo
fwrite($file,$Frase1.chr(10));
fwrite($file,$Frase2);
fclose($file);

//Lendo o arquivo em linhas

$arquivo = file('dados2.txt');
for ($i = 0; $i <count ($arquivo); $i++){
    //exibe cada linha cim quebra html
    echo $arquivo[$i] . "<br>";
}
?>

<?php
//Direciona o caminho a ser encaminhado

//Enviando o arquivo aberto
ob_start();//Inicia a sequência
include ("dados.txt"); //Inclue o código
header ("Location: http://www.google.com.br"); //Manda o endereço
ob_flush();
?>