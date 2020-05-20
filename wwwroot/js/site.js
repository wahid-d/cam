const body = document.body;
const menuLinks = document.querySelectorAll(".admin-menu a");
const collapseBtn = document.querySelector(".admin-menu .collapse-btn");
const toggleMobileMenu = document.querySelector(".toggle-mob-menu");
const collapsedClass = "collapsed";

document.addEventListener("DOMContentLoaded", function()
{
  for (const link of menuLinks) {
    link.addEventListener("mouseenter", function() {
      body.classList.contains(collapsedClass) &&
      window.matchMedia("(min-width: 768px)").matches
        ? this.setAttribute("title", this.textContent)
        : this.removeAttribute("title");
    });
  }
});


window.collapseBtnClicked = (btn) =>
{
  btn.getAttribute("aria-expanded") == "true"
    ? btn.setAttribute("aria-expanded", "false")
    : btn.setAttribute("aria-expanded", "true");
    btn.getAttribute("aria-label") == "collapse menu"
    ? btn.setAttribute("aria-label", "expand menu")
    : btn.setAttribute("aria-label", "collapse menu");
  body.classList.toggle(collapsedClass);
}

window.toggleBtnClicked = (btn) => {
  btn.getAttribute("aria-expanded") == "true"
    ? btn.setAttribute("aria-expanded", "false")
    : btn.setAttribute("aria-expanded", "true");
    btn.getAttribute("aria-label") == "open menu"
    ? btn.setAttribute("aria-label", "close menu")
    : btn.setAttribute("aria-label", "open menu");
  body.classList.toggle("mob-menu-opened");
}

window.toggleUnfocused = (btn) => {
  btn.getAttribute("aria-expanded") == "true"
    ? btn.setAttribute("aria-expanded", "false")
    : btn.setAttribute("aria-expanded", "false");
    btn.getAttribute("aria-label") == "open menu"
    ? btn.setAttribute("aria-label", "close menu")
    : btn.setAttribute("aria-label", "close menu");
  body.classList.remove("mob-menu-opened");
}
