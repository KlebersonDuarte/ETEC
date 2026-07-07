package com.example.auladodia26_03;

import static android.widget.Toast.LENGTH_LONG;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    //1)Atributos
EditText txtNome,txtSenha,txtRepSenha;
Button btnMenu;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
try {


    //2)'Linkando'
        txtNome = (EditText) findViewById(R.id.txtNome);
        txtSenha = (EditText) findViewById(R.id.txtSenha);
        txtRepSenha = (EditText) findViewById(R.id.txtRepSenha);
        btnMenu = (Button) findViewById(R.id.btnMenu);

        //3)Ao clikar no btnMenu
        btnMenu.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String senha = txtSenha.getText().toString();
                String repSenha = txtRepSenha.getText().toString();
                String nome = txtNome.getText().toString();

                if(!senha.isEmpty() && !nome.isEmpty() && !repSenha.isEmpty()){
                if(senha.equals(repSenha)){
                    Intent menu = new Intent(MainActivity.this,
                            MenuPrincipal.class);
                    menu.putExtra("Nome",nome);
                    startActivity(menu);
                }
                else {
                    Toast.makeText(MainActivity.this,
                            "As senhas tem que ser iguais",
                            LENGTH_LONG).show();
                }}else{
                    Toast.makeText(MainActivity.this,
                            "Preencha todos os campos",
                            LENGTH_LONG).show();
                }

            }
        });}
catch (Exception ex){
    Toast.makeText(MainActivity.this,
            "Falha do sistema",LENGTH_LONG).show();
}
    }
}