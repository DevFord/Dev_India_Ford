function fetch() {
    var ulrecord = $('#records_table');
    $.ajax({
        url: "https://paperlessro.azurewebsites.net/api/Masters/GetBillType",
        method: 'Get',
        dataType: 'json',
        //async: false,
        //contentType: "application/json; charset=utf-8",
        //data: data,
        //headers: {
        //    'Access-Control-Allow-Origin': '*',
        //    'Content-type': 'application/json'
        //},
        //crossDomain: true,        
        error: function (error) {
            console.log('error: ' + error);
            alert("error=" + JSON.stringify(error));
        },
        success: function (data) {
            console.log('succes: ' + data);
            //alert("succesa:=" + JSON.stringify(data));
            var trHTML = '';
            for (i = 0; i < data.Data.length; i++) {
                trHTML += '<tr><td>' + data.Data[i].Id + '</td><td>' + data.Data[i].Name + '</td><td>' + data.Data[i].ACTV_IND + '</td></tr>';
            }
            ulrecord.append(trHTML);           
        }
    });
}
               

