
var MyLib = {
    error: (error) => { localStorage[error] },
};

var Method = {
    POST: 'POST',
    GET: 'GET',
    DELETE: 'DELETE',
    PATCH: 'PATCH',
    PUT:'PUT'
}

var ContentType = {
    JSON: 'JSON',
    appFormUrlEncoded: 'application/x-www-form-urlencoded'
}



var format = function (value, formatString) {
    console.log("value : " + value);
    return value;
}

var ajaxHelper = function (uri, method, data) {
    MyLib.error(''); // Clear error message
    return $.ajax({
        type: method,
        url: uri,
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        data: data ? data : null
    }).fail(function (jqXHR, textStatus, errorThrown) {
        MyLib.error(errorThrown);
    });
}