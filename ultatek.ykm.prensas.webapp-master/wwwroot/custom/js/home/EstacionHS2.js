/* ------------------------------------------------------------------------------
 *
 *  # Echarts - Basic gauge example
 *
 *  Demo JS code for baic gauge chart [light theme]
 *
 * ---------------------------------------------------------------------------- */

// Defines variables
// ------------------------------

var stamping_kayasaki_actual_element = document.getElementById('produccion_actual');
var stamping_kayasaki_actual_options = {

    // Define colors
    color: ['#2ec7c9', '#b6a2de', '#5ab1ef', '#ffb980', '#d87a80'],

    // Global text styles
    textStyle: {
        fontFamily: 'Roboto, Arial, Verdana, sans-serif',
        fontSize: 13
    },

    // Chart animation duration
    animationDuration: 750,
    // Setup grid
    grid: {
        left: 0,
        right: 40,
        top: 35,
        bottom: 0,
        containLabel: true
    },
    // Add legend
    legend: {
        data: [''],
        itemHeight: 8,
        itemGap: 20,
        textStyle: {
            padding: [0, 5]
        },
        selected: { 'Totales': true }
    },
    // Add tooltip
    tooltip: {
        trigger: 'axis',
        backgroundColor: 'rgba(0,0,0,0.75)',
        padding: [10, 15],
        textStyle: {
            fontSize: 13,
            fontFamily: 'Roboto, sans-serif'
        }, formatter: function (params) {
            var colorSpan = color => '<span style="display:inline-block;margin-right:5px;border-radius:10px;width:9px;height:9px;background-color:' + color + '"></span>';
            let rez = '<p>' + params[0].axisValue + '</p>';
            //console.log(params); //quite useful for debug
            params.forEach(item => {
                if (item.data != 0) {
                    var xx = '<p>' + colorSpan(item.color) + ' ' + item.seriesName + ': ' + item.data + '</p>'
                    rez += xx;
                }

            });
            return rez;
        }
    },
    // Horizontal axis
    xAxis: [{
        type: 'category',
        data: [],
        axisLabel: {
            color: '#333'
        },
        axisLine: {
            lineStyle: {
                color: '#999'
            }
        },
    }],

    // Vertical axis
    yAxis: [{
        type: 'value',
        axisLabel: {
            color: '#333'
        },
        axisLine: {
            lineStyle: {
                color: '#999'
            }
        },
        splitLine: {
            lineStyle: {
                color: ['#eee']
            }
        },
        splitArea: {
            show: true,
            areaStyle: {
                color: ['rgba(250,250,250,0.1)', 'rgba(0,0,0,0.01)']
            }
        }
    }],
    // Add series
    series: [

        {
            label: 'hola',
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a',
                }
            },
            stack: 'x',

            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Producción',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#0a5c0a'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Faltante',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: '#FF0000'
                }
            },
            stack: 'x',
            data: []
        },
        {
            name: 'Proyectado',
            type: 'line',
            lineStyle: {
                normal: {
                    width: 4,
                    type: 'dashed'
                }
            },
            smooth: true,
            symbolSize: 7,
            itemStyle: {
                normal: {
                    color: '#953735',
                    type: 'dashed',
                    borderWidth: 2
                }
            },
            data: [
            ]
        },
        {
            name: 'Totales',
            type: 'line',
            smooth: true,
            symbolSize: 7,
            itemStyle: {
                normal: {
                    color: 'transparent',
                    type: 'dashed',
                    borderWidth: 0,
                    borderColor: 'transparent',
                }
            },
            data: []
        }


    ]
};
var stamping_kayasaki_actual = echarts.init(stamping_kayasaki_actual_element);


