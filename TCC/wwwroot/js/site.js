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

const timer = setInterval(() => {
    const time = new Date().getTime() - startTime;
    const newX = easeInOutQuart(time, startX, distanceX, duration);
    const newY = easeInOutQuart(time, startY, distanceY, duration);
    if (time >= duration) {
        clearInterval(timer);
    }
    window.scroll(newX, newY);
}, 1000 / 60);