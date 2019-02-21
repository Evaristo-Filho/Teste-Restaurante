var app = angular.module('RestaurantApp', ['ngRoute','ui.bootstrap']);

app.config(function ($routeProvider, $locationProvider) {
    $routeProvider
         .when('/Menu', {
             templateUrl: '/Script/Modules/Restaurant/Partials/menu.html',
             controller: 'menuController'
         })
    .when('/Resumo', {
        templateUrl: '/Script/Modules/Restaurant/Partials/resumo.html',
        controller: 'resumoController'
    })
    $locationProvider.html5Mode(true);
});