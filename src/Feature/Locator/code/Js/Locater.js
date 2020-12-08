$(document).ready(function () {
    //Dropdownlist Selectedchange event
    $("#state_list").change(function () {
        var state = $(this).val();
        //alert(state);        
        $.ajax({
            type: 'GET',
            url: 'api/sitecore/Locator/BindCity?state=' + state,
            dataType: 'json',
            data: {  },
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

//$(document).ready(function () {
//    $("#state_list").change(function () {
//        var id = $("#state_list").val();

//        var city = $('#city_list');
//        $("#city_list").empty();
//        $.get("api/sitecore/Locator/BindCity", { state: id }, function (data) {

//            var v = '';
//            $.each(data, function (i, v1) {
//                v += "<option value=" + v1.Loacality + ">";

//            });
//            $("#city_list").append(v);
//        });
//    });
//});