var oee_element = document.getElementById('oee_1');
var oee_options = {

    // Define colors
    color: ['#2ec7c9', '#b6a2de', '#5ab1ef', '#ffb980', '#d87a80'],

    // Global text styles
    textStyle: {
        fontFamily: 'Roboto, Arial, Verdana, sans-serif',
        fontSize: 13
    },

    // Chart animation duration
    animationDuration: 750,

    // Setup grid
    grid: {
        left: 0,
        right: 40,
        top: 35,
        bottom: 0,
        containLabel: true
    },

    // Add legend
    legend: {
        data: ['Porcentaje'],
        itemHeight: 8,
        itemGap: 20
    },

    // Add tooltip
    tooltip: {
        trigger: 'axis',
        backgroundColor: 'rgba(0,0,0,0.75)',
        padding: [10, 15],
        textStyle: {
            fontSize: 13,
            fontFamily: 'Roboto, sans-serif'
        }
    },

    // Horizontal axis
    xAxis: [{
        type: 'category',
        boundaryGap: false,
        data: ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'],
        axisLabel: {
            color: '#333'
        },
        axisLine: {
            lineStyle: {
                color: '#999'
            }
        },
        splitLine: {
            show: true,
            lineStyle: {
                color: '#eee',
                type: 'dashed'
            }
        }
    }],

    // Vertical axis
    yAxis: [{
        type: 'value',
        axisLabel: {
            color: '#333'
        },
        axisLine: {
            lineStyle: {
                color: '#999'
            }
        },
        splitLine: {
            lineStyle: {
                color: '#eee'
            }
        },
        splitArea: {
            show: true,
            areaStyle: {
                color: ['rgba(250,250,250,0.1)', 'rgba(0,0,0,0.01)']
            }
        }
    }],

    // Add series
    series: [
        {
            name: 'Contador',
            type: 'line',
            smooth: true,
            symbolSize: 7,
            itemStyle: {
                normal: {
                    borderWidth: 2
                }
            },
            areaStyle: {
                normal: {
                    opacity: 0.25
                }
            },
            data: [1320, 1132, 601, 234, 120, 90, 20]
        }
    ]
};
var oee = echarts.init(oee_element);

// Initialize module
// ------------------------------
document.addEventListener('DOMContentLoaded', function () {


    get_stamping_kayasaki_actual();

    get_grafica();
    get_jph();
  
    const interval = setInterval(function () {
        get_jph();
    }, 1000 * 10);

    const interval_graphs = setInterval(function () {
        get_grafica();
    }, 1000 * 60);

    const interval_acum = setInterval(function () {
        get_stamping_kayasaki_actual();
    }, 1000 * 60 * 5);



});



