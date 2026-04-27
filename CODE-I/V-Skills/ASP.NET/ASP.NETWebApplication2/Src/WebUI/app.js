const API_BASE = "https://localhost:7295;http://localhost:5011";


// function
async function calculate() {
    const payload = {
        a: parseFloat(document.getElementById('a').value),
        b: parseFloat(document.getElementById('b').value),
        c: parseFloat(document.getElementById('c').value),
        d: parseFloat(document.getElementById('d').value)
    };

    try {
        const res = await fetch(`${API_BASE}/api/calculation`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(payload)
        });

        const data = await res.json();
        document.getElementById('result').textContent = JSON.stringify(data, null, 2);
    } catch (err) {
        alert('Error');
    }
}

function buildRequestPayload() { }

function renderResult(response) { }

function handleError(error) { }