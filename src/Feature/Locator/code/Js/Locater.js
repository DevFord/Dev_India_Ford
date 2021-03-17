$(document).ready(function () {
    //Dropdownlist Selectedchange event
    $("#state_list").change(function () {
        var state = $(this).val();
        //alert(state);        
        $.ajax({
            type: 'GET',
            url: 'https://fordindia.dev.local/api/sitecore/Locator/BindCity?state=' + state,
            dataType: 'json',
            data: {},
            success: function (citys) {
                $("#City_Name").empty();

                $.each(citys, function (i, city) {
                    $("#City_Name").append('<option value="' + city.Locality + '">' + city.Locality + '</option>');
                });
            },
            error: function (ex) {
                alert('Failed to retrieve states.' + ex);
            }
        });
        return false;
    });    
});
$('#NearMe').on('click', function (e) {
     e.preventDefault();
    $.ajax({
        type: 'POST',
        url: '/api/Locator/DealerLocator',
        contentType: 'application/json',
        data: {},
        success: function (result) {
            alert('Success');
            //window.location.href = result.redirecturl;
            $('#dealer-locator1').remove('div');
            $("#dealer-locator1").html(result);
        },
        error: function (ex) {
            alert('Failed to retrieve Near me' + ex);
        }
    });
});


