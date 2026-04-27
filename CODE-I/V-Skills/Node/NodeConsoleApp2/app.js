import { question } from 'node:readline/promises';

// JDCI-1.2 = Operations Practice "The application receives four numbers
//                                 and see which one is the highest.
//                                 The result must be returned;"

const a = parseInt(await question("Write 1st number: "));
const b = parseInt(await question("Write 2nd number: "));
const c = parseInt(await question("Write 3rd number: "));
const d = parseInt(await question("Write 4th number: "));

const highestNumber = 10;

if (a > highestNumber) {
    highestNumber = a;
}

if (b > highestNumber) {
    highestNumber = b;
}

if (c > highestNumber) {
    highestNumber = c;
}

if (d > highestNumber) {
    highestNumber = d;
} else {
    console.log("The highest number is 10!");
}

console.log("The highest number is:", { highestNumber });
