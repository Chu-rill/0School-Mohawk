let images = [
  ["images/cat_1.jpg", "images/cat_2.jpg", "images/cat_3.jpg"],
  ["images/dog_1.jpg", "images/dog_2.jpg", "images/dog_3.jpg"],
  ["images/star_1.jpeg", "images/star_2.jpg", "images/star_3.jpeg"],
];

let refreshMs = 2500;
let remaining = refreshMs;
let count = 0;
let timer = null;
let randomNumber = 0;

// select the DOM elements
let img0 = document.getElementById("img0");
let img1 = document.getElementById("img1");
let img2 = document.getElementById("img2");
let intervalInput = document.getElementById("interval");
let countdownEl = document.getElementById("countdown");
let counterEl = document.getElementById("counter");
let timerCard = document.getElementById("timerCard");

function do_animation(event) {
  let target = event.srcElement;

  target.classList.remove("spin");

  setTimeout(() => {
    target.classList.add("spin");
  }, 0);
}

function randomizeAll() {
  randomNumber = Math.floor(Math.random() * 3);
  img0.src = images[randomNumber][randomNumber];

  randomNumber = Math.floor(Math.random() * 3);
  img1.src = images[randomNumber][randomNumber];

  randomNumber = Math.floor(Math.random() * 3);
  img2.src = images[randomNumber][randomNumber];

  count = count + 3;
  counterEl.textContent = count;

  restart();
}

// image click
function onImageClick(event) {
  let target = event.srcElement;

  do_animation(event);

  randomNumber = Math.floor(Math.random() * 3);
  let theme = images[randomNumber];

  randomNumber = Math.floor(Math.random() * 3);
  let newImage = theme[randomNumber];

  // swap the image while it spins
  setTimeout(() => {
    target.src = newImage;
  }, 300);

  count = count + 1;
  counterEl.textContent = count;

  restart();
}

// countdown display and timer card color changer
function show() {
  countdownEl.textContent = (remaining / 1000).toFixed(1);

  let frac = remaining / refreshMs;
  if (frac > 0.5) {
    timerCard.className = "card h-100 timer-green";
  } else if (frac > 0.2) {
    timerCard.className = "card h-100 timer-yellow";
  } else {
    timerCard.className = "card h-100 timer-red";
  }
}

// restart the countdown
function restart() {
  remaining = refreshMs;
  show();
  clearInterval(timer);
  timer = setInterval(function () {
    remaining = remaining - 100;
    if (remaining <= 0) {
      randomizeAll();
    } else {
      show();
    }
  }, 100);
}

// interval input update
function onIntervalChange() {
  let value = Number(intervalInput.value);
  if (value >= 500 && value <= 10000) {
    refreshMs = value;
    restart();
  }
}

img0.addEventListener("click", onImageClick);
img1.addEventListener("click", onImageClick);
img2.addEventListener("click", onImageClick);
document.getElementById("randomize").addEventListener("click", randomizeAll);
intervalInput.addEventListener("change", onIntervalChange);

randomizeAll();
