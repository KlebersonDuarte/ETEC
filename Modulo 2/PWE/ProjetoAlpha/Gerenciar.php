<?php
        session_start();
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gerenciar</title>
</head>

<body>
    <form action="Gerenciar.php?alterar=alterando" method="post">
        <label for="Nome">Nome:</label>
        <input type="text" name="nome" placeholder="Nome" value="<?php 
        echo $_SESSION['nome'];
        ?>"><br><br>

        <label for="Email">Email:</label>
        <input type="text" name="email" placeholder="Email" value="<?php 
         echo $_SESSION['email']
         ?>">

        <input type="submit" name="Alterar" value="Alterar">
    </form>

    <h2>Pedidos do Usuário</h2>
    <table border="1">
        <tr>
            <th>Nome Pedido</th>
            <th>Banco Pedido</th>
            <th>Conta Pedido</th>
            <th>Taxa Pedido</th>
            <th>Meses Pedidos</th>
            <th>Capital Pedido</th>
            <th>Rendimento Pedido</th>
            <th>Total Pedido</th>
        </tr>

        <?php

    //Puxando os dados

        include 'conexao.php';

            $idUsuario = $_SESSION['id_usuario'];
            $idPedido = $_SESSION['ID_PEDIDO'];
            

            //Verificando se o form enviou algo e qual botão foi clicado
        if (isset($_REQUEST['alterar']) && ($_REQUEST['alterar'] == "alterando")) {
        if((isset($_POST['Alterar']) && isset($_POST['Alterar']) == 'Alterar')){
        
           

            //Caso os campos estegam vazios
            if($_POST['nome'] == "" || $_POST['email'] == ""){
                 echo "<script> alert('Preencha os campos para serem alterados')</script>";  
                 return;     

            }

            $nome = $_POST['nome'];
            $email = $_POST['email'];
        
            if($nome != $_SESSION['nome'] && $email != $_SESSION['email']){
            //Lógica de atualização
            $stmt = $conexao->prepare("UPDATE TB_PEDIDO SET NOME_PEDIDO = ? WHERE ID_PEDIDO = ?");
            $stmt->bindParam(1,$nome);
            $stmt->bindParam(2,$idPedido);
            if($stmt->execute()){

           if($stmt->rowCount() >0){
            $stmt = $conexao->prepare("UPDATE TB_USUARIO SET EMAIL_USUARIO = ? WHERE ID_USUARIO = ?");
            $stmt->bindParam(1,$email);
            $stmt->bindParam(2,$idUsuario);

            if($stmt->execute()){
                if($stmt->rowCount() > 0){
                        echo "<script> alert('Nome e email alterado com sucesso!')</script>";
                        echo ("<meta http-equiv='refresh'content=0;'Gerenciar.php'>");       
                        return;
                        }
                    }
                    }
            }}
   
            else if($nome == $_SESSION['nome'] && $email != $_SESSION['email']){
            $stmt = $conexao->prepare("UPDATE TB_USUARIO SET EMAIL_USUARIO = ? WHERE ID_USUARIO = ?");
            $stmt->bindParam(1,$email);
            $stmt->bindParam(2,$idUsuario);

            if($stmt->execute()){
                if($stmt->rowCount() > 0){
                        echo "<script> alert('Email alterado com sucesso!')</script>";
                        echo ("<meta http-equiv='refresh'content=0;'Gerenciar.php'>");       
                        return;
                        }
                    }
            }
            else if($nome != $_SESSION['nome'] && $email == $_SESSION['email']){
             $stmt = $conexao->prepare("UPDATE TB_PEDIDO SET NOME_PEDIDO = ? WHERE ID_PEDIDO = ?");
            $stmt->bindParam(1,$nome);
            $stmt->bindParam(2,$idPedido);
            if($stmt->execute()){

           if($stmt->rowCount() >0){
            echo "<script> alert('Nome alterado com sucesso!')</script>";
                        echo ("<meta http-equiv='refresh'content=0;'Gerenciar.php'>");       
                        return;
           }}}

        }
    }

        //Caso alguém tente entrar aqui sem passar pelas páginas anteriores
       if(empty($idUsuario)){
                echo "<script> alert('Por favor faça o login ou cadastro para acessar essa página')</script>";
                echo ("<meta http-equiv='refresh'content=0;'Login.php'>");
                return;
            }

            //Lógica da tabela
        $stmt = $conexao->prepare("SELECT NOME_PEDIDO, BANCO_PEDIDO, CONTA_PEDIDO, TAXA_PEDIDO, 
                        MESES_PEDIDO, CAPITAL_PEDIDO, RENDIMENTO_PEDIDO, TOTAL_PEDIDO 
                        FROM tb_pedido 
                        WHERE ID_USUARIO = ?");
        $stmt->execute([$idUsuario]);
        ?>

        <?php while ($linha = $stmt->fetch(PDO::FETCH_ASSOC)) { ?>

        <tr>
            <td><?php echo $linha['NOME_PEDIDO']; ?></td>
            <td><?php echo $linha['BANCO_PEDIDO']; ?></td>
            <td><?php echo $linha['CONTA_PEDIDO']; ?></td>
            <td><?php echo $linha['TAXA_PEDIDO']; ?></td>
            <td><?php echo $linha['MESES_PEDIDO']; ?></td>
            <td><?php echo $linha['CAPITAL_PEDIDO']; ?></td>
            <td><?php echo $linha['RENDIMENTO_PEDIDO']; ?></td>
            <td><?php echo $linha['TOTAL_PEDIDO']; ?></td>
        </tr>
        <?php } 
        



        ?>
        
    </table>
</body>

</html>