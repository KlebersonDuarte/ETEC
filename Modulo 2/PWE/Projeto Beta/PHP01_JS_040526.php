<?php
 $minha_variavel_php = "olá do servidor";  
?>

  <script>
      var minha_variavel_js = "<?php echo $minha_variavel_php; ?>";
     document.write (minha_variavel_js);
  </script>
