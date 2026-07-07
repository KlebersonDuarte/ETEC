<?php 

session_start();

$idContato = $_SESSION['IdContato'];
$respContato = $_SESSION['respContato'];

$alterarContato = new  UpdateContato($idContato, $respContato);

class UpdateContato{
    //Cria uma classe pública onde todos os arquivos do programa tem acesso

    public $IdContato;
    public $respContato;

    public function __construct($idContato, $respContato)
    {
        $this->IdContato = $idContato;
        $this->respContato = $respContato;
    }

    public function atualizarResposta(){

        try{
            include "conexao.php";

            $AtualizarContato = $conexao->prepare("UPDATE TB_FALECONOSCO SET RESP_CONTATO = ? WHERE ID_CONTATO = ?");
            $AtualizarContato->bindParam(1,$this->respContato);
            $AtualizarContato->bindParam(2,$this->IdContato);

            if($AtualizarContato->execute()){
                if($AtualizarContato->rowCount() > 0){

                    $_SESSION['controleResp'] = "respondido";
                    header('location:FormFaleConoscoAdm.php');
                }
            }
        }catch(PDOException $erro){
            echo "Erro: " . $erro->getMessage();
        }
    }
}

$alterarContato->atualizarResposta();

?>
