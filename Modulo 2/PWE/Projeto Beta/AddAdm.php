<?php
// Todos objetos do formulário devem estar configurados.   
$Botao =$_GET["Botao"];
$nomeAdm = $_GET["nome_adm"];
$emailAdm = $_GET["usuario_adm"];
$senhaAdm = $_GET["senha_cadastroAdm"];
$senhaConfirma = $_GET["senha_confirmaAdm"];

$cadastroAdm =  new CadastroAdm ( $nomeAdm , $emailAdm, $senhaAdm);
// Instancia o Objeto, já com valores adquiridos pelo formulário 

class CadastroAdm
{
    //Cria uma classe Publica, onde todos os arquivis do projeto tema cesso
     public $nomeAdm; 
     public $emailAdm;
     public $senhaAdm;           
    
    public function __construct($nomeAdm, $emailAdm, $senhaAdm)
    {
        //Método construtor é respnsavel pelo vinculo dos campos aos aobjtos criados
        $this->nomeAdm = $nomeAdm; 
        $this->emailAdm = $emailAdm;
        $this->senhaAdm = $senhaAdm; 
         
    }
    public function incluirAdm()
    {
        try
        {
            include "conexao.php";
            //Adiciona o arquivo de conexao ao projeto. 

            $Comando=$conexao->prepare("INSERT INTO TB_CADASTRO_ADM (NOME_ADM, EMAIL_ADM, SENHA_ADM) VALUES ( ?, ?, ?)");
            $Comando->bindParam(1, $this-> nomeAdm);
            $Comando->bindParam(2, $this-> emailAdm);
            $Comando->bindParam(3, $this-> senhaAdm);
           
                         
            if ($Comando->execute())
            {
                //var_dump($cadastroAdm); // Visualiza a classe com seus abjetos adquiridos
                if ($Comando->rowCount () >0) 
                {       
                    $nomeAdm = null; 
                    $emailAdm = null;
                    $senhaAdm = null;
                    
                    echo "<script> alert('Usuário Adm registrado com sucesso!')</script>";
                    echo "<A href=\"FormLoginAdm.php\">Sucesso</A>"; 
                }
            }
      
        }   
        catch (PDOException $erro)
        {
            echo"Erro" . $erro->getMessage();
    
        }  
    }
}

if ($senhaConfirma == $senhaAdm)
{
    $cadastroAdm->incluirAdm();
    // Executa a função que vai permitir para fazer a inserção
}   
else
{

    echo "<script> alert('Senhas não conferem!')</script>";
    $senhaAdm = null;
    $senhaConfirma = null; 
    echo "<A href=\"FormAdm.php\">Voltar</A>"; 
  
}
   
?>

        