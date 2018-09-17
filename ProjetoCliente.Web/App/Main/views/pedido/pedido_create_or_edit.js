(function () {
    'use strict';

    angular
        .module('app')
        .controller('app.views.pedido.pedido_create_or_edit', PedidoModalController)

    PedidoModalController.$inject =
        [
            '$scope',
            '$uibModalInstance',
            'abp.services.app.pedido',
            'id',
            'isEditing'
        ];

    function PedidoModalController($scope, $uibModalInstance, pedidoService, id, isEditing) {
        /* jshint validthis:true */
        var vm = this;
        vm.save = save;
        vm.cancel = cancel;

        vm.isEditing = isEditing;
        vm.pedido = {};

        activate();

        function activate() {
            if (isEditing) {
                abp.ui.setBusy();
                getPedido();
            }
        }

        function getPedido() {
            pedidoService.getByIdPedido(id)
                .then(fillPedido, errorMessage)
                .catch(unblockByError);

            function fillPedido(result) {
                abp.ui.clearBusy();
                vm.pedido = result.data;
            }
        }

        function create() {
            abp.ui.setBusy();
            pedidoService.createPedido(vm.pedido)
                .then(success)
                .catch(unblockByError);
        }

        function update() {
            abp.ui.setBusy();
            pedidoService.updatePedido(vm.pedido)
                .then(success)
                .catch(unblockByError);
        }

        function success() {
            abp.ui.clearBusy();
            //abp.notify.info(App.localize('SavedSuccessfully'));
            $uibModalInstance.close({});
        }

        function errorMessage(result) {
            abp.ui.clearBusy();
            abp.notify.error(result);
        }

        function unblockByError(error) {
            console.log(error);
            abp.ui.clearBusy();
        }

        function save() {
            if (isEditing) {
                update();
            } else {
                create();
            }
        };

        function cancel() {
            $uibModalInstance.dismiss({});
        };

    }
})();
