
$(document).ready(function () {
    // setup handlers
    WireUp();
    LoadGig(1);
});

function WireUp() {
}

function LoadGig(gigId) {
    var gig;
    var url = "gigs.svc/Abouts(" + gigId +")?$expand=Positions/Notes,Extras,Trainings";
    OData.read(
        {
            // fetch all data about the gig
            requestUri: url
        },
        function (data, response) {
            gig = data;

            $('#about').text(gig.FirstName + ' ' + gig.LastName + ' ' + gig.Phone + ' ' + gig.Email);

            $.each(gig.Positions, function () {
                $('<p>' + this.Title + '</p>').appendTo('#positions');
            });

            $.each(gig.Trainings, function () {
                $('<p>' + this.Degree + '</p>').appendTo('#trainings');
            });


            $.each(gig.Extras, function () {
                $('<p>' + this.Blurb + '</p>').appendTo('#extras');
            });
            
        },
        function (error) {
            LogError(error);
        });
}

function LogError(message) {
    alert(message);
}