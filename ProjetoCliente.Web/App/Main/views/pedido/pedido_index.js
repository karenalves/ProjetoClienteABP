(function () {
    'use strict';

    angular
        .module('app')
        .controller('app.views.pedido.pedido_index', PedidoController)

    PedidoController.$inject =
        [
            '$uibModal',
            'abp.services.app.pedido',
            '$state',
            '$timeout'
        ];

    function PedidoController($uibModal, pedidoService, $state, $timeout) {
        var vm     = this;
        vm.create  = create;
        vm.edit    = edit;
        vm.delete  = Delete;
        vm.refresh = refresh;

        vm.pedidos = [];

        activate();

        function activate() {
            abp.ui.setBusy();
            getPedidos();
        }

        function refresh() {
            getPedidos();
        }

        function getPedidos() {
            pedidoService.getAllPedido({})
                .then(fillPedidos, errorMessage)
                .catch(unblockByError);

            function fillPedidos(result) {
                vm.pedidos = result.data.pedidos;
                abp.ui.clearBusy();
            }

            function unblockByError() {
                abp.ui.clearBusy();
            }
        }

        function errorMessage(result) {
            abp.ui.clearBusy();
            abp.notify.error(result);
        }

        function create() {
            var modalInstance = $uibModal.open({
                templateUrl: '/App/Main/views/pedido/pedido_create_or_edit.cshtml',
                controller: 'app.views.pedido.pedido_create_or_edit as vm',
                backdrop: 'static',
                resolve: {
                    id: function () {
                        return 0;
                    },
                    isEditing: function () {
                        return false;
                    }
                }
            });

            modalInstance.result.then(function () {
                getPedidos();
            });
        }

        function edit(pedido) {
            var modalInstance = $uibModal.open({
                templateUrl: '/App/Main/views/pedido/pedido_create_or_edit.cshtml',
                controller: 'app.views.pedido.pedido_create_or_edit as vm',
                backdrop: 'static',
                resolve: {
                    id: function () {
                        return pedido.id;
                    },
                    isEditing: function () {
                        return true;
                    }
                }
            });

            modalInstance.result.then(function () {
                getPedidos();
            });
        }

        function Delete(pedido) {
            swal({
                title: "Remover Pedido",
                text: "Você deseja remover o pedido '" + pedido.nomeProduto + "'?",
                type: "warning",
                showCancelButton: true,
                confirmButtonColor: "#DD6B55",
                confirmButtonText: "Sim!",
                closeOnConfirm: false,
                html: false
            }, function () {
                pedidoService.deletePedido(pedido.id)
                    .then(deletedMessage, errorMessage);
                function deletedMessage() {
                    swal("Deletado!",
                        "Seu Pedido foi deletado.",
                        "success");
                    getPedidos();
                }
            });
        }
    }
})();