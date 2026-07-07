<?php
$frase = $_POST['frase'];
$palavra = 1;

if(empty($frase)){
    echo ('Não a palavras aqui');
    return;
}

for($i = 0; $i < strlen($frase);$i++){
    $espaco = substr($frase,$i,1);


    if($espaco == " "){
        $palavra += 1;
    }
}

echo ("A um total de {$palavra} palavra(s)");
?>