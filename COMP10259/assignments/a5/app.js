/*
  Name: Churchill Daniel
  Student Number: 000983683
  Course: COMP 10259 - Client-Side Web Programming
  Assignment: 5 - AJAX, JSON, and DOM
*/

let STUDENT_NUMBER = "000983683";
let url = "https://csunix.mohawkcollege.ca/~adams/10259/a6_responder.php";

let firstButton = document.getElementById("firstButton");
let secondButton = document.getElementById("secondButton");
let thirdButton = document.getElementById("thirdButton");

/* First button: get plain text and show it in an h1. */
firstButton.addEventListener("click", async function () {
  try {
    let response = await fetch(url);
    let text = await response.text();
    showHeading(text);
  } catch (error) {
    console.log("First button error:", error);
  }
});

/* Second button: GET request, then build the cards. */
secondButton.addEventListener("click", async function () {
  let choice = getChoice();

  try {
    let response = await fetch(url + "?choice=" + encodeURIComponent(choice));
    let data = await response.json();
    buildCards(data);
    showCopyright("copyrightImages", choice);
  } catch (error) {
    console.log("Second button error:", error);
  }
});

/* Third button: POST request, then build the table. */
thirdButton.addEventListener("click", async function () {
  let choice = getChoice();
  let postValue = choice;
  if (choice === "starwars") {
    postValue = "starwars";
  } else {
    postValue = "mario";
  }

  try {
    let response = await fetch(url, {
      method: "POST",
      headers: { "Content-Type": "application/x-www-form-urlencoded" },
      body: "choice=" + encodeURIComponent(postValue),
    });
    let data = await response.json();
    buildTable(data);
    showCopyright("copyrightTable", choice);
  } catch (error) {
    console.log("Third button error:", error);
  }
});

function showHeading(text) {
  let headingArea = document.getElementById("headingArea");
  headingArea.innerHTML = "";

  let heading = document.createElement("h1");
  heading.className = "text-center w-100 mb-4";
  heading.textContent = text + " " + "Churchill Daniel " + " " + STUDENT_NUMBER;

  headingArea.appendChild(heading);
}

function buildCards(data) {
  let cardArea = document.getElementById("cardArea");
  cardArea.innerHTML = "";

  for (let i = 0; i < data.length; i = i + 1) {
    let item = data[i];

    let col = document.createElement("div");
    col.className = "col";

    let card = document.createElement("div");
    card.className = "card h-100 text-center";

    let body = document.createElement("div");
    body.className = "card-body";

    let series = document.createElement("h2");
    series.className = "h5";
    series.textContent = item.series;

    let picture = document.createElement("img");
    picture.src = item.url;
    picture.alt = item.name;
    picture.className = "card-image rounded mb-2";

    let name = document.createElement("p");
    name.className = "mb-0";
    name.textContent = item.name;

    body.appendChild(series);
    body.appendChild(picture);
    body.appendChild(name);
    card.appendChild(body);
    col.appendChild(card);
    cardArea.appendChild(col);
  }
}

/* Build the whole table tag, header row, and body rows. */
function buildTable(data) {
  let tableArea = document.getElementById("tableArea");
  tableArea.innerHTML = "";

  let table = document.createElement("table");
  table.className = "table table-bordered table-striped align-middle";

  /* Header row */
  let headerRow = document.createElement("tr");
  let headings = ["Series", "Name", "Link"];
  for (let i = 0; i < headings.length; i = i + 1) {
    let th = document.createElement("th");
    th.textContent = headings[i];
    headerRow.appendChild(th);
  }

  let thead = document.createElement("thead");
  thead.className = "table-dark text-center";
  thead.appendChild(headerRow);
  table.appendChild(thead);

  let tbody = document.createElement("tbody");
  for (let i = 0; i < data.length; i = i + 1) {
    let item = data[i];

    let row = document.createElement("tr");

    let seriesCell = document.createElement("td");
    seriesCell.textContent = item.series;

    let nameCell = document.createElement("td");
    nameCell.textContent = item.name;

    let linkCell = document.createElement("td");
    let link = document.createElement("a");
    link.href = item.url;
    link.textContent = item.url;
    linkCell.appendChild(link);

    row.appendChild(seriesCell);
    row.appendChild(nameCell);
    row.appendChild(linkCell);
    tbody.appendChild(row);
  }
  table.appendChild(tbody);

  tableArea.appendChild(table);
}

function showCopyright(areaId, choice) {
  let area = document.getElementById(areaId);

  if (choice.toLowerCase() === "mario") {
    area.textContent =
      "Game trademarks and copyrights are properties of their respective owners. Nintendo properties are trademarks of Nintendo. \u00A9 2019 Nintendo.";
  } else {
    area.textContent =
      "Star Wars \u00A9 & TM 2022 Lucasfilm Ltd. All rights reserved. Visual material \u00A9 2022 Electronic Arts Inc.";
  }
}

/* Return the value of the checked radio button ("mario" or "starwars"). */
function getChoice() {
  let radios = document.getElementsByName("choice");
  for (let i = 0; i < radios.length; i = i + 1) {
    if (radios[i].checked) {
      return radios[i].value;
    }
  }
  return "";
}
