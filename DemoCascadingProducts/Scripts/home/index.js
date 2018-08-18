$(document).ready(function () {

    $("#Company").change(function () {
        
        $("#Store").empty();

        $.getJSON('/home/getstores', { idCompany: $('#Company').val() }, function (data) {
            $.each(data, function () {
                $('#Store').append('<option value=' +
                    this.Value + '>' + this.Text + '</option>');
            });
        });
    });
});