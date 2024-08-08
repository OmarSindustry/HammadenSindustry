/* ------------------------------------------------------------------------------
 *
 *  # Basic datatables
 *
 *  Demo JS code for datatable_basic.html page
 *
 * ---------------------------------------------------------------------------- */


// Initialize module
// ------------------------------

var swalInit = swal.mixin({
    buttonsStyling: false,
    customClass: {
        confirmButton: 'btn btn-primary',
        cancelButton: 'btn btn-light',
        denyButton: 'btn btn-light',
        input: 'form-control'
    }
});

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
            autoWidth: false,
            //columnDefs: [{
            //    orderable: false,
            //    width: 100,
            //    targets: [2]
            //}],
            dom: '<"datatable-header"fl><"datatable-scroll"t><"datatable-footer"ip>',
            language: {
                search: '<span>Filter:</span> _INPUT_',
                searchPlaceholder: 'Type to filter...',
                lengthMenu: '<span>Show:</span> _MENU_',
                paginate: { 'first': 'First', 'last': 'Last', 'next': $('html').attr('dir') == 'rtl' ? '&larr;' : '&rarr;', 'previous': $('html').attr('dir') == 'rtl' ? '&rarr;' : '&larr;' }
            }
        });

        // Apply custom style to select
        $.extend($.fn.dataTableExt.oStdClasses, {
            "sLengthSelect": "custom-select"
        });

        // Basic datatable
        tableTorques = $('.datatable-basic').DataTable();


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

