(function () {
    'use strict';

    angular
        .module('app')
        .controller('app.views.cliente.clientepedido_index', ClientepedidoController)

    ClientepedidoController.$inject =
        [
            '$uibModal',
            'abp.services.app.cliente',
            'abp.services.app.pedido',
            '$state',
            '$timeout'
        ];

    function ClientepedidoController($uibModal, clientepedidoService, pedidoclienteService, $state, $timeout) {
        var vm = this;
        vm.clientes = [];
        vm.pedidos = [];
        vm.save = save;

        activate();

        function activate() {
            abp.ui.setBusy();
            getClientePedidos();
        }

        function refresh() {
            getClientePedidos();
        }

        function getClientePedidos() {
            clientepedidoService.getAllCliente()
                .then(fillClientes, errorMessage)
                .catch(unblockByError);         

            getPedidosClientes();

            function fillClientes(result) {
                vm.clientes = result.data.clientes;
                abp.ui.clearBusy();
            }    

            function unblockByError(error) {
                console.log(error);
                abp.ui.clearBusy();
            }
        }

        function getPedidosClientes() {
            pedidoclienteService.getAllPedido()
                .then(fillPedidos, errorMessage)
                .catch(unblockByError);       

            function fillPedidos(result) {
                vm.pedidos = result.data.pedidos;
                abp.ui.clearBusy();
            }   

            function unblockByError(error) {
                console.log(error);
                abp.ui.clearBusy();
            }
        }

        function errorMessage(result) {
            abp.ui.clearBusy();
            abp.notify.error(result);
        }

        function save(cliente,pedido) {
            clientepedidoService.vincularPedido(cliente, pedido)
                .then(success)
                .catch(unblockByError);
        };

        function success() {
            abp.ui.clearBusy();
            $uibModalInstance.close({});
        }

        function unblockByError(error) {
            console.log(error);
            abp.ui.clearBusy();
        }
    }
})();