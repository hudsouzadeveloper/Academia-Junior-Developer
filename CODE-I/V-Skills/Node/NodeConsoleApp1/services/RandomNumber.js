// Exporting
export default class RandomNumber {
    lottery(min, max) {
        return Math.random() * (max - min) + min;
    }
}