var Select2Selects = function () {


    //
    // Setup module components
    //

    // Select2 examples
    var _componentSelect2 = function () {
        if (!$().select2) {
            console.warn('Warning - select2.min.js is not loaded.');
            return;
        }


        //
        // Basic examples
        //

        // Select with search
        $('.select-search').select2({
            dropdownParent: $('#editarModal')
        });


    };


    //
    // Return objects assigned to module
    //

    return {
        init: function () {
            _componentSelect2();
        }
    }
}();
// ------------------------------
// Initialize module
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
            parentEl: '.content-inner'
        });

        // Display week numbers
        $('.daterange-weeknumbers').daterangepicker({
            parentEl: '.content-inner',
            showWeekNumbers: true
        });

        // Button class options
        $('.daterange-buttons').daterangepicker({
            parentEl: '.content-inner',
            applyClass: 'btn-success',
            cancelClass: 'btn-danger'
        });

        // Display time picker
        $('.daterange-time').daterangepicker({
            parentEl: '.content-inner',
            timePicker: true,
            locale: {
                format: 'MM/DD/YYYY h:mm a'
            }
        });

        // Show picker on right
        $('.daterange-left').daterangepicker({
            parentEl: '.content-inner',
            opens: 'left'
        });

        // Single picker
        $('.daterange-single').daterangepicker({
            parentEl: '.content-inner',
            singleDatePicker: true
        });

        // Display date dropdowns
        $('.daterange-datemenu').daterangepicker({
            parentEl: '.content-inner',
            showDropdowns: true
        });

        // 10 minute increments
        $('.daterange-increments').daterangepicker({
            parentEl: '.content-inner',
            timePicker: true,
            timePickerIncrement: 10,
            locale: {
                format: 'MM/DD/YYYY h:mm a'
            }
        });

        // Localization
        $('.daterange-locale').daterangepicker({
            parentEl: '.content-inner',
            ranges: {
                'Сегодня': [moment(), moment()],
                'Вчера': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                'Последние 7 дней': [moment().subtract(6, 'days'), moment()],
                'Последние 30 дней': [moment().subtract(29, 'days'), moment()],
                'Этот месяц': [moment().startOf('month'), moment().endOf('month')],
                'Прошедший месяц': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
            },
            locale: {
                applyLabel: 'Вперед',
                cancelLabel: 'Отмена',
                startLabel: 'Начальная дата',
                endLabel: 'Конечная дата',
                customRangeLabel: 'Выбрать дату',
                daysOfWeek: ['Вс', 'Пн', 'Вт', 'Ср', 'Чт', 'Пт', 'Сб'],
                monthNames: ['Январь', 'Февраль', 'Март', 'Апрель', 'Май', 'Июнь', 'Июль', 'Август', 'Сентябрь', 'Октябрь', 'Ноябрь', 'Декабрь'],
                firstDay: 1
            }
        });


        //
        // Pre-defined ranges and callback
        //

        // Initialize with options
        $('.daterange-predefined').daterangepicker(
            {
                startDate: moment().subtract(29, 'days'),
                endDate: moment(),
                minDate: '01/01/2014',
                maxDate: '12/12/2019',
                dateLimit: { days: 60 },
                parentEl: '.content-inner',
                ranges: {
                    'Today': [moment(), moment()],
                    'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                    'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                    'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                    'This Month': [moment().startOf('month'), moment().endOf('month')],
                    'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
                }
            },
            function (start, end) {
                $('.daterange-predefined span').html(start.format('MMMM D, YYYY') + ' &nbsp; - &nbsp; ' + end.format('MMMM D, YYYY'));
                $.jGrowl('Date range has been changed', { header: 'Update', theme: 'bg-primary text-white', position: 'center', life: 1500 });
            }
        );

        // Display date format
        $('.daterange-predefined span').html(moment().subtract(29, 'days').format('MMMM D, YYYY') + ' &nbsp; - &nbsp; ' + moment().format('MMMM D, YYYY'));


        //
        // Inside button
        //

        // Initialize with options
        $('.daterange-ranges').daterangepicker(
            {
                startDate: moment().subtract(29, 'days'),
                endDate: moment(),
                minDate: '01/01/2012',
                maxDate: '12/31/2019',
                dateLimit: { days: 60 },
                parentEl: '.content-inner',
                ranges: {
                    'Today': [moment(), moment()],
                    'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                    'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                    'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                    'This Month': [moment().startOf('month'), moment().endOf('month')],
                    'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
                }
            },
            function (start, end) {
                $('.daterange-ranges span').html(start.format('MMMM D, YYYY') + ' &nbsp; - &nbsp; ' + end.format('MMMM D, YYYY'));
            }
        );

        // Display date format
        $('.daterange-ranges span').html(moment().subtract(29, 'days').format('MMMM D, YYYY') + ' &nbsp; - &nbsp; ' + moment().format('MMMM D, YYYY'));
    };

    // Pickadate picker
    var _componentPickadate = function () {
        if (!$().pickadate) {
            console.warn('Warning - picker.js and/or picker.date.js is not loaded.');
            return;
        }

        // Basic options
        $('.pickadate').pickadate();

        // Change day names
        $('.pickadate-strings').pickadate({
            weekdaysShort: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'],
            showMonthsShort: true
        });

        // Button options
        $('.pickadate-buttons').pickadate({
            today: '',
            close: '',
            clear: 'Clear selection'
        });

        // Accessibility labels
        $('.pickadate-accessibility').pickadate({
            labelMonthNext: 'Go to the next month',
            labelMonthPrev: 'Go to the previous month',
            labelMonthSelect: 'Pick a month from the dropdown',
            labelYearSelect: 'Pick a year from the dropdown',
            selectMonths: true,
            selectYears: true
        });

        // Localization
        $('.pickadate-translated').pickadate({
            monthsFull: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
            weekdaysShort: ['Dim', 'Lun', 'Mar', 'Mer', 'Jeu', 'Ven', 'Sam'],
            today: 'aujourd\'hui',
            clear: 'effacer',
            formatSubmit: 'yyyy/mm/dd'
        });

        // Format options
        $('.pickadate-format').pickadate({

            // Escape any “rule” characters with an exclamation mark (!).
            format: 'You selecte!d: dddd, dd mmm, yyyy',
            formatSubmit: 'yyyy/mm/dd',
            hiddenPrefix: 'prefix__',
            hiddenSuffix: '__suffix'
        });

        // Editable input
        $('.pickadate-editable').pickadate({
            editable: true
        });

        // Dropdown selectors
        $('.pickadate-selectors').pickadate({
            selectYears: true,
            selectMonths: true
        });

        // Year selector
        $('.pickadate-year').pickadate({
            selectYears: 4
        });

        // Set first weekday
        $('.pickadate-weekday').pickadate({
            firstDay: 1
        });

        // Date limits
        $('.pickadate-limits').pickadate({
            min: [2014, 3, 20],
            max: [2014, 7, 14]
        });

        // Disable certain dates
        $('.pickadate-disable').pickadate({
            disable: [
                [2015, 8, 3],
                [2015, 8, 12],
                [2015, 8, 20]
            ]
        });

        // Disable date range
        $('.pickadate-disable-range').pickadate({
            disable: [
                5,
                [2013, 10, 21, 'inverted'],
                { from: [2014, 3, 15], to: [2014, 3, 25] },
                [2014, 3, 20, 'inverted'],
                { from: [2014, 3, 17], to: [2014, 3, 18], inverted: true }
            ]
        });

        // Events
        $('.pickadate-events').pickadate({
            onStart: function () {
                console.log('Hello there :)')
            },
            onRender: function () {
                console.log('Whoa.. rendered anew')
            },
            onOpen: function () {
                console.log('Opened up')
            },
            onClose: function () {
                console.log('Closed now')
            },
            onStop: function () {
                console.log('See ya.')
            },
            onSet: function (context) {
                console.log('Just set stuff:', context)
            }
        });
    };

    // Pickatime picker
    var _componentPickatime = function () {
        if (!$().pickatime) {
            console.warn('Warning - picker.js and/or picker.time.js is not loaded.');
            return;
        }

        // Default functionality
        $('.pickatime').pickatime({
            format: 'HH:i',
        });


        // Events
        $('.pickatime-events').pickatime({
            onStart: function () {
                console.log('Hello there :)')
            },
            onRender: function () {
                console.log('Whoa.. rendered anew')
            },
            onOpen: function () {
                console.log('Opened up')
            },
            onClose: function () {
                console.log('Closed now')
            },
            onStop: function () {
                console.log('See ya.')
            },
            onSet: function (context) {
                console.log('Just set stuff:', context)
            }
        });
    };


    //
    // Return objects assigned to module
    //

    return {
        init: function () {
            _componentDaterange();
            _componentPickadate();
            _componentPickatime();
        }
    }
}();




