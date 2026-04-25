export class DivisionUi {
    constructor({ inputAEl, inputBEl, resultEl, calculateButtonEl }) {
        this.inputAEl = inputAEl;
        this.inputBEl = inputBEl;
        this.resultEl = resultEl;
        this.calculateButtonEl = calculateButtonEl;
    }

    getInputs() {
        return {
            a: parseFloat(this.inputAEl.value),
            b: parseFloat(this.inputBEl.value)
        };
    }

    render(result) {
        this.resultEl.innerText = `Max: ${result.max} | Winner: ${result.winner}`;
    }

    renderError(message) {
        this.resultEl.innerText = message;
    }

    setBusy(isBusy) {
        this.calculateButtonEl.disabled = isBusy;
    }
}
