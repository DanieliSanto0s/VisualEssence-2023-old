document.addEventListener('DOMContentLoaded', function () {
    const senhaInput = document.getElementById('senha');
    const iconeSenha = document.getElementById('iconesenha');

    iconeSenha.addEventListener('click', function () {
        const type = senhaInput.getAttribute('type') === 'password' ? 'text' : 'password';
        senhaInput.setAttribute('type', type);

        const iconClass = type === 'password' ? 'bi-eye-slash' : 'bi-eye' ;
        iconeSenha.classList.remove('bi-eye');
        iconeSenha.classList.add(iconClass);
    });
});
