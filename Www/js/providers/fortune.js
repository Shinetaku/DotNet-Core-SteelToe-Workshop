angular.module('mean').provider('fortune',[function () {
	this.$get = ['$q', '$timeout','$resource','session','codebase',  function ($q, $timeout, $resource, session, codebase) {
		var timeoutWait = 400;
		var list = function (url) {
			var deferred = $q.defer();

			$timeout(function () {
				$resource(url + 'fortunes').list(null,function(result){
																						deferred.resolve(result);
																					}, function(err){
																						deferred.reject(err);
																					});
			}, timeoutWait);

			return deferred.promise;
		};
		var getRandom = function (url) {
			var deferred = $q.defer();

			$timeout(function () {
				$resource(url + 'random').get(null,function(result){
																						deferred.resolve(result);
																					}, function(err){
																						deferred.reject(err);
																					});
			}, timeoutWait);

			return deferred.promise;
		};

		return {
			list: list,
			getRandom: getRandom
		}
	}];

	this.init = function () {

	};
}]);