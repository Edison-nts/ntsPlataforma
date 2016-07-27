(function () {

    var app = angular.module('app', []);

    app.controller('ContatoController', function ($scope, $http) {
        $scope.hideAlerta = false;
        $scope.result = "";

        $http.get("/api/Contato/Teste").then(function (response) {
            $scope.hideAlerta = true;
            $scope.Contatos = response.data;
        });

    });

})();
