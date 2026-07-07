<?php

if($_POST["nome_cadastro"] == "") $nomeAdm = $_SESSION['nomeAdm'];
else $nomeAdm = $_POST["nome_cadastro"];

if($_POST["usuario_cadastro"] == "") $usuarioAdm = $_SESSION['emailAdm'];
else $usuarioAdm = $_POST["usuario_cadastro"];

if($_POST["senha_cadastro"] == "") $senhaAdm == $_SESSION['senhaAdm'];
else $senhaAdm = $_POST['senha_cadastro'];

$idAdm = $_SESSION['IdAdm'];

$alteraAdm = new UpdateAdm ( $idAdm, $nomeAdm, $usuarioAdm, $senhaAdm);

class UpdateAdm
{
    //Cria uma classe publica, onde todos os arquivos do projeto tem acesso
    public $nomeAdm;
    public $senhaAdm;
    public $usuarioAdm;
    public $idAdm;

    public function __construct($idAdm, $nomeAdm, $usuarioAdm, $senhaAdm)
    {
        //Método construtor é responsavel pelo vinculo dos campos ao objetos criados
        $this->idAdm = $idAdm;
        $this->nomeAdm = $nomeAdm;
        $this->usuarioAdm = $usuarioAdm;
        $this->senhaAdm = $senhaAdm;
    }
    public function atualizarAdm()
    {
        try
        {
            include "conexao.php";
            //Adiciona o  arquivo conexao ao projeto;

            if($_POST["senha_cadastro"] == $_POST["senha_confirma"])
            {
                $AtualizarNovo = $conexao->prepare("UPDATE TB_CADASTRO_ADM SET NOME_ADM=?, EMAIL_ADM=?, SENHA_ADM=? WHERE ID_ADM=?");
                //Caso não foi preenchido campos
                //Prepara para atualizar
                $AtualizarNovo->bindParam(1, $this-> nomeAdm);
                $AtualizarNovo->bindParam(2, $this-> usuarioAdm);
                $AtualizarNovo->bindParam(3, $this-> senhaAdm);
                $AtualizarNovo->bindParam(4, $this-> idAdm);
                if($AtualizarNovo->execute())
                {
                    if($AtualizarNovo->rowCount() > 0)
                    {
                        $SelecaoNova = $conexao->prepare("SELECT ID_ADM, NOME_ADM, EMAIL_ADM, SENHA_ADM FROM TB_CADASTRO_ADM WHERE EMAIL_ADM=? AND SENHA_ADM=?");
                        $SelecaoNova->bindParam(1, $this-> usuarioAdm);
                        $SelecaoNova->bindParam(2, $this-> senhaAdm);

                        if($SelecaoNova->execute())
                        {
                            if($SelecaoNova->rowCount() > 0)
                            {
                                While ($Linha = $SelecaoNova->fetch(PDO::FETCH_OBJ))
                                {
                                    $idAdm = $Linha->ID_ADM;
                                    $_SESSION['IdAdm'] = $idAdm;

                                    $nomeAdm = $Linha->NOME_ADM;
                                    $_SESSION['nomeAdm'] = $nomeAdm;

                                    $EmailAdm = $Linha->EMAIL_ADM;
                                    $_SESSION['emailAdm'] = $EmailAdm;

                                    $senhaAdm = $Linha->SENHA_ADM;
                                    $_SESSION['senhaAdm'] = $senhaAdm;

                                    $_SESSION['controleAdm'] = "alterado";
                                    header('location:FormAlterarAdm.php');
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                echo "<script> alert('Usuário e/ou senha não confere!')</script>";
                echo "<A href=\"FormAlterarAdm.php\">Retornar</A>";
            }
        }
        catch (PDOExeception $erro)
        {
            echo "Erro" . $erro->getMessage();
        }
    }
}

$alteraAdm->atualizarAdm();

?>