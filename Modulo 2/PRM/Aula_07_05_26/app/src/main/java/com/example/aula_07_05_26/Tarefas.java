package com.example.aula_07_05_26;

public class Tarefas {
    //1)Atributos
    private String descricao;
    private String responsavel;
    private String horas;

    //2)Construtor

    public Tarefas(String descricao, String responsavel, String horas) {
        this.descricao = descricao;
        this.responsavel = responsavel;
        this.horas = horas;
    }


    //3)Getter e Setters


    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public String getResponsavel() {
        return responsavel;
    }

    public void setResponsavel(String responsavel) {
        this.responsavel = responsavel;
    }

    public String getHoras() {
        return horas;
    }

    public void setHoras(String horas) {
        this.horas = horas;
    }

    //ToString

    @Override
    public String toString() {
        return "Tarefas:" + descricao + '\'' +
                "| Por: " + responsavel + '\'' +
                "| As " + horas + '\'' +" hora";
    }
}
