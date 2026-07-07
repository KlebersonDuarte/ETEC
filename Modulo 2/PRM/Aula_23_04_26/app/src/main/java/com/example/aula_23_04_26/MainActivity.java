package com.example.aula_23_04_26;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Arrays;

public class MainActivity extends AppCompatActivity {
    //1 atributos

    EditText txtNome, txtEnd, txtCpf, txtCargo;

    Button btnCad,btnContar;

    ListView listinha;
        ArrayList<Usuario> listaLogica = new ArrayList<Usuario>();
    ArrayList<String> verificar = new ArrayList<String>(Arrays.asList("0","1","2","3","4","5","6","7","8","9"));


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //2 Iniciar os elementos

        txtNome = (EditText) findViewById(R.id.txtNome);
        txtCargo = (EditText) findViewById(R.id.txtCargo);
        txtCpf= (EditText) findViewById(R.id.txtCpf);
        txtEnd = (EditText) findViewById(R.id.txtEnd);
        btnCad = (Button) findViewById(R.id.btnCad);
        btnContar = (Button) findViewById(R.id.btnContar);
        listinha = (ListView) findViewById(R.id.listinha);

        // 3) Evento do Button
        btnCad.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                //Recuperando valores
                String end = txtEnd.getText().toString();
                String nome = txtNome.getText().toString();
                String cpf = txtCpf.getText().toString();
                String cargo = txtCargo.getText().toString();
                if(end.isEmpty() || nome.isEmpty() ||cpf.isEmpty()|| cargo.isEmpty()){
                    Toast.makeText(MainActivity.this,
                            "Preencha todos os campos",
                            Toast.LENGTH_LONG).show();
                    return;

                }

                if(cpf.length() != 11){
                    Toast.makeText(MainActivity.this,
                            "CPF Fake",
                            Toast.LENGTH_LONG).show();
                    return;
                }



                for(int i = 0; i < 11; i++){

                    String ver = cpf.substring(i,i + 1);
                    boolean existe = false;

                    for(int j = 0; j < verificar.size(); j++){

                        if(ver.equals(verificar.get(j))){
                            existe = true;
                            break;
                        }
                    }
                    if(!existe){
                        Toast.makeText(MainActivity.this,
                                "CPF inválido",
                                Toast.LENGTH_LONG).show();
                        return;
                    }
                    }



                //Instanciando a classe Usuario
                Usuario user = new Usuario(nome,cpf,end,cargo);

                for(int i = 0; i < listaLogica.size(); i++){
                    if(cpf.equals(listaLogica.get(i).getCpf())){
                        Toast.makeText(MainActivity.this,
                                "CPF repetido",
                                Toast.LENGTH_LONG).show();
                        return;
                    }
                }

                /*
                    Exemplo do ArrayList com a classe Usuario
                    |  Nome   | End |   CPF    | Cargo |
                   0| Bruna   | SBC | 787878   | Chefe |
                   1| Douglas | SBC | 555555   | Caixa |
                   2| Camila  | SBC | 888888   | Dona  |

                 */

                //Inserindo o objeto user no ArrayList
                listaLogica.add(user);

                //Adaptando a listaLogica
                ArrayAdapter<Usuario> adaptadorLista =
                        new ArrayAdapter<>(MainActivity.this,
                                android.R.layout.simple_list_item_1,
                                listaLogica);

                //Inserindo a lista já adaptada no layout
                listinha.setAdapter(adaptadorLista);

                //Limpando os campos
                txtEnd.setText("");
                txtNome.setText("");
                txtCargo.setText("");
                txtCpf.setText("");
            }
        });


        //4)
        listinha.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int posicao, long l) {
                //Recupero o valor do ArrayList
                String nome = listaLogica.get(posicao).getNome();
                String end = listaLogica.get(posicao).getEnd();
                String cargo = listaLogica.get(posicao).getCargo();
                String cpf = listaLogica.get(posicao).getCargo();
                String mens = "Nome: "+ nome +
                        "\n End: "+ end +
                        "\n Cargo: "+ cargo +
                        "\n CPF: " + cpf;
                //Mostrando valores
                Toast.makeText(MainActivity.this,mens,Toast.LENGTH_LONG).show();
            }
        });

        listinha.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> adapterView, View view, int posicao, long l) {

                //Recupero o valor do ArrayList
                listaLogica.get(posicao).setNome("");
                listaLogica.get(posicao).setEnd("");
                listaLogica.get(posicao).setCargo("");
                listaLogica.get(posicao).setCargo("");


                return true;
            }
        });

        btnContar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(listaLogica.size() > 0){

                for(int i = 1; i <= listaLogica.size();i++){
                    Toast.makeText(MainActivity.this,
                            "Atualmente tem " + i + " usuarios cadastrados",
                            Toast.LENGTH_LONG).show();
                    return;
                }}
                Toast.makeText(MainActivity.this,
                        "Não há usuários cadastrados no momento",
                        Toast.LENGTH_LONG).show();
            }
        });
    }
}