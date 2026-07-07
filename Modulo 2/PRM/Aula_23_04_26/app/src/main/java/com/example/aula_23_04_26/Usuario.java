package com.example.aula_23_04_26;

public class Usuario
{
    //1 Atributos
    private String nome;
    private String cargo;
    private String cpf;
    private String end;

    //Método construtor I

    public Usuario()
    {

    }

    //Método Construto II


    public Usuario(String nome, String cargo, String cpf, String end) {
        this.nome = nome;
        this.cargo = cargo;
        this.cpf = cpf;
        this.end = end;
    }
    //Getters & Setters


    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCargo() {
        return cargo;
    }

    public void setCargo(String cargo) {
        this.cargo = cargo;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getEnd() {
        return end;
    }

    public void setEnd(String end) {
        this.end = end;
    }

    //Método String

    @Override
    public String toString() {
        return "Usuario{" +
                "nome='" + nome + '\'' +
                ", cargo='" + cargo + '\'' +
                ", cpf='" + cpf + '\'' +
                ", end='" + end + '\'' +
                '}';
    }
}

