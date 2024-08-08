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


    //
    // Setup module components
    //

    // Basic Datatable examples
    var _componentDatatableBasic = function () {
        if (!$().DataTable) {
            console.warn('Warning - datatables.min.js is not loaded.');
            return;
        }

        // Setting datatable defaults
        $.extend($.fn.dataTable.defaults, {
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
                        title: 'TRF1500 2'
                    },
                    {
                        extend: 'excelHtml5',
                        title: 'TRF1500 2'
                    },
                    {
                        extend: 'csvHtml5',
                        title: 'TRF1500 2'
                    }
                ]
            },
            "bDestroy": true
        }
        );


        // Resize scrollable table when sidebar width changes
        $('.sidebar-control').on('click', function () {
            table.columns.adjust().draw();
        });
    };


    //
    // Return objects assigned to module
    //

    return {
        init: function () {
            _componentDatatableBasic();
        }
    }
}();


var DateTimePickers = function () {


    //
    // Setup module components
    //

    // Daterange picker
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

    // Pickadate picker
    var _componentPickadate = function () {
        if (!$().pickadate) {
            console.warn('Warning - picker.js and/or picker.date.js is not loaded.');
            return;
        }

        // Basic options
        $('.pickadate').pickadate();


    };

    // Pickatime picker
    var _componentPickatime = function () {
        if (!$().pickatime) {
            console.warn('Warning - picker.js and/or picker.time.js is not loaded.');
            return;
        }

        // Default functionality
        $('.pickatime').pickatime();


    };


    //
    // Return objects assigned to module
    //

    return {
        init: function () {
            _componentDaterange();
        }
    }
}();

// Initialize module
// ------------------------------

document.addEventListener('DOMContentLoaded', function () {
    DatatableBasic.init();
    DateTimePickers.init();


});

function reporteGenerar() {


    $('#loader').modal('show');


    var fechaInicial = $('#datetimepicker').data('daterangepicker').startDate.format('YYYY-MM-DD HH:mm');
    var fechaFinal = $('#datetimepicker').data('daterangepicker').endDate.format('YYYY-MM-DD HH:mm');



    $.ajax({

        type: "GET",
        url: "/reportes/reporte_get_trf1500_2_historico_Json",
        data: { 'fechaInicial': fechaInicial, 'fechaFinal': fechaFinal},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                console.log(response)

                LoadCurrentReport(response);


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


function LoadCurrentReport(oResults) {

    $('#torques').DataTable().destroy();

    // tableTorques.clear().draw();

    $('#torques').dataTable({
        columnDefs: [
            {
                orderable: false,
                targets: [4]
            },
            {
                width: "150px",
                targets: [0]
            },
            {
                width: "100px",
                targets: [1]
            },
            {
                width: "100px",
                targets: [2, 3, 4]
            }
        ],
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
                'copyHtml5',
                'excelHtml5',
                'csvHtml5'
            ]
        },
        "bDestroy": true,

        select: {
            style: 'single'
        },

        "order": [],


        data: oResults,
        "columns": [
            { "data": "total_golpes" },
            { "data": "modelo" },
            { "data": "numero_parte" },
            { "data": "spm" },
            { "data": "fecha" },


        ],
        initComplete: function () {
            setTimeout(function () {
                $('#loader').modal('hide');
            }, 500);


        }
    });




}

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

                console.log(data);

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
