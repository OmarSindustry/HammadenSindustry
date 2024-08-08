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
            columnDefs: [{
                orderable: false,
                width: 100,
                targets: [0]
            }],
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








document.addEventListener('DOMContentLoaded', function () {
    DatatableBasic.init();

    getEstaciones();
    reporteGenerar(1);

});

function reporteGenerar(id) {

    $.ajax({

        type: "GET",
        url: "/Catalogo/get_modelos_Json",
        data: { 'id': id },
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

    

    $('#torque').DataTable().destroy();

    // tableTorques.clear().draw();

    $('#torque').dataTable({

        "order": [],

        data: oResults,
        "columns": [
            { "data": "model_code" },
            { "data": "part_number" },
            { "data": "piezas_golpe" },
            { "data": "spm" },
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

function editar_modelo() {

    var table = $('#torque').DataTable();


    if (table.rows('.selected').any()) {

        
        var id = table.rows({ selected: true }).data()[0].id;

        document.getElementById("model_codeEditar").value = table.rows({ selected: true }).data()[0].model_code;
        document.getElementById("part_numberEditar").value = table.rows({ selected: true }).data()[0].part_number;
        document.getElementById("piezas_golpeEditar").value = table.rows({ selected: true }).data()[0].piezas_golpe;
        document.getElementById("spmEditar").value = table.rows({ selected: true }).data()[0].spm;

        $('#editar_modal').modal('show');


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

    var table = $('#torque').DataTable();

    var id = table.rows({ selected: true }).data()[0].id;
    var part_number = $("#part_numberEditar").val();
    var piezas_golpe = $("#piezas_golpeEditar").val();
    var spm = $("#spmEditar").val();


    $.ajax({

        type: "GET",
        url: "/Catalogo/edit_modelo_Json",
        data: { 'id': id, 'part_number': part_number, 'piezas_golpe': piezas_golpe, 'spm' : spm },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {


                if (response['resultado'] == 0) {

                    $('#editar_modal').modal('hide');

                    var id = $("#modelosDropdown").val();
                    reporteGenerar(id);

                    swalInit.fire({
                        title: '¡Editado Correctemente!',
                        text: 'Se ha editado la herramienta correctamente',
                        icon: 'success'
                    });


                }
                else {

                    $('#editarEstacion').modal('hide');
                    swalInit.fire({
                        title: 'Good job!',
                        text: 'You clicked the button!',
                        icon: 'success'
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




$("#modelosDropdown").on('change', function () {

    $('#loader').modal('show');
    var id = $("#modelosDropdown").val();
    reporteGenerar(id);
});

function getEstaciones() {

    $.ajax({

        type: "GET",
        url: "/Catalogo/get_modelos_dropdown_Json",
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


                $("#modelosDropdown").select2({
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

