<?php
session_start();
//Recebe valores postados
$idContato = $_SESSION['IdContato'];

$LocalizarContato = new SelectContato ($idContato);

class SelectContato
{
    //Cria uma classe Pública, onde todos os arquivos do projeto tem acesso
    public $idContato;
    public function __construct($idContato){
        //Método construtor é responsavel pelo vinculo dos campos aos objetos criados
        $this->idContato = $idContato;
    }
    public function LocalizarContato()
    {
        include "conexao.php";
        try
        {
            $SelecaoContato=$conexao->prepare("SELECT * FROM TB_FALECONOSCO WHERE ID_CONTATO=?");
            $SelecaoContato->bindParam(1, $this-> idContato);
            if($SelecaoContato->execute())
            {
                if($SelecaoContato->rowCount() > 0)
                {
                    while($Linha = $SelecaoContato->fetch(PDO::FETCH_OBJ))
                    {
                        $id = $Linha->ID_CONTATO;
                        $_SESSION['IdContato'] = $id;

                        $nome = $Linha->NOME_CONTATO;
                        $_SESSION['nomeContato'] = $nome;

                        $fone = $Linha->FONE_CONTATO;
                        $_SESSION['foneContato'] = $fone;

                        $email = $Linha->EMAIL_CONTATO;
                        $_SESSION['emailContato'] = $email;

                        $assunto = $Linha->ASSUNTO_CONTATO;
                        $_SESSION['assuntoContato'] = $assunto;

                        $msg = $Linha->MSG_CONTATO;
                        $_SESSION['msgContato'] = $msg;

                        $resp = $Linha->RESP_CONTATO;
                        $_SESSION['respContato'] = $resp;

                        $_SESSION['controleResp'] = "Localizado";
                        header('location:FormFaleConoscoAdm.php');
                    }
                }
            }
        }
        catch(PDOException $erro)
        {
            echo "Erro" . $erro->getMesage();
        }
    }
}
$LocalizarContato->LocalizarContato();
?>