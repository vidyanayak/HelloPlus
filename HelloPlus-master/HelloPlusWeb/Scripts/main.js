var URL_API_ROOT;

$(function () {
    // URL_API_ROOT = '@ViewBag.URL_API_ROOT';

    console.log(URL_API_ROOT);
    GetCurrentDateTime();
    GetMessage();
});

function GetCurrentDateTime() {
    var param1 = FormattedDateTimeFromUtcToLocal(new Date());
    $('#displayDate').html (param1);

}

function FormattedDateTimeFromUtcToLocal(dt) {
    var momentTime = moment.utc(dt).local();

    var tzName = moment.tz.guess();
    var abbr = moment.tz(tzName).zoneAbbr();

    return momentTime.format("LL LTS ")+ abbr;
    //return momentTime.format();
}

function GetMessage() {
    console.log(URL_API_ROOT);
    var apiUrl = URL_API_ROOT + "api/notification/post";  //"/Get";
   // var queryString = '?id=' +Id ;
     $.ajax
        ({
            type: "POST",//"GET"
            url: apiUrl,// + queryString,
            contentType: "application/json; charset=utf-8",
          //  crossDomain: true,
            //headers: {
            //    'Authorization': 'bearer ' + UserToken
            //},
            data: {language:CURRENT_LANGUAGE},
            success: function (data) {
                var JsonData = data;
                console.log("LANG: " + CURRENT_LANGUAGE);
                console.log(data);
                $("#displayMessage").html(data);
               
            },
            error: function (err) {
                console.log("Failed in API call: " + err);
            }
        });
}