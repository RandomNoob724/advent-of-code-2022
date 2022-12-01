import { readFile } from "../util/readInputFile";

//PART 1

const input: string = readFile("./day-1/input.txt");
let highestAmountOfCalories = 0;
const listOfResults: number[] = [];

const listOfInputLines = input.split("\n");

let sumOfCalories: number = 0;

for (let line of listOfInputLines) {
  if (line.trim() === "") {
    if (sumOfCalories > highestAmountOfCalories)
      highestAmountOfCalories = sumOfCalories;
    listOfResults.push(sumOfCalories);
    sumOfCalories = 0;
  } else {
    sumOfCalories += parseInt(line);
  }
}

//PART 2
listOfResults.sort((a, b) => b - a);

let result: number = 0;

console.log(highestAmountOfCalories);

listOfResults.splice(0, 3).forEach((item) => {
  result += item;
});
console.log(result);
