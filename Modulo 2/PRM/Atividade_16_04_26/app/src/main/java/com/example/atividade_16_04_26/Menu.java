package com.example.atividade_16_04_26;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.provider.CalendarContract;
import android.provider.MediaStore;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Menu extends AppCompatActivity {
//Atributo
    Button btnNav, btnLigar, btnCompartilhar, btnCamera,
        btnGaleria, btnMap, btnEmail, btnCalendario, btnFechar;

    TextView lblTitulo2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        //(niciando os elementos
        btnNav = (Button) findViewById(R.id.btnNav);
        btnGaleria= (Button) findViewById(R.id.btnGaleira);
        btnLigar = (Button) findViewById(R.id.btnLigar);
        btnEmail = (Button) findViewById(R.id.btnEmail);
        btnMap = (Button) findViewById(R.id.btnMap);
        btnCalendario = (Button) findViewById(R.id.btnCalendario);
        btnCompartilhar = (Button) findViewById(R.id.btnCompartilhar);
        btnCamera = (Button) findViewById(R.id.btnCâmera);
        btnFechar = (Button) findViewById(R.id.btnFechar);
        lblTitulo2 = (TextView) findViewById(R.id.lblTitulo2);

        //3) Recuperando os valores da tela anteiror
        String nome = getIntent().getStringExtra("ValorNome");
        int idade = getIntent().getIntExtra("ValorIdade",0);

        //4)Mudando o título
        lblTitulo2.setText("Bem-vindo\n" + nome + " com " + idade +" anos!");
        //-------------------- Itents Implícitos -------------//
        btnNav.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Uri site = Uri.parse("https://google.com");
                startActivity(new Intent(Intent.ACTION_VIEW,site));
            }
        });

        btnLigar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Uri numeroTel = Uri.parse("tel:11979801104");
                startActivity(new Intent(Intent.ACTION_DIAL,numeroTel));
            }
        });

    btnCompartilhar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            Intent comp = new Intent(Intent.ACTION_SEND);
            comp.setType("text/plain");
            comp.putExtra(Intent.EXTRA_TEXT,"Meu Textinho Compartilhado");
            startActivity((comp.createChooser(comp,"Compartilhar via")));
        }
    });

    btnCamera.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            startActivity(new Intent((
                    MediaStore.ACTION_IMAGE_CAPTURE
                    )));
        }
    });

    btnGaleria.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            startActivity((new Intent(Intent.ACTION_PICK,
                    MediaStore.Images.Media.EXTERNAL_CONTENT_URI)));
        }
    });

    btnEmail.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            Intent email = new Intent(Intent.ACTION_SENDTO);
            email.setData(Uri.parse("mailto:rafael@gmail"));
            email.putExtra(Intent.EXTRA_SUBJECT,"Assunto do email");
            email.putExtra(Intent.EXTRA_TEXT,"Corpo do Email");
            startActivity(email);
        }
    });
    btnMap.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            Uri local = Uri.parse("geo:0,0?q=Lauro Gomes,São Bernardo do Campo");
            Intent it = new Intent(Intent.ACTION_VIEW,local);
            startActivity(it);
        }
    });

    btnCalendario.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            Intent calendar = new Intent(Intent.ACTION_INSERT);
            calendar.setData(CalendarContract.Events.CONTENT_URI);
            calendar.putExtra(CalendarContract.Events.TITLE,"Reunião!");
            calendar.putExtra(CalendarContract.Events.EVENT_LOCATION,"SBC");
            calendar.putExtra(CalendarContract.EXTRA_EVENT_BEGIN_TIME,
                    System.currentTimeMillis());
            calendar.putExtra(CalendarContract.EXTRA_EVENT_END_TIME,
                    System.currentTimeMillis()+720000);
            startActivity(calendar);
        }
    });
    }
}