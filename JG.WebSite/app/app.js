(function () {
    'use strict';

    angular
        .module('app', ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
                .when('/product', {
                    templateUrl: './views/productView.html'
                })
                .otherwise({
                    redirectTo: '/'
                });
        });
})();