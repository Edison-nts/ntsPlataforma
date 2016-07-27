(function () {

    var app = angular.module('app', []);

    app.controller('ContatoController', function ($scope, $http) {
        $scope.result = "";
        $http.get("/api/Contato/Teste").then(function (response) {
            $scope.result = response.data;
        });
    });

})();
