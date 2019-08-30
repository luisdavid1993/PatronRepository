console.log(modelo);
var all = 1;
var selectAll = function () {
    if (all == 1) {
        $.each(modelo, function (key, value) {
            $(".input" + value.IdTipoLinea).attr('checked', true);
            $("#item_" + value.IdTipoLinea).css('background-color', '#d3d3d3');
        })
        all = 0;
    } else {
        $.each(modelo, function (key, value) {
            $(".input" + value.IdTipoLinea).attr('checked', false);
            $("#item_" + value.IdTipoLinea).css('background-color', '#fff');
        });
        all = 1;
    }
}

var selectItem = function (row) {
    if ($(".input" + row.IdTipoLinea).is(':checked')) {
        console.log($(".input" + row.IdTipoLinea).is(':checked'));
        $("#item_" + row.IdTipoLinea).css('background-color', '#d3d3d3');
    } else {
        console.log($(".input" + row.IdTipoLinea).is(':checked'));
        $("#item_" + row.IdTipoLinea).css('background-color', '#fff');
    }
    // 
    console.log(row);
}