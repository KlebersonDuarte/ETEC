package com.example.variastelas;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

public class Tela03 extends AppCompatActivity {


    //Atributos
    TextView lblTitulo03;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tmnmc);

        //2)Iniciar o elemento
        lblTitulo03 = (TextView) findViewById(R.id.lblTitulo3);

        //3) Intent para receber o valor passado
        Intent it = getIntent();

        //4)Mensagem
        String msg = "Usuário Cadastrado" +
                "\nNome: "+ it.getStringExtra("Valor1") +
                "\nSenha: " + it.getStringExtra("senha") +
                "\nIdade: "+it.getIntExtra("idade",0);

        //5)Mostrando o valor passado
        lblTitulo03.setText(msg);
    }
}