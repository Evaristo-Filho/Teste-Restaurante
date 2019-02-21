app.controller('resumoController', ['$scope', '$http', 'orderService', 'menuService', resumoController])
function resumoController($scope, $http, orderService, menuService) {
    $scope.dishList = orderService.dishList;
    $scope.totalPrice = 0;
    $scope.totalTime = 0;

    for (var i = 0; i < $scope.dishList.length; i++) {
        $scope.totalTime += $scope.dishList[i].estimatedTime;
        $scope.totalPrice += $scope.dishList[i].Price;
    }


    $scope.submeter = function () {

        var postConfig = {
            method: 'POST',
            url: 'http://localhost:11959/Restaurant/createorder',
            data: JSON.stringify($scope.dishList)
        }
        $http(postConfig).then(success, fail)
    }


    function success(response) {
        alert("Pedido submetido com sucesso");
    };
    function fail(response) {
        alert("Falha no envio do pedido; certifique-se de que a WEBAPI está sendo servida.");
    };
}