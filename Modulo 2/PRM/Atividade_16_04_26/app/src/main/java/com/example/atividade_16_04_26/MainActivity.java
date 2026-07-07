package com.example.atividade_16_04_26;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
//1) Atributos
    EditText txtNome, txtIdade;
    Button btnEntrar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //2)'Linkando' os atributos com o layout
        txtIdade = (EditText) findViewById(R.id.txtIdade);
        txtNome = (EditText) findViewById(R.id.txtNome);
        btnEntrar = (Button) findViewById(R.id.btnEnviar);

    btnEntrar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            //Resuperar os valores
            String nome = txtNome.getText().toString();
            int idade = Integer.parseInt(txtIdade.getText().toString());

            ////campos vazios? aqui não irmão
            if(nome.isEmpty()){
                Toast.makeText(MainActivity.this,
                        "Digite o nome, OTÁRIO",
                        Toast.LENGTH_LONG).show();
                return;
            }
            if(idade == 0){
                Toast.makeText(MainActivity.this,
                        "Digite a idade, OTÁRIO",
                        Toast.LENGTH_LONG).show();
                return;
            }

            if(idade >= 10){
                Intent tela = new Intent(MainActivity.this,
                       Menu.class );

                tela.putExtra("ValorNome",nome);
                tela.putExtra("ValorIdade",idade);

                //Inicio a outra Activity
                startActivity(tela);
            }
            else{
                Toast.makeText(MainActivity.this,
                        "Menor de idade, OTÁRIO",
                        Toast.LENGTH_LONG).show();
                return;
            }
        }
    });
    }
}