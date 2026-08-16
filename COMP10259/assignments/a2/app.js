// Group 1, Choice 1
function group_1_choice_1() {
  let input = document.getElementById("g1c1_input");
  let output = document.getElementById("g1c1_output");
  let userData = input.value.trim();
  let num = Number(userData);

  if (userData === "" || isNaN(num)) {
    output.value = "Not a number";
  } else if (num === 0 || (num >= 13 && num <= 17)) {
    output.value = "In range";
  } else {
    output.value = "Out of range";
  }
}

// Group 1, Choice 3
function group_1_choice_3() {
  let input = document.getElementById("g1c3_input");
  let output = document.getElementById("g1c3_output");
  let userData = input.value.trim();
  let side = Number(userData);

  if (userData === "" || isNaN(side) || side < 0) {
    output.value = "Can't calculate";
    return;
  }

  let perimeter = 4 * side;
  let area = side * side;

  output.value = "Perimeter: " + perimeter + ", Area: " + area;
}

// Group 2, Choice 1
function group_2_choice_1() {
  let input = document.getElementById("g2c1_input");
  let output = document.getElementById("g2c1_output");
  let vowels = ["a", "e", "i", "o", "u"];
  let letter = input.value.trim().toLowerCase();

  if (letter.length !== 1) {
    output.value = "Please enter a single letter.";
  } else {
    for (let i = 0; i < vowels.length; i++) {
      if (vowels[i] === letter) {
        output.value = "Is a vowel.";
        return;
      }
    }
    if (letter === "y") {
      output.value = "Sometimes.";
    } else {
      output.value = "Not a vowel.";
    }
  }
}

// Group 2, Choice 3
function group_2_choice_3() {
  let input = document.getElementById("g2c3_input");
  let output = document.getElementById("g2c3_output");
  let userData = input.value.trim();
  let num = Number(userData);

  if (userData === "" || !Number.isInteger(num) || num <= 0) {
    output.value = "Cannot compute factorial value";
    return;
  }

  let factorial = 1;
  for (let i = 1; i <= num; i++) {
    factorial *= i;
  }

  output.value = "Factorial = " + factorial;
}

// Group 3, Choice 1
function group_3_choice_1() {
  let input = document.getElementById("g3c1_input");
  let output = document.getElementById("g3c1_output");
  let binary = input.value.trim();

  // validate length
  if (binary.length < 10 || binary.length > 20) {
    output.value = "0";
    return;
  }

  // check if the string contains only 0s and 1s
  for (let i = 0; i < binary.length; i++) {
    if (binary[i] !== "0" && binary[i] !== "1") {
      output.value = "0";
      return;
    }
  }

  // little endian: smallest power of 2 is on the LEFT
  let value = 0;
  let power = 1;

  for (let i = 0; i < binary.length; i++) {
    if (binary[i] === "1") {
      value += power;
    }
    power *= 2;
  }

  output.value = value;
}
