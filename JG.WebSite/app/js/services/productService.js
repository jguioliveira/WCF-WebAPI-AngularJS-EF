(function () {
    angular
        .module('app')
        .service('ProductService', ['$http', function ($http) {

            this.GetProducts = function (token) {
                var config = {
                    headers: {
                        'token': token,
                        'Content-Type': 'application/json',
                        'Accept': 'application/json'
                    }
                };

                return $http.get('http://localhost:3866/Product/Get', config).then(function (response) {
                    return response.data;
                }, function (response) {

                    var result = new Object();
                    result.Error = new Object();
                    result.Error.Message = "";

                    if (response.status == 401)
                        result.Error.Message = "Token inválido!"
                    else
                        result.Error.Message = response.statusText != "" ? response.statusText : "Ocorreu um erro na chamada do serviço.";

                    return result;
                });
            }

            this.GetTokenAuthentication = function () {
                return $http.get('http://localhost:58891/TokenAuthentication.svc/GetToken').then(function (response) {
                    return response.data;
                }, function (response) {
                    var result = new Object();
                    result.Error = new Object();
                    result.Error.Message = response.statusText != "" ? response.statusText : "Ocorreu um erro na chamada do serviço.";
                    return result;
                });
            }

        }]);
})();
