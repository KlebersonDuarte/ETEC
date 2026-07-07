package com.example.teste2;

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

                //6)Variavel para mostrar a msg final
                if(Juros >15){
                    
                    
                } else if (Juros ) {
                    
                }

                String msg = "Mago:"+
                        "\nNome:" +Nome+
                        "\nClasse:"+Classe+
                        "\nGolds Antigo:"+ Fundos +
                        "\nGolds Atuais:" + ValorFinal;


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
        double Juros = Double.parseDouble(
                txtJuros.getText().toString());
        double Fundos = Double.parseDouble(
                txtFundos.getText().toString());

        double JurosFinal = Juros % 100;
        double ValorFinal =  (Fundos * JurosFinal)- Fundos ;

        String msg ="Desconto:" + ValorFinal;

        Toast.makeText(MainActivity.this,
                msg,
                Toast.LENGTH_LONG).show();
        return true;
    }
});
    }


}