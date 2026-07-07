package com.example.appdo19_03;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    //1)Atributos
    Button btnCombustiveis,btnCadastrar,btnVizualizar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //2)"Linkando"
        btnCadastrar = (Button) findViewById(R.id.btnCadastro);
        btnVizualizar = (Button) findViewById(R.id.btnVizualizar);
        btnCombustiveis = (Button) findViewById(R.id.btnCombustiveis);

        //3)Botão Combustiveis
        btnCombustiveis.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent Comb =new Intent(MainActivity.this,
                        Combustivel.class);
                startActivity(Comb);
            }
        });

        //4)Botão Vizualizar
        btnVizualizar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent Vizualizar = new Intent(MainActivity.this,
                        Vizualizar.class);
                startActivity(Vizualizar);
            }
        });

        //5)Botão Cadastrar
        btnCadastrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent Cadast = new Intent(MainActivity.this,
                        Cadastrar.class);
                startActivity(Cadast);
            }
        });
    }
}