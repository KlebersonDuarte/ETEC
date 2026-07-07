package com.example.app_14_05_26;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import java.time.Instant;
import java.util.ArrayList;

public class GestaoOrcamento extends AppCompatActivity {
    double resultado = 0;
    ListView ltvLista;

    TextView lblAcumulador;
    Button btnVoltar,btnLimpar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_gestao_orcamento);


        ltvLista = (ListView) findViewById(R.id.ltvLista);
        lblAcumulador = (TextView) findViewById(R.id.lblAcumulador);
        btnVoltar = (Button) findViewById(R.id.btnVoltar);
        btnLimpar = (Button) findViewById(R.id.btnLimpar);

        ArrayAdapter<clsProdutos> adapter = new ArrayAdapter<>(GestaoOrcamento.this,
                android.R.layout.simple_list_item_1,
                MainActivity.Listaprodutos);//Adaptando a lista da classe para poder mostrar para o
        //usuário

        ltvLista.setAdapter(adapter);//Mostrando a lista

        ltvLista.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                double somar = MainActivity.Listaprodutos.get(i).getValor();

                resultado += somar;

                lblAcumulador.setText(String.valueOf(resultado));
            }
        });

        ltvLista.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
                double sub = MainActivity.Listaprodutos.get(i).getValor();

                resultado -= sub;
                lblAcumulador.setText(String.valueOf(resultado));

                return true;
            }
        });

        btnVoltar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent voltar = new Intent(GestaoOrcamento.this,
                        MainActivity.class);
                startActivity(voltar);
            }
        });

        btnLimpar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                lblAcumulador.setText("0");
            }
        });

        //Kleberson Duarte Santos
        //Leonardo de Oliveira Duarte
    }
}