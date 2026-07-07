<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Venda</title>
</head>
<body>
  <form action="estoque.php" method="get">
    <label for="CodProduto">CodProduto</label>
    <input type="number" id="CodProduto" maxlength="6" placeholder="00.000" name="CodProduto"><br>

    <label for="descricao">Descrição</label>
    <input type="text" id="descricao" name="descricao"><br>

    <label for="valor">Valor</label>
    <input type="number" id="valor" name="valor">

    <label for="qtde">Quantidade</label>
    <input type="number" id="qtde" name="qtde"><br>

    <label for="pagamento">Forma de Pagamento</label><br>
    <input type="radio" name="pagamento" value="pix"> Pix
    <input type="radio" name="pagamento" value="prazo"> Parcelado<br><br>

    <input type="submit" value="Enviar">
    <input type="reset" value="Limpar"><br>
  </form>


</body>
</html>