<?php

  $CodProduto = $_GET ["CodProduto"];
  $descricao = $_GET ["descricao"];
  $quantidade =$_GET["qtde"];
  $preco = $_GET ["valor"];
  $forma = $_GET ["pagamento"];

$produto = "";

$classificacao = ($CodProduto / 1000);
$sequencia = $CodProduto % 1000;


if ($classificacao == 10) 
  {
    $produto = "Bebida";
  }
else if ($classificacao == 20) 
  {
    $produto = "Produto de Limpeza";
  }

  else if ($classificacao == 30) 
  {
    $produto = "Comida";
  }

else
  {
    $produto = "Produto Não Cadastrado";
  }

  $total = $quantidade * $preco;
  if ($forma == "Pix") 
  {
    $total -= $total * 0.00;
  }

  if ($forma == "Parcelado") 
  {
    $total += $total * 0.0275;
  }

  echo 'Classificação='. $classificacao . '<br>';
  echo 'Sequência='. $sequencia . '<br>';
  echo 'Produto=' . $produto . '<br>';
  echo 'Quantidade='. $quantidade . '<br>';
  echo 'Valor='. $preco . '<br>';
  echo 'Forma='. $forma . '<br>';
  echo 'Total='. $total . '<br>';