<?php
require_once "conexao.php";

// Todos objetos do formulário devem estar configurados.
session_start();
$nome = $_SESSION['nome'];
$cpf = $_SESSION['cpf'];
$banco = $_SESSION['banco'];
$conta = $_SESSION['conta'];
$email = $_SESSION['email'];
$senha = $_SESSION['senha'];
$taxa = $_SESSION['taxa'];
$taxa = doubleval($taxa);

$meses = $_SESSION['tempo'];
$meses = intval($meses);

$capital = $_SESSION['valor'];
$capital = number_format($capital, 2, '.', '');
$capital = doubleval($capital);

$rendimento = $_SESSION['rendimento'];
$rendimento = number_format($rendimento, 2, '.', '');
$rendimento = doubleval($rendimento);

$total = $_SESSION['total'];
$total = number_format($total, 2, '.', '');
$total = doubleval($total);

$emailL = $email;
$senhaL = $senha;

if($_SESSION['conf'] != 0){
    $emailL = $_SESSION['emailL'];
    $senhaL = $_SESSION['senhaL'];
}



$cadastro = new CadastroPedido($nome, $cpf, $banco, $conta,$email,$senha ,$taxa, $meses, $capital,$rendimento,$total,$emailL,$senhaL);

// Instancia Objeto, já com valores adquiridos pelo formulário


class CadastroPedido
{  
    // Cria uma classe Publica, onde todos os arquivos do projeto tem Acesso
    public $nome;
    public $cpf;
    public $banco;
    public $conta;
    public $email;
    public $senha;
    public $taxa; 
    public $meses;
    public $capital;
    public $rendimento;
    public $total;
    public $emailL;
    public $senhaL;

    public function __construct($nome, $cpf, $banco, $conta,$email, $senha, $taxa, $meses, $capital, $rendimento, $total,$emailL,$senhaL)
    {
        // Método construtor é responsável pelo vínculo dos campos aos objetos criados
        $this->nome = $nome;
        $this->cpf = $cpf;
        $this->banco = $banco;
        $this->conta = $conta;
        $this->email = $email;
        $this->senha = $senha;
        $this->taxa = $taxa;
        $this->meses = $meses;
        $this->capital = $capital;
        $this->rendimento = $rendimento;
        $this->total = $total;
        $this->emailL = $emailL;
        $this->senhaL = $senhaL;

    }
   
