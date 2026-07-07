package com.example.aula_07_05_26;

import static android.widget.Toast.LENGTH_LONG;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    //1)Atributos
    Button btnSalvar,btnBusca;
    EditText txtDescricao,txtResponsavel,txtHoras,txtBusca;

    ListView listaTarefas;

    ///ArrayList e Adaptador
    ArrayList<Tarefas> lista = new ArrayList<>();
    ArrayAdapter<Tarefas> adaptador;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    btnBusca = (Button) findViewById(R.id.btnBusca);
    btnSalvar = (Button) findViewById(R.id.btnSalvar);
    txtDescricao = (EditText) findViewById(R.id.txtDescricao);
    txtHoras = (EditText) findViewById(R.id.txtHoras);
    txtResponsavel = (EditText) findViewById(R.id.txtResponsavel);
    listaTarefas = (ListView) findViewById(R.id.listaTarefas);
    txtBusca = (EditText) findViewById(R.id.txtBusca);

    //3)Configurar o array e o adaptador
        adaptador = new ArrayAdapter<Tarefas>(MainActivity.this,
                android.R.layout.simple_list_item_1,
                lista);

        listaTarefas.setAdapter(adaptador);

        //4)Evento do botão
    btnSalvar.setOnClickListener(new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            if(validarCampos()){



            String desc = txtDescricao.getText().toString();
            String horas = txtHoras.getText().toString();
            String resp = txtResponsavel.getText().toString();

            //Montar a classe Tarefas com os valores
            Tarefas taf = new Tarefas(desc,resp,horas);

            for(int i = 0;i < lista.size();i++){

                if(taf.getDescricao().equals(lista.get(i).getDescricao()) &&
                taf.getResponsavel().equals(lista.get(i).getResponsavel()) &&
                taf.getHoras().equals(lista.get(i).getHoras())){
                    Toast.makeText(MainActivity.this,
                            "Não é permitido inserir tarefas iguais",
                            LENGTH_LONG).show();
                    return;
                }
            }

    //Adicionando os valores na lista
            lista.add(taf);

            //Atualizando a lista
            adaptador.notifyDataSetChanged();
            Toast.makeText(MainActivity.this,
                    "Tarefa Salva!",
                    LENGTH_LONG).show();

            limparCampos();
        }}
    });

    //Evento itemlong
        listaTarefas.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
                //Removendo item da lista
                lista.remove(i);

                //Atualizando lista
                adaptador.notifyDataSetChanged();
                return true;
            }
        });

        btnBusca.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String nome = txtBusca.getText().toString();
                int contador = 0;
                for(int i = 0; i< lista.size();i++) {
                    if (lista.get(i).getResponsavel().equals(nome)) {
                        contador++;
                    }
                }

                    if(contador == 0){
                        Toast.makeText(MainActivity.this,
                                "Não há nenhuma tarefa \n para esse usuário",
                                LENGTH_LONG).show();
                   return;
                    }
                    Toast.makeText(MainActivity.this,
                            "Esse usuário pussui "+contador + " tarefa(s)",
                            LENGTH_LONG).show();
                }

        });
    }

    public boolean validarCampos(){
        if(txtDescricao.getText().toString().isEmpty() || txtHoras.getText().toString().isEmpty() || txtResponsavel.getText().toString().isEmpty()){
            Toast.makeText(MainActivity.this,
                    "Preencher todos os campos! Otário",
                    LENGTH_LONG).show();
            return false;
        }
        return true;
    }

    public void limparCampos(){
        //Limpando os campos
        txtHoras.setText("");
        txtDescricao.setText("");
        txtResponsavel.setText("");
        txtDescricao.requestFocus();
    }
}