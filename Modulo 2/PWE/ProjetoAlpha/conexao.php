<?php
define ('Banco','dbProjetoAlpha_1S2026');
define ('Usuario','root');
define ('Senha','');

try{
    $conexao = new PDO('mysql:host=localhost; dbname='.Banco, Usuario, Senha);
    $conexao->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $conexao->exec('set names utf8');
}
catch(PDOException $erro){
    echo 'Erro de comexão ' . $erro->getMessage();
}
?>