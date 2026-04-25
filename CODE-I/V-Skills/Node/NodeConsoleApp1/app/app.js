import RandomNumber from "../services/RandomNumber.js";
import DivisionService from "../services/DivisionService.js";

const random = new RandomNumber();
const divisionService = new DivisionService();

const a = random.lottery(1, 100);
const b = random.lottery(1, 100);

const result = divisionService.getHighest(a, b);

console.log({ a, b, ...result });