<?php
$data1 = new DateTime(); 
$data2 = new DateTime(); 

$intervalo =  new DateInterval ('P5Y10M5DT10H50M10S'); 

$data1 ->add($intervalo);
$data2 ->sub($intervalo);

var_dump($data1); 
var_dump($data2); 


?>