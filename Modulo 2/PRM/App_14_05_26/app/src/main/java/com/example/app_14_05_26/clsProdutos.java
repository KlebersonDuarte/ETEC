package com.example.app_14_05_26;

public class clsProdutos {

private String Nome;
private String Desc;
private double Valor;

    public clsProdutos(String nome, String desc, double valor) {
        Nome = nome;
        Desc = desc;
        Valor = valor;
    }

    public String getNome() {
        return Nome;
    }

    public void setNome(String nome) {
        Nome = nome;
    }

    public String getDesc() {
        return Desc;
    }

    public void setDesc(String desc) {
        Desc = desc;
    }

    public double getValor() {
        return Valor;
    }

    public void setValor(double valor) {
        Valor = valor;
    }

    @Override
    public String toString() {
        return
                "\nNome: " + Nome +
                "\nDescrição: " + Desc +
                "\nValor: " + Valor;
    }
}
