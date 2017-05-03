angular.module('mean').provider('codebase', [function () {
	this.$get = [function () {
		var codebase = {
			dotnet: true,
			java: false
		};

		var toggle = function(){
			if(codebase.dotnet === true){
				//switch to java
				codebase.dotnet = false;
				codebase.java = true;
				return;
			}

			//switch to dotnet
			codebase.dotnet = true;
			codebase.java = false;
		};

		return {
			toggle: toggle,
			current: codebase
		}
	}];

	this.init = function () {

	};
}]);