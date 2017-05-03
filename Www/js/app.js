'use strict';
angular.module('mean', ['ngResource', 'ui.router', 'ui.bootstrap','oc.lazyLoad','ngDialog'])
.run(['$rootScope','$window','$stateParams','DotNetUrl','JavaUrl','codebase', function($rootScope, $window, $stateParams, DotNetUrl, JavaUrl, codebase){
	$rootScope.storage = $window.storage;
	$rootScope.stateParams = $stateParams;

	$rootScope.$on('$stateChangeStart', function(event, toState, toParams, fromState, fromParams, options){
		//event.preventDefault();
		//console.log(toState);
	});

	$rootScope.$on('$destroy', function () {

	});

	$rootScope.getUrl = function(){
		if(codebase.current.dotnet === true)
			return DotNetUrl;

		return JavaUrl;
	};
}])
;