<?php

$Matri = $_GET["Matri"];
$Name = $_GET["Name"];
$Nota1 = $_GET["Nota1"];
$Nota2 = $_GET["Nota2"];
$Nota3 =$_GET["Nota3"];

$media=(($Nota1 + $Nota2 + $Nota3)/3);

echo 'Matrícula=' . $Matri. '<br>';
echo 'Aluno=' . $Name .'<br>';
echo 'Média=' . $media . '<br>';
    
if($media <=4.99){
    echo 'Retido'. '<br>';
}

else if($media <=6.99){
    echo 'Recuperação'. '<br>';
}

else{
    echo 'Aprovado'. '<br>';
}