<?php
$segundos = $_POST["segundos"];

if(empty($segundos)){
    echo "Por favor digite um determinado tempo em segundos";
    return;
}

/*com essa função pega só o valor inteiro do resultado,
ai pra pegar o resto e n ficar estranho,
faz outra conta.
Ex:restoMin = segundos % 60.*/
$minutos = intdiv($segundos, 60);
$horas = intdiv($minutos, 60);
$dias = intdiv($horas, 24);
$semanas = intdiv($dias, 7);
$meses = intdiv($semanas, 4);

echo ("Convertendo fica:
<br>$meses mês(es)
<br>$semanas semana(s)
<br>$dias dia(s)
<br>$horas hora(s)
<br>$minutos minuto(s)
<br>$segundos segundo(s)
");
?>