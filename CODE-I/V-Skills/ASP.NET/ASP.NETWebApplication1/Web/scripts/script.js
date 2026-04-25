export class DivisionApi {
    constructor(baseUrl = "http://localhost:5239") {
        this.baseUrl = baseUrl;
    }

    async calculate(a, b) {
        const res = await fetch(`${this.baseUrl}/Division`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ a, b })
        });

        if (!res.ok) {
            throw new Error("API error");
        }

        return res.json();
    }
}
