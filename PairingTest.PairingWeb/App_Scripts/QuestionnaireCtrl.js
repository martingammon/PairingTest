angular
    .module("Questionnaire.ctrl.QandA", [])
    .controller("QandAController",
        [
            "$http", "$scope",
            function ($http, $scope)
            {
                $scope.questionnaire = null;
                $scope.questTitle = "";
                $scope.questions = [];

                $scope.loadQuestions = function () {
                    $http.get($("#wsbasehref").val())
                        .then(function (data) {
                            $scope.questionnaire = new Questionnaire(data.data);
                        });
                }

                $scope.saveAnswers = function() {
                    var str = "Your Answers to the " + $scope.questionnaire.Title + ":";
                    for (var i = 0; i < $scope.questionnaire.QandAList.length; i++) {
                        str += $scope.questionnaire.QandAList[i].Answer + "|";
                    }
                    alert(str);
                }

                $scope.load = function () {
                    $scope.loadQuestions();

                };

                $scope.load();

            }
        ]);


