app.controller('modalController', ['$scope', 'dish', modalController]);


function modalController($scope, dish) {
    $scope.dish = dish;
    $scope.selectedOption = "";
    $scope.options = [];

    if (dish.hasOwnProperty("sugarQuantity")) {
        $scope.options = [{ "text": "without sugar", "value": "0" }, { "text": "with sugar", "value": "1" }];
    }
    if (dish.hasOwnProperty("saltQuantity")) {
        $scope.options = [{ "text": "without salt", "value": "0" }, { "text": "with salt", "value": "1" }];
    }
    if (dish.hasOwnProperty("spice")) {
        $scope.options = [{ "text": "bland", "value": "0" }, { "text": "spicy", "value": "1" }];
    }


    $scope.ok = function () {
        if (dish.hasOwnProperty("sugarQuantity"))
            dish.sugarQuantity = $scope.selectedOption;
        if (dish.hasOwnProperty("saltQuantity"))
            dish.saltQuantity = $scope.selectedOption;
        if (dish.hasOwnProperty("spice"))
            dish.spice = $scope.selectedOption;
        $scope.$close($scope.dish);
    };

    $scope.cancel = function () {
        $scope.$dismiss('cancel');
    };
}