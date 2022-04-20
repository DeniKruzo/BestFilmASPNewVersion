mainApp.factory('RequestDataSirvice', function($http, $q){
    
  

    return{
        loadJson: function(webServiceUrl){
            var result = $q.defer();
            $http(
                {
                    method: 'GET',
                    url: webServiceUrl
                }
            ).then(
                function success(response)
                {
                    result.resolve(response.data);
                }, 
                function error(response)
                {
                    result.reject(response.data);
                }
            );
            return result.promise;
        }
    };
});