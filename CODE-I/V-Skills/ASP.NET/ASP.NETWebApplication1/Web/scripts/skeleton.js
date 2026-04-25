export class SkeletonManager {
    constructor({
        titleEl,
        inputAEl,
        inputBEl,
        calculateButton,
        resultEl,
        minResultMs = 700,
        initialPageMs = 900
    }) {
        this.titleEl = titleEl;
        this.inputAEl = inputAEl;
        this.inputBEl = inputBEl;
        this.calculateButton = calculateButton;
        this.resultEl = resultEl;
        this.minResultMs = minResultMs;
        this.initialPageMs = initialPageMs;
        this.isPageReady = false;
        this.originalTitleText = this.titleEl.textContent;
        this.originalButtonText = this.calculateButton.textContent;
        this.originalPlaceholderA = this.inputAEl.placeholder;
        this.originalPlaceholderB = this.inputBEl.placeholder;
    }

    delay(ms) {
        return new Promise((resolve) => setTimeout(resolve, ms));
    }

    nextFrame() {
        return new Promise((resolve) => requestAnimationFrame(resolve));
    }

    setMasked(masked) {
        if (masked) {
            this.titleEl.textContent = "";
            this.calculateButton.textContent = "";
            this.inputAEl.placeholder = "";
            this.inputBEl.placeholder = "";
            this.resultEl.textContent = "";
            return;
        }

        this.titleEl.textContent = this.originalTitleText;
        this.calculateButton.textContent = this.originalButtonText;
        this.inputAEl.placeholder = this.originalPlaceholderA;
        this.inputBEl.placeholder = this.originalPlaceholderB;
    }

    setPageLoaded() {
        if (this.isPageReady) {
            return;
        }

        document.querySelectorAll(".skeleton").forEach((el) => el.classList.remove("skeleton"));
        document.querySelectorAll(".skeleton-text").forEach((el) => el.classList.remove("skeleton-text"));
        this.setMasked(false);
        this.isPageReady = true;
    }

    setResultLoading(isLoading) {
        this.resultEl.classList.toggle("skeleton", isLoading);
        this.resultEl.classList.toggle("skeleton-text", isLoading);

        if (isLoading) {
            this.resultEl.innerText = "";
        }
    }

    async startResultLoading() {
        this.setResultLoading(true);
        await this.nextFrame();
        return performance.now();
    }

    async stopResultLoading(startedAt) {
        await this.ensureMinimumResultSkeleton(startedAt);
        this.setResultLoading(false);
    }

    async showInitialSkeleton() {
        this.setMasked(true);
        await this.nextFrame();
        await this.delay(this.initialPageMs);
        this.setPageLoaded();
    }

    async ensureMinimumResultSkeleton(startedAt) {
        const elapsed = performance.now() - startedAt;
        const remaining = this.minResultMs - elapsed;

        if (remaining > 0) {
            await this.delay(remaining);
        }
    }
}
