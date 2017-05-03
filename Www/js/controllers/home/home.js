'use strict';

angular.module('mean').controller('homeCtrl',['message','$scope','fortune','$rootScope','codebase', function(message, $scope, fortune, $rootScope, codebase){
	//Scope Functions
	//$scope.XXX = function(){
	//};

	//Local Functions
	var init = function () {
		message.clear($scope);

		var success = function(result){
			$scope.text = result.text;
		};
		var error = function(err){
			message.addError($scope, err);
		};

		fortune.getRandom($rootScope.getUrl()).then(success, error);
	};

	//Destroy Scope
	$scope.$on('$destroy', function () {
	});

	//Local  Variables

	//Scope  Variables
	$scope.text = '';

	//Initialize Page
	init();
}]);