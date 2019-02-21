app.controller('menuController', ['$scope', '$http', 'orderService', 'menuService', '$modal', menuController])
function menuController($scope, $http, orderService, menuService, $modal) {
    $scope.dish = {};

    var menu = menuService.dishes;
    $scope.menu = menu;

    var getConfig =
    {
        method: 'GET',
        url: 'http://localhost:11959/Restaurant/menu'
    }

    var modalConfig = {
        animation: true,
        templateUrl: '/Script/Modules/Restaurant/Partials/modal.html',
        controller: 'modalController',
        resolve: {
            dish: function () {
                return $scope.dish;
            }
        }
    }

    if (menu.length == 0) {
        $http(getConfig).then(success, fail)
    }

    $scope.adicionar = function (dishId) {
        var dish = $.grep(menu, function (item) {
            return dishId == item.Id;
        })
        $scope.dish = dish[0];
        var modal = $modal.open(modalConfig);
        modal.result.then(function (result) {
            orderService.addDish(dish[0]);
        });
    }

    function success(response) {
        menu = menu.concat(response.data);
        $scope.menu = menu;
    };
    function fail(response)
    {
        alert("Falha na obtenção do menu; certifique-se de que a WEBAPI está sendo servida.");
    };

}