package com.example.atividadecomvriastelas;

import static android.widget.Toast.LENGTH_LONG;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

public class Cadastrar extends AppCompatActivity {
//1)Atributos
    Button btnSairCadastro,btnCadastrar;
    EditText txtNumero;
    ListView ltvNumeros;

    ArrayList<String> listaNumeros;
    ArrayAdapter<String> adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadastrar);
try{
        //2)'Linkando'
        btnCadastrar = (Button) findViewById(R.id.btnCadastrar);
        btnSairCadastro = (Button) findViewById(R.id.btnSairCadastro);
        txtNumero = (EditText) findViewById(R.id.txtNumero);
        ltvNumeros = (ListView) findViewById(R.id.ltvNumeros);

        listaNumeros = new ArrayList<>();

        adapter = new ArrayAdapter<>(
                this,
                android.R.layout.simple_list_item_1,
                listaNumeros
        );

        ltvNumeros.setAdapter(adapter);

        //3)Ação ao clicar no btnCadastrar
        btnCadastrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String numero = txtNumero.getText().toString();
                if(!numero.isEmpty()) {
                    listaNumeros.add(numero); // adiciona na lista
                    adapter.notifyDataSetChanged(); // atualiza a tela
                }
                else{
                    Toast.makeText(Cadastrar.this,
                            "por favor insira o numero de telefone",
                            LENGTH_LONG).show();
                }
            }
        });

        //4)Ao clicar no numero da lista telefonica
        ltvNumeros.setOnItemClickListener((parent, view, position, id) -> {
            String numero = listaNumeros.get(position);

            Intent intent = new Intent(Intent.ACTION_DIAL);
            intent.setData(android.net.Uri.parse("tel:" + numero));

            startActivity(intent);
        });
        //5)btnSairCadastro
        btnSairCadastro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finishAffinity();
            }
        });} catch (Exception ex) {
    Toast.makeText(Cadastrar.this,
            "Falha do sistema",LENGTH_LONG).show();
}
    }
}