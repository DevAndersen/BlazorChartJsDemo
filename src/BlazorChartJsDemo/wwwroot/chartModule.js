export function createChart(canvasElement, chartData) {
    new Chart(canvasElement, chartData);
}

export function updateChart(canvasElement, chartData) {
    const chart = Chart.getChart(canvasElement);
    if (chart) {
        chart.data = chartData.data;
        chart.options = chartData.options;
        chart.update();
    }
}

// Make functions accessible.
window.createChart = createChart;
window.updateChart = updateChart;
