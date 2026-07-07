<?php

$n = $_POST ["numero"];

if($n == 3)
{
echo ('o valor de N é 3');
echo ('<BR>'); 
}
else if ($n == 4)
{
echo ('o valor de N é 4');
echo ('<br>');
}

else
{
echo ('o valor de N não é 3. e nem 4');
echo ('<br>');

}


$i = $_POST["numero"];

switch($i){
    case 0:
            echo ("O valor de escolha de 0");  
            break;      
                case 1:
            echo ("O valor de escolha de 1");       
                        break;      
                case 2:
            echo ("O valor de escolha de 2");
                        break;             
                case 3:
            echo ("O valor de escolha de 3");
                        break;      
        
    default:
    echo ("Nenhum das opções."); 
    break;
}


echo("<br>");

$N = $_POST ["numero"];

for($i = 0; $i <=$N;$i++){
    echo($i. " ");
}

echo("<br>");

$N = $_POST ["numero"];
$i = 0;
while ($i < $N)
{
    echo ($i.' ');
    $i++;
}