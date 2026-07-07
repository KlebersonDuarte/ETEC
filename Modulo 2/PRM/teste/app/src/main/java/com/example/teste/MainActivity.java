package com.example.teste;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
//Classes

public class MainActivity extends AppCompatActivity {
//1)Atributos
    Button btnEnviar,btnLimpar,btnSair;
    EditText txtNome,txtClasse,txtFundos, txtJuros;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //'Linkando' os elementos com o java
        txtClasse = (EditText) findViewById(R.id.txtClasse);
        txtNome = (EditText) findViewById(R.id.txtNome);
        txtFundos = (EditText) findViewById(R.id.txtFundos);
        btnEnviar = (Button) findViewById(R.id.btnEnviar);
        btnSair = (Button) findViewById(R.id.btnSair);
        btnLimpar = (Button) findViewById(R.id.btnLimpar);
        txtJuros = (EditText) findViewById(R.id.txtJuros);


//3)Criando o evento do botão

        btnEnviar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //4)Recuperando Valores

                String Nome = txtNome.getText().toString();
                String Classe = txtClasse.getText().toString();
                double Juros = Double.parseDouble(
                        txtJuros.getText().toString());
                double Fundos = Double.parseDouble(
                        txtFundos.getText().toString());

                //5)Aumentando o salario do mano em 15%
                double JurosFinal = Juros % 100;
                double ValorFinal = Fundos + (Fundos * JurosFinal);
                String JD = "";
                //6)Variavel para mostrar a msg final
                if(Juros >15){
                     JD = "Aumento Baixo";

                } else if (Juros <6) {
                     JD = "Aumento Moderado";
                }

                else{
                    JD = "Excelente Aumento";
                }

                String msg = "Mago:"+
                        "\nNome:" +Nome+
                        "\nClasse:"+Classe+
                        "\nGolds Antigo:"+ Fundos +
                        "\nGolds Atuais:" + ValorFinal+
                        "\nJuros:" +JD;


            //7)Toast - Notificação

                Toast.makeText(MainActivity.this,
                        msg,
                        Toast.LENGTH_LONG).show();

            }
        });

        //8) Evento do btnLimpar
        btnLimpar.setOnClickListener(new View.OnClickListener() {
    @Override
    public void onClick(View view) {

        //9)Limpar os campos
        txtClasse.setText("");
        txtFundos.setText("");
        txtNome.setText("");


    }
});

        //10)Evento btnFechar
btnSair.setOnClickListener(new View.OnClickListener() {
    @Override
    public void onClick(View view) {
        Toast.makeText(MainActivity.this,
                "Adeus",
                Toast.LENGTH_LONG).show();

   //Finalizar as actives

        finishAffinity();

        //Encerra todos os processos
        System.exit(0);
    }
});

//Evento clique logo btnAumentar
btnEnviar.setOnLongClickListener(new View.OnLongClickListener() {
    @Override
    public boolean onLongClick(View view) {




        //Mensagem de teste

        String Nome = txtNome.getText().toString();
        String Classe = txtClasse.getText().toString();
        double Juros = Double.parseDouble(
                txtJuros.getText().toString());
        double Fundos = Double.parseDouble(
                txtFundos.getText().toString());

        double JurosFinal = Juros % 100;
        double ValorFinal = Fundos + (Fundos * JurosFinal);
        String JD = "";

        if (Nome.isEmpty() || Classe.isEmpty() ||txtFundos.getText().toString().isEmpty() || txtJuros.getText().toString().isEmpty()){

            String msg = "Preencha todos os campos";

            Toast.makeText(MainActivity.this,
                    msg,
                    Toast.LENGTH_LONG).show();
        }

        else {
        if(Juros >15){
            JD = "Desconto Baixo";

        } else if (Juros <6) {
            JD = "Desconto Moderado";
        }

        else{
            JD = "Desconto Excelente";
        }

        String msg = "Mago:"+
                "\nNome:" +Nome+
                "\nClasse:"+Classe+
                "\nGolds Antigo:"+ Fundos +
                "\nGolds Atuais:" + ValorFinal+
                "\nDesconto:" +JD;

        Toast.makeText(MainActivity.this,
                msg,
                Toast.LENGTH_LONG).show();}
        return true;
    }
});
    }


}