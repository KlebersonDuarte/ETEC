 package com.example.atividade21;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

 public class MainActivity extends AppCompatActivity {

    //Atributos
    EditText txtNome,txtSenha;
    Button btnLimpar,btnEnviar;
    int erros =0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    btnEnviar = (Button) findViewById(R.id.btnEnviar);
    btnLimpar = (Button) findViewById(R.id.btnLimpar);
    txtNome = (EditText) findViewById(R.id.txtNome);
    txtSenha = (EditText) findViewById(R.id.txtSenha);

    btnEnviar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            String nome = txtNome.getText().toString();
            String senhaVer = txtSenha.getText().toString();
            if (nome.isEmpty() || senhaVer.isEmpty()) {
                Toast.makeText(MainActivity.this,
                        "Preencha todos os campos",
                        Toast.LENGTH_LONG
                ).show();
                return;
            }

            int senha = Integer.parseInt(txtSenha.getText().toString());
            if(erros != 3){
            if (!nome.equals("admin") && !senhaVer.equals("123")) {
                erros++;
                Toast.makeText(MainActivity.this,
                        "Nome e senha incorreta",
                        Toast.LENGTH_LONG
                ).show();
                return;
            } else if (!nome.equals("admin")) {
                erros++;
                Toast.makeText(MainActivity.this,
                        "Nome de usuário incorreto",
                        Toast.LENGTH_LONG
                ).show();
                return;
            } else if (!senhaVer.equals("123")) {
                erros++;
                Toast.makeText(MainActivity.this,
                        "Senha está incorreta",
                        Toast.LENGTH_LONG
                ).show();
                return;
            } else {
                Intent menu = new Intent(MainActivity.this,
                       menu.class);
                menu.putExtra("nome",nome);
                startActivity(menu);
            }}
            else{
                Toast.makeText(MainActivity.this,
                        "Acesso bloqueado temporariamente",
                        Toast.LENGTH_LONG).show();
                erros = 0;
            }
        }
        });

    btnLimpar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            txtNome.setText("");
            txtSenha.setText("");
        }
    });
    }
}