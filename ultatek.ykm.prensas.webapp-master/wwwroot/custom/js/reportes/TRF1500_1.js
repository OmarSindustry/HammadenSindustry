$(document).ready(function () {
    var table = $('#metersTable').DataTable({
        columns: [
            { title: 'ID', data: 'id' },
            { title: 'Meter ID', data: 'meterId' },
            { title: 'Schedule ID', data: 'scheduleId' },
            { title: 'Unit', data: 'unit' },
            { title: 'Value', data: 'value' },
            { title: 'Consumo', data: 'consumo' },
            { title: 'Measured', data: 'measured' }
        ]
    });

    
    var chart = echarts.init(document.getElementById('invisible_chart'));
    var actual_options = {
        title: { text: 'Consumo KWH' },
        tooltip: { trigger: 'axis' },
        xAxis: { type: 'category', data: [] },
        yAxis: {
            type: 'value',
            name: 'KWH',
            axisLabel: { formatter: '{value} KWH' }
        },
        series: [{ name: 'Consumo', type: 'line', data: [] }]
    };
    chart.setOption(actual_options);

    $('#generarReporteBtn').on('click', function () {
        var fechaInicial = $('#datetimepicker').data('daterangepicker').startDate.format('YYYY-MM-DDTHH:mm:ss.SSSZ');
        var fechaFinal = $('#datetimepicker').data('daterangepicker').endDate.format('YYYY-MM-DDTHH:mm:ss.SSSZ');

        // Log para verificar qué fechas se están enviando
        console.log('Enviando fechas a la API:', fechaInicial, fechaFinal);

        obtenerDatosPorFecha(fechaInicial, fechaFinal);
    });

    function obtenerDatosPorFecha(fechaInicial, fechaFinal) {
        $.ajax({
            type: "GET",
            url: "/Reportes/GetTodosLosDatos",
            data: {
                'fechaInicial': fechaInicial,
                'fechaFinal': fechaFinal
            },
            success: function (response) {
                // Log para ver la respuesta recibida
                console.log('Datos recibidos de la API:', response);
                if (response && response.length > 0) {
                    llenarTablaMeters(response);
                    generarGrafico(response);  // Generar el gráfico con los datos
                } else {
                    console.log("No se recibieron datos o los datos están vacíos");
                }
            },
            error: function (response) {
                console.log('Error en la petición AJAX:', response);
            }
        });
    }

    function llenarTablaMeters(data) {
        var table = $('#metersTable').DataTable();
        table.clear();
        data.forEach(function (item) {
            table.row.add({
                id: item.id,
                meterId: item.meterId,
                scheduleId: item.scheduleId,
                unit: item.unit,
                value: item.value,
                consumo: item.consumo.toFixed(3),  // Mostrando "Consumo" con 3 decimales
                measured: moment(item.measured).format('YYYY-MM-DD HH:mm:ss')
            }).draw();
        });
    }
    $('#downloadExcelWithChart').on('click', function () {
        // Descargar la imagen de la gráfica
        var imgData = chart.getDataURL({
            type: 'png',
            pixelRatio: 2,
            backgroundColor: '#fff'
        });

        // Crear un enlace temporal para descargar la imagen
        var a = document.createElement('a');
        a.href = imgData;
        a.download = 'grafico.png';
        a.click();

        // Descargar el archivo Excel después de un breve retraso
        setTimeout(function () {
            table.button('.buttons-excel').trigger();
        }, 1000); // Asegurar que la descarga de la imagen termine antes de intentar descargar el Excel
    });

    function generarGrafico(data) {
        let fechas = data.map(d => moment(d.measured).format('DD-MM-YYYY HH:mm'));
        let consumos = data.map(d => d.consumo.toFixed(3));  // Datos para el gráfico
        actual_options.xAxis.data = fechas;
        actual_options.series[0].data = consumos;
        chart.setOption(actual_options);
    }
});

