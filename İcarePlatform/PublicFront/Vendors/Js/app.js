function barMenuOpenFunc() {
  var element = document.getElementById("menu-bar");
  element.classList.add("active");
   var x= document.getElementById("mob-version").style.cssText='overflow-y:hidden';
}
function barMenuCloseFunc() {
  var element = document.getElementById("menu-bar");
  element.classList.remove("active");
var x= document.getElementById("mob-version").style.cssText='overflow-y:scroll';
}
