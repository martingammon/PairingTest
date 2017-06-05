angular
    .module("Questionnaire",
        [
            "ngRoute", "Questionnaire.ctrl.QandA"
        ])
    .config([
        "$routeProvider", "$locationProvider", "$httpProvider",
        function ($routeProvider, $locationProvider, $httpProvider) {

            $httpProvider.defaults.headers.post["Content-Type"] = "application/x-www-form-urlencoded;charset=utf-8";

            $routeProvider.when("/",
                {
                    templateUrl: "/questionnaire/questionnaire",
                    controller: "QandAController"
                });
            $routeProvider.when("/questionnaire",
                {
                    templateUrl: "/questionnaire/questionnaire",
                    controller: "QandAController"
                });
            $routeProvider.when("/Questionnaire",
                {
                    templateUrl: "/questionnaire/questionnaire",
                    controller: "QandAController"
                });


            $locationProvider.html5Mode({
                enabled: true,
                requireBase: false
            });
        }
    ]);