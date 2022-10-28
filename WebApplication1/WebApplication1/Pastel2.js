$(document).ready(function () {
    $.ajax({
        type: "GET",
        contentType: "application/json; charsert=utf-8",
        dataType: "json",
        url: "https://localhost:44384/ReporteProductosGrafica/DataPastel",
        error: function () {
            alert("a ocurrido un error");
        },
        success: function (data) {
            console.log(data);
            GraficaPastel(data);
        }
    })
});

function GraficaPastel(data) {
Highcharts.chart('container', {
    chart: {
        plotBackgroundColor: null,
        plotBorderWidth: null,
        plotShadow: false,
        type: 'pie'
    },
    title: {
        text: 'Productos Vendidos'
    },
    tooltip: {
        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
    },
    accessibility: {
        point: {
            valueSuffix: '%'
        }
    },
    plotOptions: {
        pie: {
            allowPointSelect: true,
            cursor: 'pointer',
            dataLabels: {
                enabled: false
            },
            showInLegend: true
        }
    },
    series: [{
        name: 'Brands',
        colorByPoint: true,
        data: data
    }]
    });
}