document.addEventListener('DOMContentLoaded', function () {

    DatatableBasic.init();
    Select2Selects.init();
    DateTimePickers.init();
    reporteGenerar();



});


// Funciones 
// ------------------------------

function reporteGenerar() {


    $.ajax({

        type: "GET",
        url: "/catalogo/get_horarios_json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                console.log(response);
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


    $('#lineas').DataTable().destroy();

    // tableTorques.clear().draw();

    $('#lineas').dataTable({

        "order": [],

        data: oResults,
        "columns": [
            { "data": "nombre" },
            { "data": "descripcion" },
            { "data": "horario_inicio" },
            { "data": "horario_fin" },
        ],
        initComplete: function () {
            setTimeout(function () {
                $('#loader').modal('hide');
            }, 500);


        },
        select: {
            style: 'single'
        }


    });




}




function agregar_click() {


    document.getElementById("descripcion").value = "";
    document.getElementById("nombre").value = "";


    $('#agregarModal').modal('show');

}


function editar_click() {


    var table = $('#lineas').DataTable();

    if (table.rows('.selected').any()) {


        document.getElementById("nombreEditar").value = table.rows({ selected: true }).data()[0].nombre;
        document.getElementById("horario_inicioEditar").value = table.rows({ selected: true }).data()[0].horario_inicio;
        document.getElementById("horario_finEditar").value = table.rows({ selected: true }).data()[0].horario_fin;




        $('#editarModal').modal('show');


    } else {

        swalInit.fire({
            title: '¡Sin selección!',
            text: 'Seleccionar una herraimenta',
            icon: 'warning',
            showCloseButton: true
        });

    }

}

function submit_editar() {

    var table = $('#lineas').DataTable();

    var horario_id = table.rows({ selected: true }).data()[0].horario_id;
    var nombre = document.getElementById("nombreEditar").value;
    var horario_inicio = document.getElementById("horario_inicioEditar").value;

    var a = horario_inicio.split(':');
    var hora_inicio = a[0] + ':' + a[1];
    console.log(hora_inicio);

    var horario_fin = document.getElementById("horario_finEditar").value;

    var b = horario_fin.split(':');
    var hora_fin = b[0] + ':' + b[1];
    console.log(hora_fin);





    $.ajax({

        type: "GET",
        url: "/Catalogo/edit_horarios_json",
        data: { 'horario_id': horario_id, 'nombre': nombre, 'horario_inicio': hora_inicio, 'horario_fin': hora_fin },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {


                if (response['resultado'] == 0) {

                    $('#editarModal').modal('hide');

                    reporteGenerar();

                    swalInit.fire({
                        title: '¡Editado Correctemente!',
                        text: response['mensaje'],
                        icon: 'success'
                    });


                }
                else {

                    $('#editarEstacion').modal('hide');
                    swalInit.fire({
                        title: 'Error',
                        text: response['mensaje'],
                        icon: 'error'
                    });

                }


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




/// 
// ------------------------
// dropdown 


function getLineas() {


    $.ajax({

        type: "GET",
        url: "/catalogos/get_lineas_dropdown_json",
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


                $("#lineasDropdownAgregar").select2({
                    data: data,
                    dropdownParent: $('#agregarModal')
                });

                $("#lineasDropdownEditar").select2({
                    data: data,
                    dropdownParent: $('#editarModal')
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