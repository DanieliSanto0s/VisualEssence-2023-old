const menuLinks = document.querySelectorAll('.menu a[href^="#"]');

function getDistanceFromTheTop(element) {
    const id = element.getAttribute("href");
    return document.querySelector(id).offsetTop;
};

function nativeScroll(distanceFromTheTop) {
    window.scroll({
        top: distanceFromTheTop,
        behavior: "smooth",
    })
}

function scrollToSection(event) {
    event.preventDefault();
    const distanceFromTop = getDistanceFromTheTop(event.target) ;
    nativeScroll(distanceFromTop)
}
menuLinks.forEach((link) =>
    link.addEventListener("click", scrollToSection)
)

//----------------------------------//

const toggle = document.getElementById('toggleDark');
const body = document.querySelector('body');

toggle.addEventListener('click', function () {
    this.classList.toggle('bi-brightness-high-fill');
    if (this.classList.toggle('bi-moon')) {
        body.style.backgroundImage = 'linear-gradient(180deg, rgba(16,121,199,1) 0%, rgba(16,121,204,0.9192051820728291) 51%, rgba(68,179,190,0.8519782913165266) 100%)'; // Gradiente Diurno
        body.style.transition = '3s';
    } else {
        body.style.backgroundImage = 'linear-gradient(180deg, rgba(2,14,42,1) 0%, rgba(18,5,61,1) 54%, rgba(36,2,37,1) 100%)'; // Gradiente noturno
        body.style.transition = '3s';
    }
   
});

