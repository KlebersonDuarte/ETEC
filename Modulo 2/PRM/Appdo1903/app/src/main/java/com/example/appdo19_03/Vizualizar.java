package com.example.appdo19_03;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

public class Vizualizar extends AppCompatActivity {
 //1) Atributos
    Button btnVoltar, btnAvancar,btnSair;
    ImageView imgTuristico;
    String nomeFoto = "";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_vizualizar);

        //2)  'Linkando' os elementos do layout com a programação
        btnAvancar = (Button) findViewById(R.id.btnAvancar);
        btnVoltar = (Button) findViewById(R.id.btnVoltar);
        imgTuristico = (ImageView) findViewById(R.id.imgTuristico);
        btnSair = (Button) findViewById(R.id.btnSair2);

        // 3) Evento btnDireita
        btnAvancar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                if(nomeFoto.equals(""))
                {
                    imgTuristico.setImageResource(R.drawable.cristo);
                    nomeFoto = "cristo";
                }
                else if(nomeFoto.equals("cristo"))
                {
                    imgTuristico.setImageResource(R.drawable.torre);
                    nomeFoto = "torre eiffel";
                }
                else if(nomeFoto.equals("torre eiffel"))
                {
                    imgTuristico.setImageResource(R.drawable.muralha);
                    nomeFoto = "muralha da China";
                }
                else if(nomeFoto.equals("muralha da China"))
                {
                    imgTuristico.setImageResource(R.drawable.pisa);
                    nomeFoto = "torre pisa";
                }
                else if(nomeFoto.equals("torre pisa")){
                    imgTuristico.setImageResource(R.drawable.coliseu);
                    nomeFoto = "coliseu";
                }
                else if(nomeFoto.equals("coliseu")){
                    imgTuristico.setImageResource(R.drawable.ic_launcher_foreground);
                    nomeFoto = "";

                }
                else{
                    imgTuristico.setImageResource(R.drawable.ic_launcher_foreground);
                    nomeFoto = "";
                    Toast.makeText(Vizualizar.this,
                            "Falha do Sistema",
                            Toast.LENGTH_LONG);

                }






            }
        });

        //5) Evento btnEsquerda
        btnVoltar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                if(nomeFoto.equals(""))
                {
                    imgTuristico.setImageResource(R.drawable.cristo);
                    nomeFoto = "cristo";
                }
                else if(nomeFoto.equals("cristo"))
                {
                    imgTuristico.setImageResource(R.drawable.torre);
                    nomeFoto = "torre eiffel";
                }
                else if(nomeFoto.equals("torre eiffel"))
                {
                    imgTuristico.setImageResource(R.drawable.muralha);
                    nomeFoto = "muralha da China";
                }
                else if(nomeFoto.equals("muralha da China"))
                {
                    imgTuristico.setImageResource(R.drawable.pisa);
                    nomeFoto = "torre pisa";
                }
                else if(nomeFoto.equals("torre pisa")){
                    imgTuristico.setImageResource(R.drawable.coliseu);
                    nomeFoto = "coliseu";
                }
                else if(nomeFoto.equals("coliseu")){
                    imgTuristico.setImageResource(R.drawable.ic_launcher_foreground);
                    nomeFoto = "";

                }
                else{
                    imgTuristico.setImageResource(R.drawable.ic_launcher_foreground);
                    nomeFoto = "";
                    Toast.makeText(Vizualizar.this,
                            "Falha do Sistema",
                            Toast.LENGTH_LONG);

                }

            }
        });

        //6) Configurando clique longo no ImageView
        imgTuristico.setOnLongClickListener(new View.OnLongClickListener()
        {
            @Override
            public boolean onLongClick(View view)
            {
                String msg = "";
                if(nomeFoto.equals(""))
                {
                    msg = "Escolha um ponto turístico";
                }
                else if(nomeFoto.equals("cristo"))
                {
                    msg = "Suporta ventos de até 250 km/h ";
                }
                else if(nomeFoto.equals("torre eiffel"))
                {
                    msg = "Inaugurada em 1889 para a Exposição Universal";
                }
                else if(nomeFoto.equals("muralha da China"))
                {
                    msg = "Possui mais de 21.000 km";
                }
                else if(nomeFoto.equals("torre pisa"))
                {
                    msg = " Levou cerca de 200 anos para ser concluída";
                }
                else if(nomeFoto.equals("coliseu"))
                {
                    msg = "Tem capacidade para até 80.000 pessoas";
                }
                else
                {
                    msg = "Falha do Sistema";
                }

                Toast.makeText(Vizualizar.this,
                        msg,
                        Toast.LENGTH_LONG);
                return true;
            }
        });
        //7)Sair
        btnSair.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finishAffinity();
            }
        });
    }
}