<?php
// Todos objetos do formulário devem estar configurados.   
$nome =$_GET['Nome']; 
$email =$_GET['Email'];
$fone = $_GET ['Fone'];
$msg = $_GET ['Mensagem'];
$assunto = $_GET ['Assunto'];
$resposta = null;

$cadastro =  new CadastroContato ( $nome , $fone, $email, $assunto, $msg , $resposta);
// Instancia o Objeto, já com valores adquiridos pelo formulário 

class CadastroContato
{
    //Cria uma Classe Publica, onde todos os arquivos do projeto tem Acesso
     public $nome; 
     public $email;
     public $fone; 
     public $msg; 
     public $assunto;
     public $resposta;              
    
    public function __construct($nome, $fone, $email, $assunto, $msg , $resposta)
    {
        //Método construtor é responsavel pelo vinculo dos campos aos objetos criados
        $this->nome = $nome; 
        $this->fone = $fone;
        $this->email = $email;
        $this->assunto = $assunto; 
        $this->resposta = $resposta;
        $this->msg = $msg; 
    }
    public function incluirContato()
    {
        try
        {
            include "conexao.php";
            //Adiciona o arquivo de conexao ao projeto. 

            $Comando=$conexao->prepare("INSERT INTO TB_FALECONOSCO 
            (NOME_CONTATO, FONE_CONTATO, EMAIL_CONTATO, ASSUNTO_CONTATO, MSG_CONTATO, RESP_CONTATO) VALUES ( ?, ?, ?, ?, ?, ?)");
            
            //Os paramentros devem vir com os vinculos, agora com nomes dados. 
            $Comando->bindParam(1, $this-> nome);
            $Comando->bindParam(2, $this-> fone);
            $Comando->bindParam(3, $this-> email);
            $Comando->bindParam(4, $this-> assunto);
            $Comando->bindParam(5, $this-> msg);
            $Comando->bindParam(6, $this-> resposta);
                         
            if ($Comando->execute())
            {
                if ($Comando->rowCount () >0) 
                {
                    $nome = null; 
                    $email = null;
                    $fone = null;
                    $msg = null;
                    $assunto = null;
                    $resposta = null;


                    echo "<script> alert('Contato registrado com sucesso!')</script>";
                    echo ('<meta http equiv="refresh"content=0;"FormFaleConosco.php">'); 
           
                    
                }
            }
      
        }   
        catch (PDOException $erro)
        {
            echo"Erro" . $erro->getMessage();
    
        }  
    }
}

var_dump($cadastro);
// Visualiza a classe com seus objetos adquiridos 

$cadastro->incluirContato();
// Executa a função que vai permitir para fazer a inserção
    
?>

        