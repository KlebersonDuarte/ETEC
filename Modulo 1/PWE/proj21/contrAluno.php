<?php
$method = $_SERVER['REQUEST_METHOD'];

switch ($method) {
  case 'POST':
    $json_string = file_get_contents("php://input");
    $data = json_decode($json_string);
    $acao = $data->acao ?? 'desconhecida';

    if ($acao === 'gravar') {
      // --- Lógica de Gravação ---
      // Exemplo: $nome = $data->nome;
      // chamada de método para gravar() / insert no BD...

      echo json_encode(['Resposta' => true, 'msg' => 'Dados Gravados com Sucesso!']);

          } elseif ($acao === 'calcular') {
      // --- Lógica de Cálculo ---
      $Nota1 = $data->Nota1;
      $Nota2 = $data->Nota2;
      $Nota3 = $data->Nota3;

      $Media = ($Nota1 + $Nota2 + $Nota3) / 3;

      if ($Media >= 0 && $Media <= 6.99) {
        $Resultado = "Reprovado";
      } else {
        $Resultado = "Aprovado";
      }

      echo json_encode([
        'Resposta' => true,
        'media' => $Media,
        'Resultado' => $Resultado
      ]);

          } else {
      echo json_encode(['Resposta' => false, 'msg' => 'Ação não reconhecida no servidor.']);
    }
    break;

  case 'GET':
    echo json_encode(['Resposta' => false, 'msg' => 'Método GET não suportado para esta operação.']);
    break;

  default:
    echo json_encode(['Resposta' => false, 'msg' => 'Método não permitido.']);
    break;
}

