package com.example.aula_09_04_26;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class menu extends AppCompatActivity {
TextView lblNomeUser;
Button btnLogOff,btnDesafioMat,btnSair;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

    lblNomeUser = (TextView) findViewById(R.id.lblNomeUser);
    btnDesafioMat = (Button) findViewById(R.id.btnDesafioMat);
    btnLogOff = (Button) findViewById(R.id.btnLofOff);
    btnSair = (Button) findViewById(R.id.btnSair);
 Intent menu = getIntent();
 lblNomeUser.setText(menu.getStringExtra("nome"));

 btnLogOff.setOnClickListener(new View.OnClickListener() {
     @Override
     public void onClick(View view) {
         Intent voltar = new Intent(menu.this,
                 MainActivity.class);
         startActivity(voltar);
     }
 });

 btnSair.setOnClickListener(new View.OnClickListener() {
     @Override
     public void onClick(View view) {
finishAffinity();
     }
 });

 btnDesafioMat.setOnClickListener(new View.OnClickListener() {
     @Override
     public void onClick(View view) {
    Intent mat = new Intent(menu.this,
            desafioMat.class);
    startActivity(mat);
     }
 });
    }
}