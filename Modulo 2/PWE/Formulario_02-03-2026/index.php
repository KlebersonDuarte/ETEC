<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<form action="index.php?valor=enviar" method="POST">

<P>Digite o seu nome: <input type="text" name="nome" id="nome" while="30" maxlength="30"> <br></P>

<P>Digite o sua idade: <input type="number" name="idade" id="idade" while="12" maxlength="99"> <br></P>

<P>Selecione seu estado civil: 
    <input type="radio" name="civil" value="casado">Casado 
    <input type="radio" name="civil" value="solteiro">Solteiro<br></P>

<P>Marque as linguagens que você conhece: 
    <input type="checkbox" name="linguagem1"  value="Csharp">C Sharp 
        <input type="checkbox" name="linguagem2"  value="Csharp">Java Script 
            <input type="checkbox" name="linguagem3"  value="Csharp">Java
                <input type="checkbox" name="linguagem4"  value="Csharp">PHP 
     <br></P>

     <P>Marque sue nível de conhecimento de TI: 
        <select name="nivel" id="Nivel">
            <option default value="Selecione">Selecione seu nível de TI:</option>
            <option value="Básico">Básico</option>
            <option value="Intermediario">Intermediário</option>
            <option value="Avancado">Avançado</option>

        </select> <br></P>

        <P>Data de Nascimeto: 
            <input type="date" name="dtaNascimento"> <br></P>

                    <P>E-mail: 
            <input type="email" name="email"> <br></P>

                              <P>Fone: 
            <input type="tel" name="fone" pattern="({[0 9]2}) {[0 9]1}-{[0 9]4}-{[0 9]4}" placeholder="(00)0-0000-0000" require> <br></P>  

            <input type="submit" value="Enviar">
        </form>


        <?php
        if(isset($_REQUEST['nome']) and ($_REQUEST['valor'] == 'enviar'))
        {
            if(isset ($_POST["nome"] ))
            {
                $Nome = $_POST ["nome"];
                echo ('Nome: ' .$Nome . '<BR>');

                $idade = $_POST ["idade"];
                echo ('Idade:' .$idade . '<BR>');

                $EstadoCivil = $_POST["civil"];
                echo ('Estado Civil: ' .$EstadoCivil . '<BR>');

                if(isset ($_POST ['linguagem1'] )){
                    $linguagens = $_POST["linguagem1"] ;
                    echo('linguagens : ' .$linguagens. '<BR>' );

                
                }
                if(isset($_POST["linguagem2"]))
                {
                    $linguagens = $_POST["linguagem2"];
                    echo('Linguagens : ' .$linguagens . '<BR>');

                }
                if(isset($_POST["linguagem3"]))
                {
                    $linguagens = $_POST["linguagem3"];
                    echo('Linguagens : ' .$linguagens . '<BR>');

                }
                if(isset($_POST["linguagem4"]))
                {
                    $linguagens = $_POST["linguagem4"];
                    echo('Linguagens : ' .$linguagens . '<BR>');

                }
                $Nivel = $_POST["nivel"];
                echo('Seu nível : ' .$Nivel . '<BR>');

                $Nascimento = $_POST["dtaNascimento"];
                echo('Data de nascimento : ' .$Nascimento . '<BR>');

                $Email = $_POST["email"];
                echo('Email : ' .$Email . '<BR>');

                $Fone = $_POST["fone"];
                echo('Fone : ' .$Fone . '<BR>');


            }
        }
        ?>
</body>
</html>
