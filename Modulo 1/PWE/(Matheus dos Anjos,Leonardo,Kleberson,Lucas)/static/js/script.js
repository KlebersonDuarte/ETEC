document.addEventListener('DOMContentLoaded', function () {
  const abrirPopup = document.getElementById('abrir-esqueci');
  const popup = document.getElementById('popup-senha');
  const fecharPopup = document.getElementById('fechar-popup');
  const formEsqueci = document.getElementById('form-esqueci');
  const emailRecuperar = document.getElementById('email-recuperar');

  if (abrirPopup && popup && fecharPopup) {
    abrirPopup.addEventListener('click', (e) => {
      e.preventDefault();
      popup.style.display = 'flex';
    });

    fecharPopup.addEventListener('click', () => {
      popup.style.display = 'none';
    });

    popup.addEventListener('click', (e) => {
      if (e.target === popup) popup.style.display = 'none';
    });
  }

  if (formEsqueci) {
    formEsqueci.addEventListener('submit', async (e) => {
      e.preventDefault();

      const email = emailRecuperar.value.trim();
      if (!email) {
        alert("Por favor, digite seu e-mail!");
        return;
      }

      try {
        const resposta = await fetch("/verificar_email", {
          method: "POST",
          headers: { "Content-Type": "application/json" },
          body: JSON.stringify({ email })
        });

        const data = await resposta.json();
        if (data.existe) {
          alert("Enviaremos um e-mail para você redefinir sua senha.");
        } else {
          alert("E-mail não cadastrado!");
        }

        popup.style.display = 'none';
        emailRecuperar.value = '';
      } catch (erro) {
        console.error("Erro ao verificar e-mail:", erro);
        alert("Erro ao verificar. Tente novamente mais tarde.");
      }
    });
  }
});
