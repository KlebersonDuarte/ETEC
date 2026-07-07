package com.example.auladodia26_03;

import static android.widget.Toast.LENGTH_LONG;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MenuPrincipal extends AppCompatActivity {

    //1)Atributos
    Button btnCombustiveis,btnCadastro,btnVizualizar;
    TextView lblNome;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_menu_principal);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });


try{
            //2)"Linkando"
            btnCadastro = (Button) findViewById(R.id.btnCadastro);
            btnCombustiveis = (Button) findViewById(R.id.btnCombustiveis);
            btnVizualizar = (Button) findViewById(R.id.btnVizualizar);
            lblNome = (TextView) findViewById(R.id.lblNome);

            //3)Botão Combustiveis
            btnCombustiveis.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    Intent Comb =new Intent(MenuPrincipal.this,
                            Combustivel.class);
                    startActivity(Comb);
                }
            });

            //4)Botão Vizualizar
            btnVizualizar.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    Intent Vizualizar = new Intent(MenuPrincipal.this,
                            Vizualizar.class);
                    startActivity(Vizualizar);
                }
            });

            //5)Botão Cadastrar
            btnCadastro.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    Intent Cadast = new Intent(MenuPrincipal.this,
                            Cadastrar.class);
                    startActivity(Cadast);
                }
            });

 //6)Mostrando o nome do usuario
 Intent menu = getIntent();
    lblNome.setText("Olá " +menu.getStringExtra("Nome"));
}
catch (Exception ex){
    Toast.makeText(MenuPrincipal.this,
            "Falha do sistema",LENGTH_LONG).show();
}
    }
}