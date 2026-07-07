package com.example.variastelas;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {
    //1)Atributos
    Button btnEntrar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //2)Iniciando componentes
        btnEntrar = (Button) findViewById(R.id.btnEntrar);

        //3)Evento do btnEntrar
        btnEntrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                /*   :::INTENT
                Classe responsável pela manipulação
                das activites... permite uma
                'ligação' entre elas, além de passagem
                de valores!!!
                :)S2
                */

                //Insticiando a classe Intent
                Intent it = new Intent(MainActivity.this,
                        Tela02.class);

            //Abrindo a tela
                startActivity(it);
            }
        });
    }
}