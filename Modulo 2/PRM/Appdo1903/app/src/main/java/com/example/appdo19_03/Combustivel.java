package com.example.appdo19_03;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

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

        txtEtanol = (EditText)findViewById(R.id.txtEtanol);
        txtGasolina = (EditText)findViewById(R.id.txtGasolina);
        imgCombustivel = (ImageView) findViewById(R.id.imgCombustivel);
        btnCalcular = (Button) findViewById(R.id.btnCalcular);
        btnSair = (Button) findViewById(R.id.btnSair);
        lblResposta = (TextView) findViewById(R.id.lblResposta);

        btnCalcular.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                double gasolina= Double.parseDouble(txtGasolina.getText().toString());
                double etanol= Double.parseDouble(txtEtanol.getText().toString());

                double valor70= gasolina *0.7;
                if (etanol<=valor70) {
                    lblResposta.setText("O valor do etanol está mais favorável");
                    imgCombustivel.setImageResource(R.drawable.etanol);
                }
                else if(etanol > valor70){
                    lblResposta.setText("O valor da gasolina está mais favorável ");
                    imgCombustivel.setImageResource(R.drawable.gasolina);
                }
                else {
                    lblResposta.setText("Falha do sistema");
                    imgCombustivel.setImageResource(R.drawable.ic_launcher_background);
                }

            }
        });

        btnSair.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
        finishAffinity();
            }
        });
    }

    }
