<html>
<title>Fale Conosco - Contato </title>
<body>

<form name="form1" action="AddContato.php" method="get">
 
 <label for="Nome">Nome:</label>
 <input type="text" name="Nome" size="35"><BR><p>

 <label for="Email">E-mail:</label>
 <input type="text" name="Email" placeholder="email@servidor.com" size="35"><BR><p>

 <label for="Fone">Telefone:</label>
 <input type="text" name="Fone" placeholder="(00) 0-0000-0000" size="35"><BR><p>
 <label for="Assunto">Assunto:</label>
	<select name="Assunto" id="Assunto">
			<option default value="Selecione">Selecione o assunto!</option>
            <option value="Duvidas">Duvidas</option>
            <option value="Elogios">Elogios</option>
            <option value="Reclamações">Reclamações</option>
            <option value="Sugestões">Sugestões</option>
    </select> <br><p>
    <label for="Mensagem">Mensagem:</label><BR><p>
	<textarea name="Mensagem" rows="8" cols="40"></textarea><br><p>
	
	<input type="submit" name="Enviar" value="Enviar">
	
	<input type="reset" name="Limpar" value="Redefinir"><br><p>
	</p>
	
	<label id="aviso">Preenchar os campos, para enviar!<br>	
 
 
 </p>
</form>

</body>
</html>

