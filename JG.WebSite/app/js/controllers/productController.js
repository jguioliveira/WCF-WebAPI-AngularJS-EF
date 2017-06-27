(function () {
    angular
        .module('app')
        .controller('productController', ['$scope', '$interval', 'ProductService', function ($scope, $interval, ProductService) {

            var vm = $scope;

            vm.token = "";
            vm.expiration = "";
            vm.expirationTimer = "";
            vm.productList = [];
            vm.Error = null;

            vm.GetProducts = function () {
                var response = ProductService.GetProducts(vm.token);

                response.then(function (responseData) {
                    if (responseData.Error != null) {
                        vm.productList = [];
                        vm.Error = responseData.Error;
                    }
                    else {
                        vm.productList = responseData.Result;
                        vm.Error = null;
                    }
                });
            };

            vm.GetToken = function () {
                var response = ProductService.GetTokenAuthentication();
                response.then(function (responseData) {
                    var teste = responseData;

                    if (responseData.Error != null) {
                        vm.token = "";
                        vm.expirationTimer = "";
                        vm.Error = responseData.Error;
                    }
                    else {
                        vm.token = responseData.Token;
                        vm.expiration = responseData.Expiration;

                        vm.Error = null;
                    }
                })
            };

            var UpdateEmpirationTimer = function () {
                if (vm.expiration != "") {
                    var now = new Date();
                    var exp = new Date(parseInt(vm.expiration.replace('/Date(', '')));
                    var result = (exp - now) / 1000;
                    
                    if (result <= 0) {
                        vm.expirationTimer = 'Expirado';
                        vm.expiration = '';
                    }
                    else {
                        vm.expirationTimer = result + ' Segundos';
                    }

                }
            };

            $interval(UpdateEmpirationTimer, 1000);

        }]);
})();
