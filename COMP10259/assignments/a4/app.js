let svg = document.getElementById("myArea");
let displayScore = document.getElementById("gameScore");
let btn = document.getElementById("startBtn");
let winCard = document.getElementById("win-card");
let restartBtn = document.getElementById("restartBtn");
let NS = "http://www.w3.org/2000/svg";
let positionX = 100;
let positionY = 100;
let randCX;
let randCY;
let score = 0;
let box = document.createElementNS(NS, "rect");
let circle = document.createElementNS(NS, "circle");

btn.addEventListener("click", () => {
  box.setAttribute("x", `${positionX}`);
  box.setAttribute("y", `${positionY}`);
  box.setAttribute("width", "30");
  box.setAttribute("height", "30");
  box.setAttribute("fill", "brown");

  svg.appendChild(box);
  createCircle();
});

function createCircle() {
  randCX = Math.floor(Math.random() * 400);
  randCY = Math.floor(Math.random() * 400);
  circle.setAttribute("cx", `${randCX}`);
  circle.setAttribute("cy", `${randCY}`);
  circle.setAttribute("r", "10");
  circle.setAttribute("fill", "red");
  svg.appendChild(circle);
}

document.addEventListener("keydown", function (event) {
  event.preventDefault();

  switch (event.key) {
    case "ArrowUp":
      if (positionY > 0) {
        box.setAttribute("y", `${(positionY -= 30)}`);
      } else {
        box.setAttribute("y", `${0}`);
      }
      break;
    case "ArrowDown":
      if (positionY < 500) {
        box.setAttribute("y", `${(positionY += 30)}`);
      } else {
        box.setAttribute("y", `${460}`);
      }
      break;
    case "ArrowLeft":
      if (positionX > 0) {
        box.setAttribute("x", `${(positionX -= 30)}`);
      } else {
        box.setAttribute("x", `${0}`);
      }
      break;
    case "ArrowRight":
      if (positionX < 500) {
        box.setAttribute("x", `${(positionX += 30)}`);
      } else {
        box.setAttribute("x", `${460}`);
      }
      break;
  }
  checkCollision();
});

function checkCollision() {
  let boxLeft = positionX;
  let boxRight = positionX + 30;
  let boxTop = positionY;
  let boxBottom = positionY + 30;

  // Is the circle's center inside the box?
  if (
    randCX >= boxLeft &&
    randCX <= boxRight &&
    randCY >= boxTop &&
    randCY <= boxBottom
  ) {
    svg.removeChild(circle);
    createCircle();
    score++;
    displayScore.innerHTML = score;

    if (score >= 5) {
      svg.removeChild(circle); // clear the target so it can't be hit again
      winCard.classList.add("show");
    }
  }
}

restartBtn.addEventListener("click", () => {
  winCard.classList.remove("show");
  score = 0;
  displayScore.innerHTML = score;
  positionX = 100;
  positionY = 100;
  box.setAttribute("x", `${positionX}`);
  box.setAttribute("y", `${positionY}`);
  createCircle();
});
