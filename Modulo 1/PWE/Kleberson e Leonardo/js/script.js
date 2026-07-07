function fEnviar() 
{
  CodProduto = document.getElementById("CodProduto").value.replace(".","");
  CodProduto = parseInt(CodProduto);
  descricao = document.getElementById("descricao").value;
  quantidade = parseFloat(document.getElementById("qtde").value);
  preco = parseFloat(document.getElementById("valor").value);
  forma = document.querySelector('input[name="pagamento"]:checked');
  forma = forma ? forma.value : "";

produto = "";



  classificacao = Math.floor(CodProduto / 1000);
  sequencia = CodProduto % 1000;

if (classificacao == 10) 
  {
    produto = "Bebida";
  }
else if (classificacao == 20) 
  {
    produto = "Produto de Limpeza";
  }

else
  {
    produto = "Produto Não Cadastrado";
  }

  total = quantidade * preco;
  if (classificacao == 10) 
  {
    total -= total * 0.075;
  }

  if (forma === "pix") 
  {
    total -= total * 0.02;
  }

  if (forma === "prazo") 
  {
    total += total * 0.05;
  }

  saida = 
  "Produto: " + produto + "<br>" +
  "Código: " + (("00"+classificacao).slice(-2) + "." + ("000"+sequencia).slice(-3)) + "<br>" +
  "Descrição: " + descricao + "<br>" +
  "Classificação: " + classificacao + " | Seq: " + sequencia + "<br>" +
  "Quantidade: " + quantidade + "<br>" +
  "Preço Unitário: R$ " + preco.toFixed(2) + "<br>" +
  "Forma de Pagamento: " + forma + "<br>" +
  "Total a Pagar: R$ " + total.toFixed(2);

  document.getElementById("resultado").innerHTML = saida;
}
    
function mascaraCodProduto(e) 
{
  v = e.value.replace(/\D/g, "");
  if (v.length > 2) e.value = v.slice(0,2) + "." + v.slice(2,5);
  else e.value = v;
}