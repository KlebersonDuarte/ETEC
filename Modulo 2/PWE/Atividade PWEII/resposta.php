 <?php
 $numero = $_POST ["numero"];
 $numero2 = $numero % 3 ;
 $numero3 = $numero % 7;

 if($numero2 == 0 && $numero3 == 0){
    echo ' É multiplo de 3 e 7 ao mesmo tempo  ';
 }
 else{
    echo 'Não é numero multiplo de 3 e 7 ao mesmo tempo' ;
 }

///

 $numero = $_POST["numero"];
 $num2 = $numero % 2;
echo '<br>';

 if ($num2== 0 ){
    echo 'O numero é par';
 }
 else{
    echo ' O numero é impar';
 }
 
 ?>