<?php
class ContaBancaria
{
	private $banco; 
	private $nomeTitular;
	private $numeroAgencia; 
	private $numeroConta; 
	private $saldo;   
    
    public function __construct($banco, $nomeTitular, $numeroAgencia, $numeroConta, $saldo)
    {
    	$this->banco = $banco; 
    	$this->nomeTitular = $nomeTitular; 
    	$this->numeroAgencia = $numeroAgencia; 
    	$this->numeroConta = $numeroConta; 
    	$this->saldo = $saldo; 

    }
    public function obterSaldo()
    {
    	return 'Seu saldo atual é : R$ ' .$this-> saldo;  
    }
    
    public function depositar($valor)
    {
    	$this-> saldo += $valor;
    	
    }
    
    public function sacar($valor)
    {
    	$this-> saldo -= $valor;
    }

}
$conta =  new ContaBancaria(
'Banco do Brasil', 
'Cleiton Fabiano Patricio', 
'7788',
'5754-78',
300.00);

echo $conta->obterSaldo();

echo '<BR>';

$conta -> depositar (150.00); 

echo $conta->obterSaldo();

echo '<BR>';

echo $conta->sacar(100.00);

echo $conta->obterSaldo();
echo '<BR>';

?>