<?php
$Frase = $_POST['Frase'];

$Vogais = array ('a', 'e', 'i', 'o', 'u');

$Rep = 0;
$valor = "";

for($i = 0; $i <= strlen($Frase); $i++){
    $valor =strtolower( substr($Frase, $i, 1) );

    for($j = 0;$j < 5; $j++){
    if( $valor == $Vogais[$j] ){
        $Rep++;
    }}
}

echo ("O número de vogais é {$Rep}");
?>