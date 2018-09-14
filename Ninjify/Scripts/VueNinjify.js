var appInput = new Vue({
    el: '#appInput',
    data: {
        result: [], //Ninja JSON
        selected: '', //Ninja Level
        favoriteVisible: false, //Hidden if no Name
        favoriteExist:false, //Hidden if no Favorite
        favoriteName: ''
    },
    methods: {
        //Submit
        submit: function () {
            GET();
            document.getElementById("inputBuzzword").value = "";
        },
        //Favorite
        favorite: function() {
            var name = appInput.selected +" " +appInput.result.name;
            appInput.favoriteName = name;
        }
    }
})


function GET() {
    const Http = new XMLHttpRequest();
    var param = "x=" + document.getElementById("inputBuzzword").value;
    const url = 'http://localhost:65044/api/Ninjify';
    Http.open("GET", url + "?" + param);
    Http.onload = function () { //ONCE SUCCESSFUL
        var result = JSON.parse(Http.response);
        appInput.result = result;
    };
    Http.send();
}