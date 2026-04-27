import randomNumber from "./services/random-number.js";

// JDCI-1.2 = Operations practice "The application receives two number,
//                                 calculates the multiplication
//          JavaScript             and return the word “Bizz”
//                                 when even and “Buzz” when odd;

console.log("The application receives two number, calculates the multiplication and return the word “Bizz”\n when even and “Buzz” when odd;\n");

Random random = new Random();

const num1 = random.lottery(1, 100);
const num2 = random.lottery(1, 100);

let result = num1 * num2;

console.log("The result is: " + { result });

if (num1 % 2 === 0) {
    console.log("Bizz!");
} else {
    console.log("Buzz!");
}

for (let i = 0; i < 2; i++) {
    if (i === 0) {
        console.log("1st number: " + { num1 });
    } else {
        console.log("2nd number: " + { num2 });
    }
    console.log("Multiplication of: ", { num1 }, "x", { num2 }, "=", { result });
}