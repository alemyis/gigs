
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

            //contact info
            $("#aboutTemplate")
                .tmpl(gig)
                .appendTo("#about");

            $("#positionTemplate")
                .tmpl(gig.Positions)
                .appendTo("#positions");

            $("#trainingTemplate")
                .tmpl(gig.Trainings)
                .appendTo("#trainings");

            $("#extraTemplate")
                .tmpl(gig.Extras)
                .appendTo("#extras");
        },
        function (error) {
            LogError(error);
        });
}

function LogError(message) {
    alert(message);
}