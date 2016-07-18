 var  modules = modules || [];
(function () {
    'use strict';
    modules.push('Table');

    angular.module('Table',['ngRoute'])
    .controller('Table_list', ['$scope', '$http', function($scope, $http){

        $http.get('/Api/Table/')
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Table_details', ['$scope', '$http', '$routeParams', function($scope, $http, $routeParams){

        $http.get('/Api/Table/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

    }])
    .controller('Table_create', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){

        $scope.data = {};
        
        $scope.save = function(){
            $http.post('/Api/Table/', $scope.data)
            .then(function(response){ $location.path("Table"); });
        }

    }])
    .controller('Table_edit', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){

        $http.get('/Api/Table/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});

        
        $scope.save = function(){
            $http.put('/Api/Table/' + $routeParams.id, $scope.data)
            .then(function(response){ $location.path("Table"); });
        }

    }])
    .controller('Table_delete', ['$scope', '$http', '$routeParams', '$location', function($scope, $http, $routeParams, $location){

        $http.get('/Api/Table/' + $routeParams.id)
        .then(function(response){$scope.data = response.data;});
        $scope.save = function(){
            $http.delete('/Api/Table/' + $routeParams.id, $scope.data)
            .then(function(response){ $location.path("Table"); });
        }

    }])

    .config(['$routeProvider', function ($routeProvider) {
            $routeProvider
            .when('/Table', {
                title: 'Table - List',
                templateUrl: '/Static/Table_List',
                controller: 'Table_list'
            })
            .when('/Table/Create', {
                title: 'Table - Create',
                templateUrl: '/Static/Table_Edit',
                controller: 'Table_create'
            })
            .when('/Table/Edit/:id', {
                title: 'Table - Edit',
                templateUrl: '/Static/Table_Edit',
                controller: 'Table_edit'
            })
            .when('/Table/Delete/:id', {
                title: 'Table - Delete',
                templateUrl: '/Static/Table_Delete',
                controller: 'Table_delete'
            })
            .when('/Table/:id', {
                title: 'Table - Details',
                templateUrl: '/Static/Table_Details',
                controller: 'Table_details'
            })
    }])
;

})();