    public function incluirPedido($idUsuario) //Adiciona o pedido a tabela tb_pedido
    {
        try
        {
            global $conexao;
            // Adiciona o arquivo de conexão ao projeto.

            $Comando = $conexao->prepare("INSERT INTO TB_PEDIDO
            (ID_USUARIO, NOME_PEDIDO, BANCO_PEDIDO, CONTA_PEDIDO, TAXA_PEDIDO, MESES_PEDIDO,CAPITAL_PEDIDO,RENDIMENTO_PEDIDO,TOTAL_PEDIDO) 
            VALUES (?, ?, ?, ?, ?, ?, ?,?,?)");



            // Os parâmetros devem vir com os vínculos, agora com nomes dados.
            $Comando->bindParam(1, $idUsuario);
            $Comando->bindParam(2, $this->nome);
            $Comando->bindParam(3, $this->banco);
            $Comando->bindParam(4, $this->conta);
            $Comando->bindParam(5, $this->taxa);
            $Comando->bindParam(6, $this->meses);
            $Comando->bindParam(7, $this->capital);
            $Comando->bindParam(8, $this->rendimento);
            $Comando->bindParam(9, $this->total);

            if ($Comando->execute())
            {
                if ($Comando->rowCount() > 0)
                {

                    $_SESSION['ID_PEDIDO'] = $conexao->lastInsertId();

                    $nome = null;
                    $banco = null;
                    $conta = null;
                    $taxa = null;
                    $meses = null;
                    $capital = null;
                    $rendimento = null;
                    $total = null;

                    echo "<script> alert('Pedido registrado com sucesso!')</script>";
                    echo "<h2>Registro realizado com sucesso</h2>";
                    echo "<p>-----------------------------------</p>";
                    echo '<a href="Gerenciar.php"><button>Ver pedidos</button></a>';

                }
            }
        }
        catch (PDOException $erro)
        {
            echo "<script> alert('Erro ao adicionar pedido')</script>";
            echo ("<meta http-equiv='refresh'content=0;'SESSION_CADASTRO.php'>");
            //echo "Erro " . $erro->getMessage();
        }
    }

    public function incluirUsuario() // Inclui o usuário na tabela tb_usuario
    {
        try
        {
            global $conexao;
            // Adiciona o arquivo de conexão ao projeto.

            $Comando = $conexao->prepare("INSERT INTO TB_USUARIO
            ( EMAIL_USUARIO, SENHA_USUARIO, CPF_USUARIO) 
            VALUES (?, ?, ?)");

            // Os parâmetros devem vir com os vínculos, agora com nomes dados.

            $Comando->bindParam(1, $this->email);
            $Comando->bindParam(2, $this->senha);
            $Comando->bindParam(3, $this->cpf);

            if ($Comando->execute())
            {
                if ($Comando->rowCount() > 0)
                {

                    $email = null;
                    $senha = null;
                    $cpf = null;

                     
                    echo "<script> alert('Usuario inserido com sucesso!')</script>";
        
                }
            }
        }
        catch (PDOException $erro)
        {
            echo "<script> alert('Já existe esse usuário')</script>";
            echo ("<meta http-equiv='refresh'content=0;'SESSION_CADASTRO.php'>");
                    return "!algo";
            //echo "Erro " . $erro->getMessage();
        }


    }
        public function atualizarUsuario(){ //Caso o usuário tenho logado e deseja alterar seus dados

   
        try{
            global $conexao;

           

            $id = $conexao->prepare("SELECT ID_USUARIO from TB_USUARIO WHERE EMAIL_USUARIO = ?");
            $id->bindParam(1,$this->emailL);

            if($id->execute()){
                if($id->rowCount() > 0){
                $dados = $id->fetch(PDO::FETCH_ASSOC);
                $idUsuario = $dados["ID_USUARIO"];

                $Comando = $conexao->prepare('UPDATE TB_USUARIO SET EMAIL_USUARIO = ?, SENHA_USUARIO = ?, CPF_USUARIO = ? WHERE ID_USUARIO = ?');
                $Comando->bindParam(1,$this->email);
                $Comando->bindParam(2,$this->senha);
                $Comando->bindParam(3, $this->cpf);
                $Comando->bindParam(4,$idUsuario);

                if($Comando->execute()){
                    if($Comando->rowCount() >0){
                    echo "<script> alert('Usuario alterado com sucesso!')</script>";
                    }
                }

                }
            }

          
        }
        catch(PDOException $erro){
            echo "<script> alert('Já existe esse usuário')</script>";
            echo ("<meta http-equiv='refresh'content=0;'SESSION_CADASTRO.php'>");
                    return "!algo";
           // echo "Erro " . $erro->getMessage();
        }     
        }

    public function buscarUsuarioID(){

    global $conexao;

    try{

        $Comando = $conexao->prepare("SELECT ID_USUARIO FROM TB_USUARIO WHERE EMAIL_USUARIO = ?");

        $Comando->bindParam(1, $this->emailL);

        if($Comando->execute()){

            if($Comando->rowCount() > 0){
                $dados = $Comando->fetch(PDO::FETCH_ASSOC);

                return $dados['ID_USUARIO'];
            }
        }


    }catch(PDOException $erro){

        echo "<script> alert('Erro ao buscar o usuário')</script>";
        echo ("<meta http-equiv='refresh'content=0;'SESSION_PEDIDO.php'>");
       // echo "Erro " . $erro->getMessage();
    }
}
}

//  var_dump($cadastro);
// Visualiza a classe com seus objetos adquiridos

if($_SESSION['conf'] == 0){ //Cadastrando
//$cadastro->verificarUsuario();
$Cadastro = $cadastro->incluirUsuario();

if($Cadastro != "!algo" ){
$idUsuario = $cadastro->buscarUsuarioID();
$_SESSION['id_usuario'] = $idUsuario; // Guarda o ID do usuário na sessão
$cadastro->incluirPedido($idUsuario);
}
return;
}

else{//Logado
$idUsuario = $cadastro->buscarUsuarioID();
$Cadastro = $cadastro->atualizarUsuario();

if($Cadastro != "!algo"){
$_SESSION['id_usuario'] = $idUsuario;
$cadastro->incluirPedido($idUsuario);
}
return;
}
?>