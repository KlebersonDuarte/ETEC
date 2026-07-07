<?php
class Venda
{
	private $data; 
	private $produto;
	private $quantidade; 
	private $valorTotal; 
	   
    
    public function __construct($data, $produto, $quantidade, $valorTotal)
    {
    	$this->data = $data; 
    	$this->produto = $produto; 
    	$this->quantidade = $quantidade; 
    	$this->valorTotal = $valorTotal; 
    	

    }
    public function obterValorTotal()
    {
    	return 'Custo da venda : R$ ' .$this-> valorTotal;  
    }    

}
$venda =  new Venda(
'Compra Internacional', 
'XBox Series X', 
'10',
2600.00);

var_dump($venda);

echo $venda->ObterValorTotal();

echo '<BR>'



?>