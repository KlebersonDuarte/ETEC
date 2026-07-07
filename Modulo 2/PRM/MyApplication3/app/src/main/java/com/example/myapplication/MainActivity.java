package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.SeekBar;
import android.widget.Switch;
import android.widget.TextView;

import javax.accessibility.AccessibleEditableText;

public class MainActivity extends AppCompatActivity {
    //!) Atributos

    EditText txtFunc, txtNome, txtSalario;
    TextView valor;
    SeekBar barraAumento;
    Switch swAumentinho;
    Button btnTestar;


//Atributo para salvar o valor da seekbar
    int valorBarrinha;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //2) Iniciando os elementos
        txtFunc = (EditText) findViewById(R.id.txtFunc);
        txtNome = (EditText) findViewById(R.id.txtNome);
        txtSalario = (EditText) findViewById(R.id.txtSalario);
        valor = (TextView) findViewById(R.id.valor);
        barraAumento = (SeekBar) findViewById(R.id.barraAumento);
        swAumentinho = (Switch) findViewById(R.id.swAumentinho);
        btnTestar = (Button) findViewById(R.id.btnTestar);
        txtFunc = (EditText) findViewById(R.id.txtFunc);
        txtFunc = (EditText) findViewById(R.id.txtFunc);

//Configurando o SeekBar para ficar inativa
        barraAumento.setEnabled(false);
        barraAumento.setMax(80);
        barraAumento.setMin(10);

//3) Evento do seekbar

        barraAumento.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progresso, boolean b) {
    valorBarrinha = progresso;
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {
//Atualizar o valor do texto
                valor.setText(valorBarrinha + "%");
            }
        });

        //4) Evento do Switch
        swAumentinho.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
                barraAumento.setEnabled(true);
            }
        });

        //5)Evento do Botão
        btnTestar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Recuperando os valores do EditTexts
                String Nome = txtNome.getText().toString();
                String Func = txtFunc.getText().toString();
                String Salario = txtSalario.getText().toString();

                //Fazendo a continha!!!
                
            }
        });

    }
}