/* ------------------------------------------------------------------------------
 *
 *  # Echarts - Basic gauge example
 *
 *  Demo JS code for baic gauge chart [light theme]
 *
 * ---------------------------------------------------------------------------- */


// Initialize module
// ------------------------------
document.addEventListener('DOMContentLoaded', function () {

    getTRF1500_1();
    getTRF1500_2();
    getTRF2500();
    getStamping(); 
    getStampingKayasaki();

    const interval = setInterval(function () {
        getTRF1500_1();
        getTRF1500_2();
        getTRF2500();
        getStamping(); 
        getStampingKayasaki();

    }, 5000);

    

});


function getStampingKayasaki() {

    $.ajax({

        type: "GET",
        url: "/Home/Get_last_StampingKayasaki_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                $("#stamping_kayasaki_contador").text(response[0].contador);
                $("#stamping_kayasaki_numero_parte").text(response[0].numero_parte);
                $("#stamping_kayasaki_numero_parte_siguiente").text(response[0].numero_parte_siguiente);
                $("#stamping_kayasaki_modelo").text(response[0].modelo);
                $("#stamping_kayasaki_spm").text(response[0].spm);
                $("#stamping_kayasaki_proyectado").text(response[0].proyectado);


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
function getStamping() {

    $.ajax({

        type: "GET",
        url: "/Home/Get_last_Stamping_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {


                $("#stamping_contador").text(response[0].contador);
                $("#stamping_numero_parte").text(response[0].numero_parte);
                $("#stamping_numero_parte_siguiente").text(response[0].numero_parte_siguiente);
                $("#stamping_modelo").text(response[0].modelo);
                $("#stamping_spm").text(response[0].spm);
                $("#stamping_proyectado").text(response[0].proyectado);

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
function getTRF2500() {

    $.ajax({

        type: "GET",
        url: "/Home/Get_last_trf2500_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {


                $("#trf2500_contador").text(response[0].contador);
                $("#trf2500_numero_parte").text(response[0].numero_parte);
                $("#trf2500_numero_parte_siguiente").text(response[0].numero_parte_siguiente);
                $("#trf2500_modelo").text(response[0].modelo);
                $("#trf2500_spm").text(response[0].spm);
                $("#trf2500_proyectado").text(response[0].proyectado);

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
function getTRF1500_1() {

    $.ajax({

        type: "GET",
        url: "/Home/Get_last_trf1500_1_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {


                $("#trf1500_1_contador").text(response[0].contador);
                $("#trf1500_1_numero_parte").text(response[0].numero_parte);
                $("#trf1500_1_numero_parte_siguiente").text(response[0].numero_parte_siguiente);
                $("#trf1500_1_modelo").text(response[0].modelo);
                $("#trf1500_1_spm").text(response[0].spm);
                $("#trf1500_1_proyectado").text(response[0].proyectado);

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
function getTRF1500_2() {

    $.ajax({

        type: "GET",
        url: "/Home/Get_last_trf1500_2_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {


                $("#trf1500_2_contador").text(response[0].contador);
                $("#trf1500_2_numero_parte").text(response[0].numero_parte);
                $("#trf1500_2_numero_parte_siguiente").text(response[0].numero_parte_siguiente);
                $("#trf1500_2_modelo").text(response[0].modelo);
                $("#trf1500_2_spm").text(response[0].spm);
                $("#trf1500_2_proyectado").text(response[0].proyectado);

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














