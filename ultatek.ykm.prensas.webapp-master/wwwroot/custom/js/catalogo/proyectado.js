
var swalInit = swal.mixin({
    buttonsStyling: false,
    customClass: {
        confirmButton: 'btn btn-primary',
        cancelButton: 'btn btn-light',
        denyButton: 'btn btn-light',
        input: 'form-control'
    }
});

document.addEventListener('DOMContentLoaded', function () {


    cargar_proyectado();


});

function cargar_proyectado() {

    $.ajax({

        type: "GET",
        url: "/Catalogo/get_proyectado_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                document.getElementById("num_parte_1_trf1500_1").value =  response[0].model_code;
                document.getElementById("proyectado_1_trf1500_1").value = response[0].proyectado;

                document.getElementById("num_parte_2_trf1500_1").value = response[1].model_code;
                document.getElementById("proyectado_2_trf1500_1").value = response[1].proyectado;

                document.getElementById("num_parte_3_trf1500_1").value = response[2].model_code;
                document.getElementById("proyectado_3_trf1500_1").value = response[2].proyectado;

                document.getElementById("num_parte_4_trf1500_1").value = response[3].model_code;
                document.getElementById("proyectado_4_trf1500_1").value = response[3].proyectado;

                document.getElementById("num_parte_5_trf1500_1").value = response[4].model_code;
                document.getElementById("proyectado_5_trf1500_1").value = response[4].proyectado;

                document.getElementById("num_parte_6_trf1500_1").value = response[5].model_code;
                document.getElementById("proyectado_6_trf1500_1").value = response[5].proyectado;

                document.getElementById("num_parte_7_trf1500_1").value = response[6].model_code;
                document.getElementById("proyectado_7_trf1500_1").value = response[6].proyectado;

                document.getElementById("num_parte_8_trf1500_1").value = response[7].model_code;
                document.getElementById("proyectado_8_trf1500_1").value = response[7].proyectado;

                document.getElementById("num_parte_9_trf1500_1").value = response[8].model_code;
                document.getElementById("proyectado_9_trf1500_1").value = response[8].proyectado;

                document.getElementById("num_parte_10_trf1500_1").value = response[9].model_code;
                document.getElementById("proyectado_10_trf1500_1").value = response[9].proyectado;

                document.getElementById("num_parte_11_trf1500_1").value = response[10].model_code;
                document.getElementById("proyectado_11_trf1500_1").value = response[10].proyectado;

                document.getElementById("num_parte_12_trf1500_1").value = response[11].model_code;
                document.getElementById("proyectado_12_trf1500_1").value = response[11].proyectado;



                document.getElementById("num_parte_1_trf1500_2").value = response[12].model_code;
                document.getElementById("proyectado_1_trf1500_2").value = response[12].proyectado;

                document.getElementById("num_parte_2_trf1500_2").value = response[13].model_code;
                document.getElementById("proyectado_2_trf1500_2").value = response[13].proyectado;

                document.getElementById("num_parte_3_trf1500_2").value = response[14].model_code;
                document.getElementById("proyectado_3_trf1500_2").value = response[14].proyectado;

                document.getElementById("num_parte_4_trf1500_2").value = response[15].model_code;
                document.getElementById("proyectado_4_trf1500_2").value = response[15].proyectado;

                document.getElementById("num_parte_5_trf1500_2").value = response[16].model_code;
                document.getElementById("proyectado_5_trf1500_2").value = response[16].proyectado;

                document.getElementById("num_parte_6_trf1500_2").value = response[17].model_code;
                document.getElementById("proyectado_6_trf1500_2").value = response[17].proyectado;

                document.getElementById("num_parte_7_trf1500_2").value = response[18].model_code;
                document.getElementById("proyectado_7_trf1500_2").value = response[18].proyectado;

                document.getElementById("num_parte_8_trf1500_2").value = response[19].model_code;
                document.getElementById("proyectado_8_trf1500_2").value = response[19].proyectado;

                document.getElementById("num_parte_9_trf1500_2").value = response[20].model_code;
                document.getElementById("proyectado_9_trf1500_2").value = response[20].proyectado;

                document.getElementById("num_parte_10_trf1500_2").value = response[21].model_code;
                document.getElementById("proyectado_10_trf1500_2").value = response[21].proyectado;

                document.getElementById("num_parte_11_trf1500_2").value = response[22].model_code;
                document.getElementById("proyectado_11_trf1500_2").value = response[22].proyectado;

                document.getElementById("num_parte_12_trf1500_2").value = response[23].model_code;
                document.getElementById("proyectado_12_trf1500_2").value = response[23].proyectado;


                document.getElementById("num_parte_1_trf2500").value = response[24].model_code;
                document.getElementById("proyectado_1_trf2500").value = response[24].proyectado;

                document.getElementById("num_parte_2_trf2500").value = response[25].model_code;
                document.getElementById("proyectado_2_trf2500").value = response[25].proyectado;

                document.getElementById("num_parte_3_trf2500").value = response[26].model_code;
                document.getElementById("proyectado_3_trf2500").value = response[26].proyectado;

                document.getElementById("num_parte_4_trf2500").value = response[27].model_code;
                document.getElementById("proyectado_4_trf2500").value = response[27].proyectado;

                document.getElementById("num_parte_5_trf2500").value = response[28].model_code;
                document.getElementById("proyectado_5_trf2500").value = response[28].proyectado;

                document.getElementById("num_parte_6_trf2500").value = response[29].model_code;
                document.getElementById("proyectado_6_trf2500").value = response[29].proyectado;

                document.getElementById("num_parte_7_trf2500").value = response[30].model_code;
                document.getElementById("proyectado_7_trf2500").value = response[30].proyectado;

                document.getElementById("num_parte_8_trf2500").value = response[31].model_code;
                document.getElementById("proyectado_8_trf2500").value = response[31].proyectado;

                document.getElementById("num_parte_9_trf2500").value = response[32].model_code;
                document.getElementById("proyectado_9_trf2500").value = response[32].proyectado;

                document.getElementById("num_parte_10_trf2500").value = response[33].model_code;
                document.getElementById("proyectado_10_trf2500").value = response[33].proyectado;

                document.getElementById("num_parte_11_trf2500").value = response[34].model_code;
                document.getElementById("proyectado_11_trf2500").value = response[34].proyectado;

                document.getElementById("num_parte_12_trf2500").value = response[35].model_code;
                document.getElementById("proyectado_12_trf2500").value = response[35].proyectado;



                document.getElementById("num_parte_1_stamping").value = response[36].model_code;
                document.getElementById("proyectado_1_stamping").value = response[36].proyectado;

                document.getElementById("num_parte_2_stamping").value = response[37].model_code;
                document.getElementById("proyectado_2_stamping").value = response[37].proyectado;

                document.getElementById("num_parte_3_stamping").value = response[38].model_code;
                document.getElementById("proyectado_3_stamping").value = response[38].proyectado;

                document.getElementById("num_parte_4_stamping").value = response[39].model_code;
                document.getElementById("proyectado_4_stamping").value = response[39].proyectado;

                document.getElementById("num_parte_5_stamping").value = response[40].model_code;
                document.getElementById("proyectado_5_stamping").value = response[40].proyectado;

                document.getElementById("num_parte_6_stamping").value = response[41].model_code;
                document.getElementById("proyectado_6_stamping").value = response[41].proyectado;

                document.getElementById("num_parte_7_stamping").value = response[42].model_code;
                document.getElementById("proyectado_7_stamping").value = response[42].proyectado;

                document.getElementById("num_parte_8_stamping").value = response[43].model_code;
                document.getElementById("proyectado_8_stamping").value = response[43].proyectado;

                document.getElementById("num_parte_9_stamping").value = response[44].model_code;
                document.getElementById("proyectado_9_stamping").value = response[44].proyectado;

                document.getElementById("num_parte_10_stamping").value = response[45].model_code;
                document.getElementById("proyectado_10_stamping").value = response[45].proyectado;

                document.getElementById("num_parte_11_stamping").value = response[46].model_code;
                document.getElementById("proyectado_11_stamping").value = response[46].proyectado;

                document.getElementById("num_parte_12_stamping").value = response[47].model_code;
                document.getElementById("proyectado_12_stamping").value = response[47].proyectado;




                document.getElementById("num_parte_1_stamping_kayasaki").value = response[48].model_code;
                document.getElementById("proyectado_1_stamping_kayasaki").value = response[48].proyectado;

                document.getElementById("num_parte_2_stamping_kayasaki").value = response[49].model_code;
                document.getElementById("proyectado_2_stamping_kayasaki").value = response[49].proyectado;

                document.getElementById("num_parte_3_stamping_kayasaki").value = response[50].model_code;
                document.getElementById("proyectado_3_stamping_kayasaki").value = response[50].proyectado;

                document.getElementById("num_parte_4_stamping_kayasaki").value = response[51].model_code;
                document.getElementById("proyectado_4_stamping_kayasaki").value = response[51].proyectado;

                document.getElementById("num_parte_5_stamping_kayasaki").value = response[52].model_code;
                document.getElementById("proyectado_5_stamping_kayasaki").value = response[52].proyectado;

                document.getElementById("num_parte_6_stamping_kayasaki").value = response[53].model_code;
                document.getElementById("proyectado_6_stamping_kayasaki").value = response[53].proyectado;

                document.getElementById("num_parte_7_stamping_kayasaki").value = response[54].model_code;
                document.getElementById("proyectado_7_stamping_kayasaki").value = response[54].proyectado;

                document.getElementById("num_parte_8_stamping_kayasaki").value = response[55].model_code;
                document.getElementById("proyectado_8_stamping_kayasaki").value = response[55].proyectado;

                document.getElementById("num_parte_9_stamping_kayasaki").value = response[56].model_code;
                document.getElementById("proyectado_9_stamping_kayasaki").value = response[56].proyectado;

                document.getElementById("num_parte_10_stamping_kayasaki").value = response[57].model_code;
                document.getElementById("proyectado_10_stamping_kayasaki").value = response[57].proyectado;

                document.getElementById("num_parte_11_stamping_kayasaki").value = response[58].model_code;
                document.getElementById("proyectado_11_stamping_kayasaki").value = response[58].proyectado;

                document.getElementById("num_parte_12_stamping_kayasaki").value = response[59].model_code;
                document.getElementById("proyectado_12_stamping_kayasaki").value = response[59].proyectado;

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


function editar_1500_1(){

    var num_parte_1 = document.getElementById("num_parte_1_trf1500_1").value ;
    var proyectado_1 = document.getElementById("proyectado_1_trf1500_1").value;

    var num_parte_2 = document.getElementById("num_parte_2_trf1500_1").value ;
    var proyectado_2 = document.getElementById("proyectado_2_trf1500_1").value;

    var num_parte_3 = document.getElementById("num_parte_3_trf1500_1").value ;
    var proyectado_3 = document.getElementById("proyectado_3_trf1500_1").value;

    var num_parte_4 = document.getElementById("num_parte_4_trf1500_1").value ;
    var proyectado_4 = document.getElementById("proyectado_4_trf1500_1").value;

    var num_parte_5 = document.getElementById("num_parte_5_trf1500_1").value ;
    var proyectado_5 = document.getElementById("proyectado_5_trf1500_1").value;

    var num_parte_6 = document.getElementById("num_parte_6_trf1500_1").value ;
    var proyectado_6 = document.getElementById("proyectado_6_trf1500_1").value;

    var num_parte_7 = document.getElementById("num_parte_7_trf1500_1").value ;
    var proyectado_7 = document.getElementById("proyectado_7_trf1500_1").value;

    var num_parte_8 = document.getElementById("num_parte_8_trf1500_1").value ;
    var proyectado_8 = document.getElementById("proyectado_8_trf1500_1").value;

    var num_parte_9 = document.getElementById("num_parte_9_trf1500_1").value ;
    var proyectado_9 = document.getElementById("proyectado_9_trf1500_1").value;

    var num_parte_10 = document.getElementById("num_parte_10_trf1500_1").value ;
    var proyectado_10 = document.getElementById("proyectado_10_trf1500_1").value;

    var num_parte_11 = document.getElementById("num_parte_11_trf1500_1").value ;
    var proyectado_11 = document.getElementById("proyectado_11_trf1500_1").value;

    var num_parte_12 = document.getElementById("num_parte_12_trf1500_1").value ;
    var proyectado_12 = document.getElementById("proyectado_12_trf1500_1").value;

    $.ajax({

        type: "GET",
        url: "/Catalogo/edit_proyectado_trf1500_1_Json",
        data: {
            'num_parte_1': num_parte_1, 'proyectado_1': proyectado_1,
            'num_parte_2': num_parte_2, 'proyectado_2': proyectado_2,
            'num_parte_3': num_parte_3, 'proyectado_3': proyectado_3,
            'num_parte_4': num_parte_4, 'proyectado_4': proyectado_4,
            'num_parte_5': num_parte_5, 'proyectado_5': proyectado_5,
            'num_parte_6': num_parte_6, 'proyectado_6': proyectado_6,
            'num_parte_7': num_parte_7, 'proyectado_7': proyectado_7,
            'num_parte_8': num_parte_8, 'proyectado_8': proyectado_8,
            'num_parte_9': num_parte_9, 'proyectado_9': proyectado_9,
            'num_parte_10': num_parte_10, 'proyectado_10': proyectado_10,
            'num_parte_11': num_parte_11, 'proyectado_11': proyectado_11,
            'num_parte_12': num_parte_12, 'proyectado_12': proyectado_12

        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                if (response['resultado'] == 0) {

                   

                    cargar_proyectado();

                    swalInit.fire({
                        title: '¡Editado Correctamente!',
                        text: 'Se ha editado correctamente',
                        icon: 'success'
                    });


                }
                else {

                    $('#trf1500_1_modal').modal('hide');
                    swalInit.fire({
                        title: 'Error al editar',
                        text: 'Formato incorrecto',
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

function editar_1500_2(){

    var num_parte_1 = document.getElementById("num_parte_1_trf1500_2").value;
    var proyectado_1 = document.getElementById("proyectado_1_trf1500_2").value;

    var num_parte_2 = document.getElementById("num_parte_2_trf1500_2").value;
    var proyectado_2 = document.getElementById("proyectado_2_trf1500_2").value;

    var num_parte_3 = document.getElementById("num_parte_3_trf1500_2").value;
    var proyectado_3 = document.getElementById("proyectado_3_trf1500_2").value;

    var num_parte_4 = document.getElementById("num_parte_4_trf1500_2").value;
    var proyectado_4 = document.getElementById("proyectado_4_trf1500_2").value;

    var num_parte_5 = document.getElementById("num_parte_5_trf1500_2").value;
    var proyectado_5 = document.getElementById("proyectado_5_trf1500_2").value;

    var num_parte_6 = document.getElementById("num_parte_6_trf1500_2").value;
    var proyectado_6 = document.getElementById("proyectado_6_trf1500_2").value;

    var num_parte_7 = document.getElementById("num_parte_7_trf1500_2").value;
    var proyectado_7 = document.getElementById("proyectado_7_trf1500_2").value;

    var num_parte_8 = document.getElementById("num_parte_8_trf1500_2").value;
    var proyectado_8 = document.getElementById("proyectado_8_trf1500_2").value;

    var num_parte_9 = document.getElementById("num_parte_9_trf1500_2").value;
    var proyectado_9 = document.getElementById("proyectado_9_trf1500_2").value;

    var num_parte_10 = document.getElementById("num_parte_10_trf1500_2").value;
    var proyectado_10 = document.getElementById("proyectado_10_trf1500_2").value;

    var num_parte_11 = document.getElementById("num_parte_11_trf1500_2").value;
    var proyectado_11 = document.getElementById("proyectado_11_trf1500_2").value;

    var num_parte_12 = document.getElementById("num_parte_12_trf1500_2").value;
    var proyectado_12 = document.getElementById("proyectado_12_trf1500_2").value;

    $.ajax({

        type: "GET",
        url: "/Catalogo/edit_proyectado_trf1500_2_Json",
        data: {
            'num_parte_1': num_parte_1, 'proyectado_1': proyectado_1,
            'num_parte_2': num_parte_2, 'proyectado_2': proyectado_2,
            'num_parte_3': num_parte_3, 'proyectado_3': proyectado_3,
            'num_parte_4': num_parte_4, 'proyectado_4': proyectado_4,
            'num_parte_5': num_parte_5, 'proyectado_5': proyectado_5,
            'num_parte_6': num_parte_6, 'proyectado_6': proyectado_6,
            'num_parte_7': num_parte_7, 'proyectado_7': proyectado_7,
            'num_parte_8': num_parte_8, 'proyectado_8': proyectado_8,
            'num_parte_9': num_parte_9, 'proyectado_9': proyectado_9,
            'num_parte_10': num_parte_10, 'proyectado_10': proyectado_10,
            'num_parte_11': num_parte_11, 'proyectado_11': proyectado_11,
            'num_parte_12': num_parte_12, 'proyectado_12': proyectado_12

        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                if (response['resultado'] == 0) {



                    cargar_proyectado();

                    swalInit.fire({
                        title: '¡Editado Correctamente!',
                        text: 'Se ha editado correctamente',
                        icon: 'success'
                    });


                }
                else {

                    $('#trf1500_1_modal').modal('hide');
                    swalInit.fire({
                        title: 'Error al editar',
                        text: 'Formato incorrecto',
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

function editar_2500(){
    var num_parte_1 = document.getElementById("num_parte_1_trf2500").value;
    var proyectado_1 = document.getElementById("proyectado_1_trf2500").value;

    var num_parte_2 = document.getElementById("num_parte_2_trf2500").value;
    var proyectado_2 = document.getElementById("proyectado_2_trf2500").value;

    var num_parte_3 = document.getElementById("num_parte_3_trf2500").value;
    var proyectado_3 = document.getElementById("proyectado_3_trf2500").value;

    var num_parte_4 = document.getElementById("num_parte_4_trf2500").value;
    var proyectado_4 = document.getElementById("proyectado_4_trf2500").value;

    var num_parte_5 = document.getElementById("num_parte_5_trf2500").value;
    var proyectado_5 = document.getElementById("proyectado_5_trf2500").value;

    var num_parte_6 = document.getElementById("num_parte_6_trf2500").value;
    var proyectado_6 = document.getElementById("proyectado_6_trf2500").value;

    var num_parte_7 = document.getElementById("num_parte_7_trf2500").value;
    var proyectado_7 = document.getElementById("proyectado_7_trf2500").value;

    var num_parte_8 = document.getElementById("num_parte_8_trf2500").value;
    var proyectado_8 = document.getElementById("proyectado_8_trf2500").value;

    var num_parte_9 = document.getElementById("num_parte_9_trf2500").value;
    var proyectado_9 = document.getElementById("proyectado_9_trf2500").value;

    var num_parte_10 = document.getElementById("num_parte_10_trf2500").value;
    var proyectado_10 = document.getElementById("proyectado_10_trf2500").value;

    var num_parte_11 = document.getElementById("num_parte_11_trf2500").value;
    var proyectado_11 = document.getElementById("proyectado_11_trf2500").value;

    var num_parte_12 = document.getElementById("num_parte_12_trf2500").value;
    var proyectado_12 = document.getElementById("proyectado_12_trf2500").value;

    $.ajax({

        type: "GET",
        url: "/Catalogo/edit_proyectado_trf2500_Json",
        data: {
            'num_parte_1': num_parte_1, 'proyectado_1': proyectado_1,
            'num_parte_2': num_parte_2, 'proyectado_2': proyectado_2,
            'num_parte_3': num_parte_3, 'proyectado_3': proyectado_3,
            'num_parte_4': num_parte_4, 'proyectado_4': proyectado_4,
            'num_parte_5': num_parte_5, 'proyectado_5': proyectado_5,
            'num_parte_6': num_parte_6, 'proyectado_6': proyectado_6,
            'num_parte_7': num_parte_7, 'proyectado_7': proyectado_7,
            'num_parte_8': num_parte_8, 'proyectado_8': proyectado_8,
            'num_parte_9': num_parte_9, 'proyectado_9': proyectado_9,
            'num_parte_10': num_parte_10, 'proyectado_10': proyectado_10,
            'num_parte_11': num_parte_11, 'proyectado_11': proyectado_11,
            'num_parte_12': num_parte_12, 'proyectado_12': proyectado_12

        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                if (response['resultado'] == 0) {



                    cargar_proyectado();

                    swalInit.fire({
                        title: '¡Editado Correctamente!',
                        text: 'Se ha editado correctamente',
                        icon: 'success'
                    });


                }
                else {

                    $('#trf1500_1_modal').modal('hide');
                    swalInit.fire({
                        title: 'Error al editar',
                        text: 'Formato incorrecto',
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

function editar_stamping(){
    var num_parte_1 = document.getElementById("num_parte_1_stamping").value;
    var proyectado_1 = document.getElementById("proyectado_1_stamping").value;

    var num_parte_2 = document.getElementById("num_parte_2_stamping").value;
    var proyectado_2 = document.getElementById("proyectado_2_stamping").value;

    var num_parte_3 = document.getElementById("num_parte_3_stamping").value;
    var proyectado_3 = document.getElementById("proyectado_3_stamping").value;

    var num_parte_4 = document.getElementById("num_parte_4_stamping").value;
    var proyectado_4 = document.getElementById("proyectado_4_stamping").value;

    var num_parte_5 = document.getElementById("num_parte_5_stamping").value;
    var proyectado_5 = document.getElementById("proyectado_5_stamping").value;

    var num_parte_6 = document.getElementById("num_parte_6_stamping").value;
    var proyectado_6 = document.getElementById("proyectado_6_stamping").value;

    var num_parte_7 = document.getElementById("num_parte_7_stamping").value;
    var proyectado_7 = document.getElementById("proyectado_7_stamping").value;

    var num_parte_8 = document.getElementById("num_parte_8_stamping").value;
    var proyectado_8 = document.getElementById("proyectado_8_stamping").value;

    var num_parte_9 = document.getElementById("num_parte_9_stamping").value;
    var proyectado_9 = document.getElementById("proyectado_9_stamping").value;

    var num_parte_10 = document.getElementById("num_parte_10_stamping").value;
    var proyectado_10 = document.getElementById("proyectado_10_stamping").value;

    var num_parte_11 = document.getElementById("num_parte_11_stamping").value;
    var proyectado_11 = document.getElementById("proyectado_11_stamping").value;

    var num_parte_12 = document.getElementById("num_parte_12_stamping").value;
    var proyectado_12 = document.getElementById("proyectado_12_stamping").value;

    $.ajax({

        type: "GET",
        url: "/Catalogo/edit_proyectado_stamping_Json",
        data: {
            'num_parte_1': num_parte_1, 'proyectado_1': proyectado_1,
            'num_parte_2': num_parte_2, 'proyectado_2': proyectado_2,
            'num_parte_3': num_parte_3, 'proyectado_3': proyectado_3,
            'num_parte_4': num_parte_4, 'proyectado_4': proyectado_4,
            'num_parte_5': num_parte_5, 'proyectado_5': proyectado_5,
            'num_parte_6': num_parte_6, 'proyectado_6': proyectado_6,
            'num_parte_7': num_parte_7, 'proyectado_7': proyectado_7,
            'num_parte_8': num_parte_8, 'proyectado_8': proyectado_8,
            'num_parte_9': num_parte_9, 'proyectado_9': proyectado_9,
            'num_parte_10': num_parte_10, 'proyectado_10': proyectado_10,
            'num_parte_11': num_parte_11, 'proyectado_11': proyectado_11,
            'num_parte_12': num_parte_12, 'proyectado_12': proyectado_12

        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                if (response['resultado'] == 0) {



                    cargar_proyectado();

                    swalInit.fire({
                        title: '¡Editado Correctamente!',
                        text: 'Se ha editado correctamente',
                        icon: 'success'
                    });


                }
                else {

                    $('#trf1500_1_modal').modal('hide');
                    swalInit.fire({
                        title: 'Error al editar',
                        text: 'Formato incorrecto',
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
function editar_stamping_kayasaki(){

    var num_parte_1 = document.getElementById("num_parte_1_stamping_kayasaki").value;
    var proyectado_1 = document.getElementById("proyectado_1_stamping_kayasaki").value;

    var num_parte_2 = document.getElementById("num_parte_2_stamping_kayasaki").value;
    var proyectado_2 = document.getElementById("proyectado_2_stamping_kayasaki").value;

    var num_parte_3 = document.getElementById("num_parte_3_stamping_kayasaki").value;
    var proyectado_3 = document.getElementById("proyectado_3_stamping_kayasaki").value;

    var num_parte_4 = document.getElementById("num_parte_4_stamping_kayasaki").value;
    var proyectado_4 = document.getElementById("proyectado_4_stamping_kayasaki").value;

    var num_parte_5 = document.getElementById("num_parte_5_stamping_kayasaki").value;
    var proyectado_5 = document.getElementById("proyectado_5_stamping_kayasaki").value;

    var num_parte_6 = document.getElementById("num_parte_6_stamping_kayasaki").value;
    var proyectado_6 = document.getElementById("proyectado_6_stamping_kayasaki").value;

    var num_parte_7 = document.getElementById("num_parte_7_stamping_kayasaki").value;
    var proyectado_7 = document.getElementById("proyectado_7_stamping_kayasaki").value;

    var num_parte_8 = document.getElementById("num_parte_8_stamping_kayasaki").value;
    var proyectado_8 = document.getElementById("proyectado_8_stamping_kayasaki").value;

    var num_parte_9 = document.getElementById("num_parte_9_stamping_kayasaki").value;
    var proyectado_9 = document.getElementById("proyectado_9_stamping_kayasaki").value;

    var num_parte_10 = document.getElementById("num_parte_10_stamping_kayasaki").value;
    var proyectado_10 = document.getElementById("proyectado_10_stamping_kayasaki").value;

    var num_parte_11 = document.getElementById("num_parte_11_stamping_kayasaki").value;
    var proyectado_11 = document.getElementById("proyectado_11_stamping_kayasaki").value;

    var num_parte_12 = document.getElementById("num_parte_12_stamping_kayasaki").value;
    var proyectado_12 = document.getElementById("proyectado_12_stamping_kayasaki").value;

    $.ajax({

        type: "GET",
        url: "/Catalogo/edit_proyectado_stamping_kayasaki_Json",
        data: {
            'num_parte_1': num_parte_1, 'proyectado_1': proyectado_1,
            'num_parte_2': num_parte_2, 'proyectado_2': proyectado_2,
            'num_parte_3': num_parte_3, 'proyectado_3': proyectado_3,
            'num_parte_4': num_parte_4, 'proyectado_4': proyectado_4,
            'num_parte_5': num_parte_5, 'proyectado_5': proyectado_5,
            'num_parte_6': num_parte_6, 'proyectado_6': proyectado_6,
            'num_parte_7': num_parte_7, 'proyectado_7': proyectado_7,
            'num_parte_8': num_parte_8, 'proyectado_8': proyectado_8,
            'num_parte_9': num_parte_9, 'proyectado_9': proyectado_9,
            'num_parte_10': num_parte_10, 'proyectado_10': proyectado_10,
            'num_parte_11': num_parte_11, 'proyectado_11': proyectado_11,
            'num_parte_12': num_parte_12, 'proyectado_12': proyectado_12

        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                if (response['resultado'] == 0) {



                    cargar_proyectado();

                    swalInit.fire({
                        title: '¡Editado Correctamente!',
                        text: 'Se ha editado correctamente',
                        icon: 'success'
                    });


                }
                else {

                    $('#trf1500_1_modal').modal('hide');
                    swalInit.fire({
                        title: 'Error al editar',
                        text: 'Formato incorrecto',
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



