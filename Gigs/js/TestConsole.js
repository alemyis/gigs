
$(document).ready(function () {
    // setup handlers
    WireUp();
});

function WireUp() {
    $('#testButton').click(LoadSelectedTest);
}


function LoadSelectedTest() {
    var url = "gigs.svc/" + $('#testSelection').val();
    $('#urlSpan').text(url);
    $('#resultFrame').attr('src', url);
}

function LogError(message) {
    alert(message);
}
