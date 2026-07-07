<?php
function CalcularDobro ($numero){
    return $numero *2;
}

$meuArray = array (1,2,3);
$arrayAlterado = array_map('CalcularDobro',$meuArray);

print_r ($arrayAlterado);
?>

<?php
echo ("<BR>" . "-----------------------" . "<BR>");

$meuArray = array ('alpha' => 'valor1',2,"três");
$meuArray[5] = 'Novo Valor';

echo ($meuArray[0] . '<BR>');
echo ($meuArray['alpha'] . "<BR>");
echo ($meuArray[5]. '<BR>');
?>

<?php
echo ( "-----------------------" . "<BR>");

$meuArray = array ('alpha' => 'valor1',2,"três");
$meuArray[5] = 'Novo Valor';

print_r ($meuArray);

?>

<?php
echo ("<BR>" . "-----------------------" . "<BR>");

$arrayAlpha = array ('a','b','c');
$arrayBeta = array ('d','e','f');

$arrayMulti = array($arrayAlpha,$arrayBeta);

echo($arrayMulti [0][2].'<BR>');
echo($arrayMulti [1][2].'<BR>');

print_r ($arrayMulti);
?>


<?php

    $meuArray = array ('a', 'b','c', 'd', 'e');
    unset ($meuArray [3]);

    print_r($meuArray);
?>

<?php
echo ("<BR>". "-----------------------" . "<BR>");

$meyArray = array ('a', 'b','c', 'd', 'e', 'f', 'g');

foreach ($meuArray as $valor)
{
    echo($valor."");
}

end ($meuArray);
prev ($meuArray);
prev ($meuArray);
prev ($meuArray);
prev ($meuArray);
next ($meuArray);

echo (key($meuArray));
echo (current($meuArray));

?>