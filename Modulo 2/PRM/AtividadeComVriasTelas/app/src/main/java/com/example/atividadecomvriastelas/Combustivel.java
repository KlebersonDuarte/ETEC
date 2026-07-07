package com.example.atividadecomvriastelas;

import static android.widget.Toast.LENGTH_LONG;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class Combustivel extends AppCompatActivity {

        //1)Atributos
    EditText txtGasolina,txtEtanol;
    Button btnCalcular, btnSair;
    ImageView imgCombustivel;
    TextView lblResposta;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_combustivel);
try {


        txtEtanol = (EditText)findViewById(R.id.txtEtanol);
        txtGasolina = (EditText)findViewById(R.id.txtGasolina);
        imgCombustivel = (ImageView) findViewById(R.id.imgCombustivel);
        btnCalcular = (Button) findViewById(R.id.btnCalcular);
        btnSair = (Button) findViewById(R.id.btnSairCombustivel);
        lblResposta = (TextView) findViewById(R.id.lblResposta);

        btnCalcular.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                double gasolina= Double.parseDouble(txtGasolina.getText().toString());
                double etanol= Double.parseDouble(txtEtanol.getText().toString());

                double valor70= gasolina *0.7;
    if(txtGasolina.getText().toString().isEmpty() &&
            txtEtanol.getText().toString().isEmpty()){
                if (etanol<=valor70) {
                    lblResposta.setText("O valor do etanol está mais favorável");
                    imgCombustivel.setImageResource(R.drawable.etanol);
                }
                else if(etanol > valor70){
                    lblResposta.setText("O valor da gasolina está mais favorável ");
                    imgCombustivel.setImageResource(R.drawable.gasolina);
                }
                else if (txtEtanol.getText().toString().isEmpty() || txtGasolina.getText().toString().isEmpty()) {
                Toast.makeText(Combustivel.this,
                        "Preencha todos os campos",
                        LENGTH_LONG).show();
                } else {
                    lblResposta.setText("Falha do sistema");
                    imgCombustivel.setImageResource(R.drawable.ic_launcher_background);
                }}
    else {
        Toast.makeText(Combustivel.this,
                "Preencha todos os campos",
                LENGTH_LONG).show();
    }

            }
        });

        btnSair.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
        finishAffinity();
            }
        });}
catch(Exception ex) {
    Toast.makeText(Combustivel.this,
            "Erro Fatal",
            LENGTH_LONG).show();
        }
    }

    }
