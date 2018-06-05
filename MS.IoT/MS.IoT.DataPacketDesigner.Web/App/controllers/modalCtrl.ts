﻿module msIoT {
    let app = angular.module("msIoT");

    //JSON Modal Controller, used to control the display of the JSON data in the JSON Modal
    class JsonModalCtrl {
        static $inject: Array<string> = ['$uibModalInstance', 'template'];

        private $uibModalInstance: any;
        private template: Template;

        constructor($uibModalInstance, template: Template) {
            this.$uibModalInstance = $uibModalInstance;
            this.template = template;
        }

        public ok() {
            this.$uibModalInstance.close();
        }
    }
    app.controller('JsonModalCtrl', JsonModalCtrl as any);

    //Alert Modal Controller, used to control the display of the data in the alert Modal
    class AlertModalCtrl {
        static $inject: Array<string> = ['$uibModalInstance', 'title', 'content'];

        private $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance;
        private title: string;
        private content: string;

        constructor($uibModalInstance: ng.ui.bootstrap.IModalServiceInstance, title: string, content: string) {
            this.$uibModalInstance = $uibModalInstance;
            this.title = title;
            this.content = content;
        }

        public cancel() {
            this.$uibModalInstance.close(false);
        }

        public ok() {

            this.$uibModalInstance.close(true);
        }
    }
    app.controller('AlertModalCtrl', AlertModalCtrl as any);
}
