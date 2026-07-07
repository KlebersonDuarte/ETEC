package com.example.app_14_05_26;

import static android.widget.Toast.LENGTH_LONG;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {


    EditText txtNome, txtDescricao, txtValor;
    Button btnCadastrar,btnGestao;
    public static ArrayList<clsProdutos> Listaprodutos = new ArrayList<>(); //Instanciando uma classe
    //em forma de lista para puxar as informações da classe para a lista do usuário
    double resultado = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtNome = (EditText) findViewById(R.id.txtNome);
        txtDescricao = (EditText) findViewById(R.id.txtDescricao);
        txtValor = (EditText) findViewById(R.id.txtValor);
        btnCadastrar = (Button) findViewById(R.id.btnCadastrar);
        btnGestao = (Button) findViewById(R.id.btnGestao);

    btnCadastrar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            try {
                String nome = txtNome.getText().toString();
                String desc = txtDescricao.getText().toString();


                if(nome.equals("") ||desc.equals("") || txtValor.getText().toString().equals("")){
                    Toast.makeText(MainActivity.this,
                            "Preencha todos os campos",
                            LENGTH_LONG).show();
                    return;
                }
                Double valor = Double.parseDouble(txtValor.getText().toString());

                if(valor <= 0){
                    Toast.makeText(MainActivity.this,
                            "O valor não pode ser menor ou igual a zero!",
                            LENGTH_LONG).show();
                    return;
                }

                clsProdutos prod = new clsProdutos(nome,desc,valor); //Criando o objeto e passando os
                //atribustos

                Listaprodutos.add(prod);

                txtNome.setText("");
                txtValor.setText("");
                txtDescricao.setText("");


            }catch (Exception Error){
                Toast.makeText(MainActivity.this,
                        "Falha do sistema " + Error,
                        LENGTH_LONG).show();
            }
        }
    });

    btnGestao.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            try{
            Intent pag = new Intent(MainActivity.this,
                    GestaoOrcamento.class);
            startActivity(pag);
        }catch (Exception error){
                Toast.makeText(MainActivity.this,
                "Error: " + error,
                        LENGTH_LONG).show();
            }
        }
    });

        //Kleberson Duarte Santos
        //Leonardo de Oliveira Duarte
    }
}
