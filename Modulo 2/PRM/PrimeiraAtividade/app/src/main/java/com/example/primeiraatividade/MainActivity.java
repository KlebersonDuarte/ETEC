package com.example.primeiraatividade;

import static android.widget.Toast.LENGTH_LONG;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.ls.LSParserFilter;

public class MainActivity extends AppCompatActivity {


    //Atributos
    Button btnDesconto, btnAumento;
    EditText txtValor, txtPorcentagem;

    TextView lblResposta;
    double numero,porcentagem,valor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
//Linkando eles
        btnDesconto = (Button) findViewById(R.id.btnDesconto);

        btnAumento = (Button) findViewById(R.id.btnAumento);

        txtValor = (EditText) findViewById(R.id.txtValor);

        txtPorcentagem = (EditText) findViewById(R.id.txtPorcentagem);

        lblResposta = (TextView) findViewById(R.id.lblResposta);




        //Aumento
    btnAumento.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            if(txtPorcentagem.getText().toString().isEmpty() || txtValor.getText().toString().isEmpty()){
                Toast.makeText(MainActivity.this,
                        "Por Favor preecha todos os campos",
                        LENGTH_LONG).show();
            }else{
            //Pegando o valor deles e convertendo pra Double
            porcentagem =  Double.parseDouble(txtPorcentagem.getText().toString());
            valor = Double.parseDouble(  txtValor.getText().toString());
            numero = valor * (porcentagem/ 100 +1);

            //Mensagem
             lblResposta.setText("O valor final com o aumento:" + numero);
        }}
    });

//Desconto
    btnDesconto.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View v) {

            if(txtPorcentagem.getText().toString().isEmpty() || txtValor.getText().toString().isEmpty()){
                Toast.makeText(MainActivity.this,
                        "Por Favor preecha todos os campos",
                        LENGTH_LONG).show();
            }else {
                porcentagem =  Double.parseDouble(txtPorcentagem.getText().toString());
                valor = Double.parseDouble(  txtValor.getText().toString());
                numero = valor * (porcentagem/ 100);
                valor -= numero;
                //Mensagem
                lblResposta.setText("O valor final com o desconto:" + valor);

            }
        }
    });
//Segurando os botões


//Desconto
btnDesconto.setOnLongClickListener(new View.OnLongClickListener() {
    @Override
    public boolean onLongClick(View v) {
        if(txtPorcentagem.getText().toString().isEmpty() || txtValor.getText().toString().isEmpty()){
            Toast.makeText(MainActivity.this,
                    "Por Favor preecha todos os campos",
                    LENGTH_LONG).show();
        }else {
            numero = valor * (porcentagem / 100);
            Toast.makeText(MainActivity.this,
                    "Desconto de: " + numero + '%',
                    LENGTH_LONG).show();
        }

        return true;
    }
});


        //Aumento
btnAumento.setOnLongClickListener(new View.OnLongClickListener() {
    @Override
    public boolean onLongClick(View v) {

        if(txtPorcentagem.getText().toString().isEmpty() || txtValor.getText().toString().isEmpty()){
            Toast.makeText(MainActivity.this,
                    "Por Favor preecha todos os campos",
                    LENGTH_LONG).show();
        }else {
            porcentagem = Double.parseDouble(txtPorcentagem.getText().toString());
            valor = Double.parseDouble(txtValor.getText().toString());
            numero = valor * (porcentagem / 100);
            Toast.makeText(MainActivity.this,
                    "Aumento de: " + numero + '%',
                    LENGTH_LONG).show();
        }

        return true;
    }
});


    }
}