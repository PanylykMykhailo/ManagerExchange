$(function () {
    $("#datepicker").datepicker();
});
$(document).ready(function () {
    var table = $('#example').DataTable();

    $('#example tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });

    $('#button').click(function () {
        table.row('.selected').remove().draw(false);
    });
});
$(document).on('input', '#FromAmount', function () {
    if ($(this).val().length === 0) {
        $('#ToAmount').prop('disabled', false);
    }
    else
    {
        $('#ToAmount').prop('disabled', true);
    }
});
$(document).on('input', '#ToAmount', function () {
    if ($(this).val().length === 0) {
        $('#FromAmount').prop('disabled', false);
    }
    else {
        $('#FromAmount').prop('disabled', true);
    }
   
});