﻿(function () {
    angular
        .module('app')
        .controller('homeController', ['$scope', '$location', function ($scope, $location) {
            $location.path('/product');
        }]);
})();
