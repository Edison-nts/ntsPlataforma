(function () {

    var app = angular.module('app', []);

    app.controller('ContatoController', function ($scope, $http) {
        $scope.hideAlerta = false;
        $scope.result = "";
        $scope.Mensagem = "Carregando Dados - Aguarde";

        $http.get("/api/Contato/Teste").then(function (response) {
            $scope.Contatos = response.data;
            if (response.data.length == 0) {
                $scope.hideAlerta = false;
                $scope.Mensagem = "Nenhum registro encontrado";
            }
            else {
                $scope.hideAlerta = true;
            }

            
        });

    });

})();
