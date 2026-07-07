package com.example.variastelas;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.time.LocalDate;
import java.time.Year;
import java.util.Date;


public class Tela02 extends AppCompatActivity {
    //1)Atributo
    EditText txtNome, txtSenha, txtConfSenha,dtaNascimento;
    Button btnCadastrar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela02);
        //2)Iniciando os elementos

        txtNome = (EditText) findViewById(R.id.txtNome);
        txtConfSenha = (EditText) findViewById(R.id.txtConfSenha);
        txtSenha = (EditText) findViewById(R.id.txtSenha);
        btnCadastrar = (Button) findViewById(R.id.btnCadastrar);
        dtaNascimento = (EditText) findViewById(R.id.dtaNascimento);


        //3)Evento do btnCadastrar
        btnCadastrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Recuperando os valores
                String nome = txtNome.getText().toString();
                String senha = txtSenha.getText().toString();
                String confSenha = txtConfSenha.getText().toString();
                int  niver= Integer.parseInt(dtaNascimento.getText().toString());

                if(niver > 18){
                //Verificando as senhas e o conf senha
                if (senha.equals(confSenha)){
                    //Acessar  a próxima página!!!
                    Intent it = new Intent(Tela02.this,
                            Tela03.class);


                    //Passando os valores as outra tela
                    it.putExtra("Valor1",nome);
                    it.putExtra("idade",niver);
                    it.putExtra("senha",senha);
                            //Iniciando
                    startActivity(it);
                }
                else {
                    //Mensagem de erro e fecha o App
                    Toast.makeText(Tela02.this,
                            "Senhas não conferem",
                            Toast.LENGTH_LONG).show();
                }}
                else {
                    Toast.makeText(Tela02.this,
                            "Você precisa ter mais de 18 anos",
                            Toast.LENGTH_LONG).show();
                }
            }
        });
    }
}