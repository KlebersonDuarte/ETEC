
    <?php
//Foeach
    $V1 = $_POST ["valor1"];
        $V2 = $_POST ["valor2"];
            $V3 = $_POST ["valor3"];
                $V4 = $_POST ["valor4"];
    
    $meuArray = Array ($V1,$V2,$V3,$V4);

foreach ($meuArray as $valor){
    echo($valor.' ');
}
echo("###################");
//do e while

$i = 0;
do{
    echo($i.' ');
    $i++;
}

while($i < 5)


    ?>


    <?php
//for com break    
    echo("###################");
for($g = 0;$g <10;$g++){
if($g == 4){
    break;
}
echo($g. " ");


}
echo("###################");
//for com continue
for($g=0;$g<10;$g++){

    if($g ==4){
        $x = $g *5;
        echo($x." ");
        continue;
    }
    echo($g. " ");
}

    ?>