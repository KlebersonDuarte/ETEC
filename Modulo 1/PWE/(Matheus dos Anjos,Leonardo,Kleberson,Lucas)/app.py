from flask import Flask, render_template, request, redirect, url_for, flash, jsonify
from datetime import date
import sqlite3
import os

app = Flask(__name__)
app.secret_key = "chave-secreta"

# --- CONFIG BANCO DE DADOS ---
DB_PATH = os.path.join(os.path.dirname(__file__), "banco.db")

def conectar():
    return sqlite3.connect(DB_PATH)

# --- ROTAS PRINCIPAIS ---
@app.route('/')
def index():
    return render_template('index.html')

@app.route('/compras')
def compras():
    return render_template('compras.html')

@app.route('/ilustracoes')
def ilustracoes():
    return render_template('ilustracoes.html')

@app.route('/nacionais')
def nacionais():
    return render_template('nacionais.html')

@app.route('/sobre')
def sobre():
    return render_template('sobre.html')

@app.route('/filmes')
def filmes():
    return render_template('filmes.html')

@app.route('/animacoes')
def animacoes():
    return render_template('animacoes.html')

@app.route('/filmesDC')
def filmesDC():
    return render_template('filmesDC.html')

@app.route('/animacoesDC')
def animacoesDC():
    return render_template('animacoesDC.html')

@app.route('/comprasDC')
def comprasDC():
    return render_template('comprasDC.html')


# --- LOGIN ---
@app.route('/form', methods=['GET', 'POST'])
def form():
    if request.method == 'POST':
        email = request.form.get('email')
        senha = request.form.get('senha')

        con = conectar()
        cur = con.cursor()
        cur.execute("""
            CREATE TABLE IF NOT EXISTS usuarios (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nome TEXT,
                email TEXT UNIQUE,
                senha TEXT,
                nascimento TEXT
            )
        """)
        cur.execute("SELECT * FROM usuarios WHERE email=? AND senha=?", (email, senha))
        usuario = cur.fetchone()
        con.close()

        if usuario:
            return redirect(url_for('index'))
        else:
            flash('E-mail ou senha incorretos!')
            # ⬇️ Em vez de redirecionar, renderiza a página de novo mantendo os dados digitados
            return render_template('form.html', email=email, senha=senha)

    return render_template('form.html')



# --- CADASTRO ---
@app.route('/cadastrar')
def cadastrar():
    return render_template('cadastrar.html')

@app.route('/salvar_cadastro', methods=['POST'])
def salvar_cadastro():
    nome = request.form.get('nome')
    email = request.form.get('email')
    senha = request.form.get('senha')
    repetir = request.form.get('repetir')
    nascimento = request.form.get('nascimento')

    if not all([nome, email, senha, repetir, nascimento]):
        flash('Preencha todos os campos!')
        return render_template('cadastrar.html', nome=nome, email=email, nascimento=nascimento)

    if senha != repetir:
        flash('As senhas não coincidem!')
        return render_template('cadastrar.html', nome=nome, email=email, nascimento=nascimento)

    ano_nasc = int(nascimento.split('-')[0])
    idade = date.today().year - ano_nasc
    if idade < 16:
        flash('É necessário ter pelo menos 16 anos!')
        return render_template('cadastrar.html', nome=nome, email=email, nascimento=nascimento)

    con = conectar()
    cur = con.cursor()
    cur.execute("""CREATE TABLE IF NOT EXISTS usuarios (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nome TEXT,
        email TEXT UNIQUE,
        senha TEXT,
        nascimento TEXT
    )""")

    try:
        cur.execute("INSERT INTO usuarios (nome, email, senha, nascimento) VALUES (?, ?, ?, ?)",
                    (nome, email, senha, nascimento))
        con.commit()
        return redirect(url_for('form'))
    except sqlite3.IntegrityError:
        flash('E-mail já cadastrado!')
        return render_template('cadastrar.html', nome=nome, email=email, nascimento=nascimento)
    finally:
        con.close()


# --- ESQUECI A SENHA (AJAX) ---
@app.route('/verificar_email', methods=['POST'])
def verificar_email():
    data = request.get_json()
    email = data.get('email')

    con = conectar()
    cur = con.cursor()
    cur.execute("SELECT 1 FROM usuarios WHERE email=?", (email,))
    existe = cur.fetchone() is not None
    con.close()

    return jsonify({"existe": existe})


# --- EXECUÇÃO ---
if __name__ == '__main__':
    app.run(debug=True)