/*function reporteGenerar() {
    var fechaInicial = $('#datetimepicker').data('daterangepicker').startDate.format('YYYY-MM-DD HH:mm');
    var fechaFinal = $('#datetimepicker').data('daterangepicker').endDate.format('YYYY-MM-DD HH:mm');
    var numeroNodo = $('#numeroNodoSelect').val();
    var carga = $('#cargaSelect').val();
    var tipoVoltaje = $('#tipoVoltajeSelect').val();

    $.ajax({
        type: "GET",
        url: "/Reportes/GetDatosByFecha",
        data: {
            'fechaInicial': fechaInicial,
            'fechaFinal': fechaFinal,
            'numeroNodo': numeroNodo ? parseInt(numeroNodo) : null,
            'carga': carga,
            'tipoVoltaje': tipoVoltaje
        },
        success: function (response) {
            if (response != null) {
                llenarTablaMeters(response);
            } else {
                console.log("Something went wrong");
            }
        },
        error: function (response) {
            console.log("Error: ", response);
        }
    });
}
*/

/* ------------------------------------------------------------------------------
 *
 *  # Basic datatables
 *
 *  Demo JS code for datatable_basic.html page
 *
 * ---------------------------------------------------------------------------- */

// Setup initial modules
// ------------------------------

var DatatableBasic = function () {

    // Setup module components
    var _componentDatatableBasic = function () {
        if (!$().DataTable) {
            console.warn('Warning - datatables.min.js is not loaded.');
            return;
        }

        // Setting datatable defaults
        $.extend($.fn.dataTable.defaults, {
            columnDefs: [{
                orderable: false,
                width: 100,
                targets: [5]
            }],
            dom: '<"datatable-header"fBl><"datatable-scroll datatable-scroll-wrap"t><"datatable-footer"ip>',
            language: {
                search: '<span>Filter:</span> _INPUT_',
                searchPlaceholder: 'Type to filter...',
                lengthMenu: '<span>Show:</span> _MENU_',
                paginate: { 'first': 'First', 'last': 'Last', 'next': $('html').attr('dir') == 'rtl' ? '&larr;' : '&rarr;', 'previous': $('html').attr('dir') == 'rtl' ? '&rarr;' : '&larr;' }
            }
        });

        // Basic datatable
        $('.datatable-basic').DataTable({
            select: {
                style: 'single'
            },
            buttons: {
                dom: {
                    button: {
                        className: 'btn btn-light'
                    }
                },
                buttons: [
                    {
                        extend: 'csvHtml5',
                        title: 'TRF1500 1'
                    },
                    {
                        extend: 'excelHtml5',
                        title: 'TRF1500 1'
                    },
                    {
                        extend: 'csvHtml5',
                        title: 'TRF1500 1'
                    }
                ]
            },
            "bDestroy": true
        });

        // Resize scrollable table when sidebar width changes
        $('.sidebar-control').on('click', function () {
            table.columns.adjust().draw();
        });
    };

    return {
        init: function () {
            _componentDatatableBasic();
        }
    }
}();

var DateTimePickers = function () {

    // Setup module components
    var _componentDaterange = function () {
        if (!$().daterangepicker) {
            console.warn('Warning - daterangepicker.js is not loaded.');
            return;
        }

        // Basic initialization
        $('.daterange-basic').daterangepicker({
            parentEl: '.content-inner',
        });

        $('.daterange-time').daterangepicker({
            parentEl: '.content-inner',
            timePicker: true,
            locale: {
                format: 'MM/DD/YYYY h:mm a'
            }
        });
    };

    return {
        init: function () {
            _componentDaterange();
        }
    }
}();

document.addEventListener('DOMContentLoaded', function () {
    DatatableBasic.init();
    DateTimePickers.init();
});

function getLineas() {
    $.ajax({
        type: "GET",
        url: "/Catalogo/get_maquinas_dropdown_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {
                var data = [];
                response.forEach(function (response) {
                    var obj = {
                        id: response.id,
                        text: response.nombre
                    };
                    data.push(obj);
                });
                $("#lineasDropdown").select2({
                    data: data
                });
            } else {
                console.log("Something went wrong");
            }
        },
        failure: function (response) {
            console.log(response.responseText);
        },
        error: function (response) {
            console.log(response.responseText);
        }
    });
}