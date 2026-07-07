package com.example.aula_09_04_26;

import static android.widget.Toast.LENGTH_LONG;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import java.util.Random;
import java.text.DecimalFormat;
import java.math.RoundingMode;

public class desafioMat extends AppCompatActivity {
    TextView lblQuestao, lblResultadoFinalMat,lblResposta,lblPontosMat;
    EditText txtResposta;
    Button btnRespostaMat;
    int pontos = 0;
    int contador = 0;
    int resultado = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_desafio_mat);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        lblQuestao = (TextView) findViewById(R.id.lblQuestao);
        lblResultadoFinalMat = (TextView) findViewById(R.id.lblResultadoFinalMat);
        txtResposta = (EditText) findViewById(R.id.txtResposta);
        btnRespostaMat = (Button) findViewById(R.id.btnRespostaMat);
        lblResposta = (TextView) findViewById(R.id.lblResposta);
        lblPontosMat = (TextView) findViewById(R.id.lblPontosMat);

//Usar um for
        //numeros de 1 a 10
        Random gerador = new Random();
        int num1 = gerador.nextInt(10) +1;
        int num2 = gerador.nextInt(10) +1;

        //Operações
        //0 a 4
        int operacao = gerador.nextInt(5);

        String simb = "";

        switch (operacao){
            case 0:
                simb = "+";
                resultado = num1 + num2;
                break;
            case 1:
                simb = "-";
                resultado = num1 - num2;
                break;
            case 3:
                simb = "*";
                resultado = num1 * num2;
                break;
            case 4:
                simb = "/";
                resultado = num1 / num2;
                break;
            default:
                Toast.makeText(desafioMat.this,
                        "Falha do sistema",
                        LENGTH_LONG).show();
                break;
        }
        String num1STR = String.valueOf(num1);
        String num2STR = String.valueOf(num2);
        lblQuestao.setText(num1STR+ simb + num2STR);


            btnRespostaMat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
            double resposta = Double.parseDouble(txtResposta.getText().toString());

                if (resultado == resposta){
                    pontos++;
                    lblPontosMat.setText(String.valueOf(pontos));
                    lblResposta.setText("Você acertou");
                }
                else{
                    lblResposta.setText("Você errou a resposta correta é " +String.valueOf(resultado));
                    lblPontosMat.setText(String.valueOf(pontos));
                }

                //numeros de 1 a 10
                Random gerador = new Random();
                int num1 = gerador.nextInt(10) +1;
                int num2 = gerador.nextInt(10) +1;


                //Operações
                //0 a 3
                int operacao = gerador.nextInt(4);

                String simb = "";

                switch (operacao){
                    case 0:
                        simb = "+";
                        resultado = num1 + num2;
                        break;
                    case 1:
                        simb = "-";
                        resultado = num1 - num2;
                        break;
                    case 2:
                        simb = "*";
                        resultado = num1 * num2;
                        break;
                    case 3:
                        simb = "/";
                        resultado =  num1 / num2;
                        break;
                    default:
                        Toast.makeText(desafioMat.this,
                                "Falha do sistema",
                                LENGTH_LONG).show();
                        break;
                }
                contador++;
                lblQuestao.setText(num1 + simb + num2);



                if(contador == 5){

                    if(pontos <=2){
                        lblResultadoFinalMat.setText("Precisa estudar");
                        lblResultadoFinalMat.setTextColor(Color.RED);
                    }
                    else if(pontos <=4){
                        lblResultadoFinalMat.setText("Tá indo bem");
                        lblResultadoFinalMat.setTextColor(Color.MAGENTA);
                    }
                    else{
                        lblResultadoFinalMat.setText("Muito bom");
                        lblResultadoFinalMat.setTextColor(Color.GREEN);
                    }
                    pontos = 0;
                    contador = 0;
                }


                 if(contador == 1){

                    lblResposta.setText("...");
                    lblResultadoFinalMat.setText("...");
                    lblResultadoFinalMat.setTextColor(Color.BLACK);
                }



            }
        });
    }
}