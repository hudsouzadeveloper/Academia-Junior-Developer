export default class DivisionService {
    getHighest(a, b) {
        if (a === 0 || b === 0) {
            throw new Error("Cannot divide by zero");
        }

        const resultA = a / b;
        const resultB = b / a;

        const max = Math.max(resultA, resultB);
        const winner = resultA > resultB ? "a divided by b" : (resultB > resultA ? "b divided by a" : "tie");

        return { max, winner };
    }
}