function get_stamping_kayasaki_actual() {

    $.ajax({

        type: "GET",
        url: "/Home/Get_actual_stamping_kayasaki_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                stamping_kayasaki_actual_options = {

                    // Define colors
                    color: ['#2ec7c9', '#b6a2de', '#5ab1ef', '#ffb980', '#d87a80'],

                    // Global text styles
                    textStyle: {
                        fontFamily: 'Roboto, Arial, Verdana, sans-serif',
                        fontSize: 13
                    },

                    // Chart animation duration
                    animationDuration: 750,
                    // Setup grid
                    grid: {
                        left: 0,
                        right: 40,
                        top: 35,
                        bottom: 0,
                        containLabel: true
                    },
                    // Add legend
                    legend: {
                        data: [''],
                        itemHeight: 8,
                        itemGap: 20,
                        textStyle: {
                            padding: [0, 5]
                        },
                        selected: { 'Totales': true }
                    },
                    // Add tooltip
                    tooltip: {
                        trigger: 'axis',
                        backgroundColor: 'rgba(0,0,0,0.75)',
                        padding: [10, 15],
                        textStyle: {
                            fontSize: 13,
                            fontFamily: 'Roboto, sans-serif'
                        }, formatter: function (params) {
                            var colorSpan = color => '<span style="display:inline-block;margin-right:5px;border-radius:10px;width:9px;height:9px;background-color:' + color + '"></span>';
                            let rez = '<p>' + params[0].axisValue + '</p>';
                            //console.log(params); //quite useful for debug
                            params.forEach(item => {
                                if (item.data != 0) {
                                    var xx = '<p>' + colorSpan(item.color) + ' ' + item.seriesName + ': ' + item.data + '</p>'
                                    rez += xx;
                                }

                            });

                            return rez;
                        }
                    },
                    // Horizontal axis
                    xAxis: [{
                        type: 'category',
                        data: [],
                        axisLabel: {
                            color: '#333'
                        },
                        axisLine: {
                            lineStyle: {
                                color: '#999'
                            }
                        },
                    }],

                    // Vertical axis
                    yAxis: [{
                        type: 'value',
                        axisLabel: {
                            color: '#333'
                        },
                        axisLine: {
                            lineStyle: {
                                color: '#999'
                            }
                        },
                        splitLine: {
                            lineStyle: {
                                color: ['#eee']
                            }
                        },
                        splitArea: {
                            show: true,
                            areaStyle: {
                                color: ['rgba(250,250,250,0.1)', 'rgba(0,0,0,0.01)']
                            }
                        }
                    }],
                    // Add series
                    series: [

                        {
                            label: 'hola',
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a',
                                }
                            },
                            stack: 'x',

                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Producción',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#0a5c0a'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Faltante',
                            type: 'bar',
                            itemStyle: {
                                normal: {
                                    color: '#FF0000'
                                }
                            },
                            stack: 'x',
                            data: []
                        },
                        {
                            name: 'Proyectado',
                            type: 'line',
                            lineStyle: {
                                normal: {
                                    width: 4,
                                    type: 'dashed'
                                }
                            },
                            smooth: true,
                            symbolSize: 7,
                            itemStyle: {
                                normal: {
                                    color: '#953735',
                                    type: 'dashed',
                                    borderWidth: 2
                                }
                            },
                            data: [
                            ]
                        },
                        {
                            name: 'Totales',
                            type: 'line',
                            smooth: true,
                            symbolSize: 7,
                            itemStyle: {
                                normal: {
                                    color: 'transparent',
                                    type: 'dashed',
                                    borderWidth: 0,
                                    borderColor: 'transparent',
                                }
                            },
                            data: []
                        }


                    ]
                };
                var total = [];
                total[0] = 0;
                var produccion = response.map(produccion => produccion.produccion)
                const part_number = [...new Set(response.map(item => item.part_number))];
                const fecha = [...new Set(response.map(item => item.fecha))];

                var o = response.reduce((a, b) => {
                    a[b.part_number] = a[b.part_number] || [];
                    a[b.part_number].push({ [b.fecha]: b.produccion });
                    return a;
                }, {});

                var a = Object.keys(o).map(function (k) {
                    return { part_number: k, month: Object.assign.apply({}, o[k]) };
                });


                var part_numbers = [];

                for (var i = 0, l = part_number.length; i < l; i++) {

                    var data = [];
                    stamping_kayasaki_actual_options.series[i].name = a[i].part_number
                    part_numbers.push(a[i].part_number);

                    var suma = 0;

                    for (var k = 0, m = fecha.length; k < m; k++) {
                        if (a[i].month[fecha[k]] !== undefined) {
                            data.push(a[i].month[fecha[k]])

                            suma = suma + + a[i].month[fecha[k]];


                        }
                        else {
                            data.push(0)

                        }
                        stamping_kayasaki_actual_options.series[i].data = data;

                    }

                }


                var totales = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

                for (var k = 0, m = stamping_kayasaki_actual_options.series.length; k < m; k++) {
                    if (stamping_kayasaki_actual_options.series[k].data.length != 0) {

                        for (var i = 0, n = stamping_kayasaki_actual_options.series.length; i < n; i++) {
                            if (stamping_kayasaki_actual_options.series[k].data[i] !== undefined) {

                                totales[i] = totales[i] + + stamping_kayasaki_actual_options.series[k].data[i];
                            }
                        }

                    }
                }


                var proyectado_pasado;
                var proyectado_actual;

                $.ajax({

                    type: "GET",
                    url: "/Home/Get_proyectado_stamping_kayasaki_Json",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        if (response != null) {


                            proyectado_pasado = response[0].proyectado_pasado
                            proyectado_actual = response[0].proyectado_actual

                        } else {
                            console.log("Something went wrong");
                        }
                    },
                    failure: function (response) {
                        console.log(response.responseText);
                    },
                    error: function (response) {
                        console.log(response.responseText);
                    },
                    async: false
                });

                stamping_kayasaki_actual_options.series[36].data = [
                    (proyectado_pasado - totales[0]) < 0 ? 0 : (proyectado_pasado - totales[0]),
                    (proyectado_pasado * 2 - totales[1]) < 0 ? 0 : (proyectado_pasado * 2 - totales[1]),
                    (proyectado_pasado * 3 - totales[2]) < 0 ? 0 : (proyectado_pasado * 3 - totales[2]),
                    (proyectado_pasado * 4 - totales[3]) < 0 ? 0 : (proyectado_pasado * 4 - totales[3]),
                    (proyectado_pasado * 5 - totales[4]) < 0 ? 0 : (proyectado_pasado * 5 - totales[4]),
                    (proyectado_pasado * 6 - totales[5]) < 0 ? 0 : (proyectado_pasado * 6 - totales[5]),
                    (proyectado_pasado * 7 - totales[6]) < 0 ? 0 : (proyectado_pasado * 7 - totales[6]),
                    (proyectado_pasado * 8 - totales[7]) < 0 ? 0 : (proyectado_pasado * 8 - totales[7]),
                    (proyectado_pasado * 9 - totales[8]) < 0 ? 0 : (proyectado_pasado * 9 - totales[8]),
                    (proyectado_pasado * 10 - totales[9]) < 0 ? 0 : (proyectado_pasado * 10 - totales[9]),
                    (proyectado_pasado * 11 - totales[10]) < 0 ? 0 : (proyectado_pasado * 11 - totales[10]),
                    (proyectado_pasado * 12 - totales[11]) < 0 ? 0 : (proyectado_pasado * 12 - totales[11]),
                    (proyectado_actual - totales[12]) < 0 ? 0 : (proyectado_actual - totales[12]),
                    (proyectado_actual * 2 - totales[13]) < 0 ? 0 : (proyectado_actual * 2 - totales[13]),
                    (proyectado_actual * 3 - totales[14]) < 0 ? 0 : (proyectado_actual * 3 - totales[14]),
                    (proyectado_actual * 4 - totales[15]) < 0 ? 0 : (proyectado_actual * 4 - totales[15]),
                    (proyectado_actual * 5 - totales[16]) < 0 ? 0 : (proyectado_actual * 5 - totales[16]),
                    (proyectado_actual * 6 - totales[17]) < 0 ? 0 : (proyectado_actual * 6 - totales[17]),
                    (proyectado_actual * 7 - totales[18]) < 0 ? 0 : (proyectado_actual * 7 - totales[18]),
                    (proyectado_actual * 8 - totales[19]) < 0 ? 0 : (proyectado_actual * 8 - totales[19]),
                    (proyectado_actual * 9 - totales[20]) < 0 ? 0 : (proyectado_actual * 9 - totales[20]),
                    (proyectado_actual * 10 - totales[21]) < 0 ? 0 : (proyectado_actual * 10 - totales[21]),
                    (proyectado_actual * 11 - totales[22]) < 0 ? 0 : (proyectado_actual * 11 - totales[22]),
                    (proyectado_actual * 12 - totales[23]) < 0 ? 0 : (proyectado_actual * 12 - totales[23]),
                ];

                stamping_kayasaki_actual_options.series[37].data = [
                    proyectado_pasado,
                    proyectado_pasado * 2,
                    proyectado_pasado * 3,
                    proyectado_pasado * 4,
                    proyectado_pasado * 5,
                    proyectado_pasado * 6,
                    proyectado_pasado * 7,
                    proyectado_pasado * 8,
                    proyectado_pasado * 9,
                    proyectado_pasado * 10,
                    proyectado_pasado * 11,
                    proyectado_pasado * 12,
                    proyectado_actual,
                    proyectado_actual * 2,
                    proyectado_actual * 3,
                    proyectado_actual * 4,
                    proyectado_actual * 5,
                    proyectado_actual * 6,
                    proyectado_actual * 7,
                    proyectado_actual * 8,
                    proyectado_actual * 9,
                    proyectado_actual * 10,
                    proyectado_actual * 11,
                    proyectado_actual * 12
                ];
                stamping_kayasaki_actual_options.series[38].data = totales;


                stamping_kayasaki_actual_options.xAxis[0].data = fecha;
                stamping_kayasaki_actual_options.legend.data = part_numbers;
                stamping_kayasaki_actual.setOption(stamping_kayasaki_actual_options, true);


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

function get_jph() {

    $.ajax({

        type: "GET",
        url: "/Home/Get_jph_stamping_kayasaki_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                $("#piezas_modelo_actual").text(response[0].piezas_modelo_actual);
                $("#modelo_actual").text(response[0].modelo_actual);
                $("#proyectado").text(response[0].proyectado);
                $("#golpes_totales").text(response[0].golpes_totales);
                $("#sph_promedio").text(response[0].sph_promedio);
                $("#diferencia").text(response[0].diferencia);


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



function get_grafica() {


    $.ajax({

        type: "GET",
        url: "/Dashboard/Dashboard_Grafica_stampingKayasaki_Json",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != null) {

                var resultado = response.map(resultado => resultado.resultado)
                var fecha_evento = response.map(fecha_evento => fecha_evento.fecha_evento)

                oee_options.xAxis[0].data = fecha_evento;
                oee_options.series[0].data = resultado;

                oee.setOption(oee_options, true);
                // console.log(response.map(val => { "number" : val }) );


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




