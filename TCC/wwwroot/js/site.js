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

