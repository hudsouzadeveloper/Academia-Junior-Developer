import { DivisionApi } from "./script.js";
import { SkeletonManager } from "./skeleton.js";
import { DivisionUi } from "./ui.js";

const resultEl = document.getElementById("result");
const calculateButton = document.getElementById("calculate");
const titleEl = document.querySelector(".container-title");
const inputAEl = document.getElementById("a");
const inputBEl = document.getElementById("b");

const api = new DivisionApi("http://localhost:5239");
const skeleton = new SkeletonManager({
    titleEl,
    inputAEl,
    inputBEl,
    calculateButton,
    resultEl,
    minResultMs: 700,
    initialPageMs: 900
});

const ui = new DivisionUi({
    inputAEl,
    inputBEl,
    resultEl,
    calculateButtonEl: calculateButton
});

skeleton.setMasked(true);
void skeleton.showInitialSkeleton();

// Event listener for the calculate button
calculateButton.addEventListener("click", async () => {
    let startedAt;

    try {
        skeleton.setPageLoaded();
        const { a, b } = ui.getInputs();
        ui.setBusy(true);
        startedAt = await skeleton.startResultLoading();

        const result = await api.calculate(a, b);
        await skeleton.stopResultLoading(startedAt);
        ui.render(result);
    } catch (err) {
        if (startedAt) {
            await skeleton.stopResultLoading(startedAt);
        } else {
            skeleton.setResultLoading(false);
        }

        ui.renderError(err.message);
    } finally {
        ui.setBusy(false);
    }
});